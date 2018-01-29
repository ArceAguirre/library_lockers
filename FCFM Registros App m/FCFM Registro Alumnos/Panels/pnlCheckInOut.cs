using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Interfaces;
using DataTables;

namespace MetroPanelSlide.Panel
{
    public partial class pnlCheckInOut : pnlSlider, IMetroControl
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        private FCFM_Registro_Alumnos.Menu menu;

        DateTime x = DateTime.Now;
        List<string> settings = new List<string>(5);
        string matricula_scanner;
        int count;
        bool zero = false;
        string RegIn = "E";
        string RegOut = "S";
        private bool Once;
        private bool ScannerBipass;
        private string AlumnoName;
        private string SMatricula;
        private bool FromContext;

        public pnlCheckInOut(Form owner, SettingsData _Opciones, FCFM_Registro_Alumnos.Menu _MainForm)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            menu = _MainForm;
            this.StyleManager.Update();
        }

        public pnlCheckInOut(Form owner, SettingsData _Opciones, FCFM_Registro_Alumnos.Menu _MainForm, string _Matricula, bool _FromContext)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            menu = _MainForm;
            FromContext = _FromContext;
            SMatricula = _Matricula;
            this.StyleManager.Update();
        }

        private void pnlCheckInOut_Load(object sender, EventArgs e)
        {
            if (FromContext)
            {
                Matricula.Text = SMatricula;
                Hora_E.Enabled = true;
                Fecha_E.Enabled = true;
            }
            else
            {
                if (Opciones.Manual)
                {
                    Hora_E.Enabled = true;
                    Fecha_E.Enabled = true;
                }
                else
                {
                    Hora_E.Enabled = false;
                    Fecha_E.Enabled = false;
                }
            }

            if (Opciones.Escaner)
                CheckInOut.Enabled = false;
            else
                CheckInOut.Enabled = true;

            CheckInOut.BringToFront();
            Once = true;

            ScannerBipass = !Opciones.Escaner;

            Hora_E.Text = DM.GetHour(DateTime.Now.Hour, DateTime.Now.Minute);
            Fecha_E.Value = DateTime.Now;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void CheckIn(DateTime CheckIn_Date, string CheckIn_Time)
        {
            Registro TempReg = new Registro();
            TempReg.Matricula = int.Parse(Matricula.Text);
            TempReg.Hora_Entrada = CheckIn_Time;
            TempReg.Hora_Salida = "00:00";
            TempReg.Fecha_Entrada = CheckIn_Date;
            TempReg.Fecha_Salida = Convert.ToDateTime("2001-01-01");
            TempReg.Tipo_Registro = RegIn;
            DM.InsertRegistro(TempReg);
        }

        private void CheckOut(DateTime CheckOut_Date, string CheckOut_Time)
        {
            Registro TempReg = new Registro();
            TempReg.Matricula = int.Parse(Matricula.Text);
            TempReg.Hora_Salida = CheckOut_Time;
            TempReg.Fecha_Salida = CheckOut_Date;
            TempReg.Tipo_Registro = RegOut;
            DM.UpdateRegistro(TempReg);
        }

        private void CheckInOut_Click(object sender, EventArgs e)
        {
            if (Matricula.Text.Length <= 0 || Matricula.Text.Length > 7)
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La matricula tiene que tener minimo 7 digitos"
                        , "ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    Matricula.Text = "";
                    Matricula.Focus();
                    return;
                }
                
            }
            else
            {
                if (!DM.StudentExistByMatricula(int.Parse(Matricula.Text)))
                {
                    DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El alumno que ingreso no existe o los datos son incorrectos."
                            , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (Result == DialogResult.OK)
                    {
                        Matricula.Text = "";
                        Matricula.Focus();
                        return;
                    }
                }
                else
                {
                    x = DateTime.Now;
                    if (!DM.IsNewReg(int.Parse(Matricula.Text)))
                    {
                        if (Opciones.Automatico)
                        {
                            //auto
                            CheckIn(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        }
                        else
                        {
                            //manual
                            CheckIn(Convert.ToDateTime(Fecha_E.Value.Date.ToString("yyyy-MM-d")), Hora_E.Text);
                        }
                        Matricula.Text = "";

                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Se ha ingresado al alumno " + AlumnoName + " con exito"
                            , "ENTRADA EXITOSA.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        if (Result == DialogResult.OK)
                        {
                            SName.Text = "";
                            Matricula.Focus();
                            menu.SetStudents();
                        }
                    }
                    else
                    {
                        if (Opciones.Automatico)
                        {
                            //auto
                            CheckOut(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        }
                        else
                        {
                            //manual
                            CheckOut(Convert.ToDateTime(Fecha_E.Value.Date.ToString("yyyy-MM-d")), Hora_E.Text);
                        }
                        Matricula.Text = "";
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Se ha dado salida al alumno " + AlumnoName + " con exito"
                           , "SALIDA EXITOSA.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        if (Result == DialogResult.OK)
                        {
                            SName.Text = "";
                            Matricula.Focus();
                            menu.SetStudents();
                        }
                    }
                }
            }
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {
            //Status.Text = "";
            //if fill all numbers in one event

            if (Matricula.Text.Length == 7)
            {
                Student Temp = new Student();
                Temp = DM.GetStudentByMatricula(int.Parse(Matricula.Text));

                if (Temp != null)
                    AlumnoName = Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2;
                else
                    AlumnoName = "Alumno Inexistente.";

                SName.Text = AlumnoName;

                bool isnew = DM.IsNewReg(int.Parse(Matricula.Text));

                if (isnew)
                {
                    CheckInOut.Text = "Salida";
                    CheckInOut.BackColor = Color.Yellow;
                }

                if (Opciones.Escaner && Temp != null)
                {
                    //auto
                    if (isnew)
                    {
                        CheckOut(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Se ha dado salida al alumno " + AlumnoName + " con exito"
                           , "SALIDA EXITOSA.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        if (Result == DialogResult.OK)
                        {
                            SName.Text = "";
                            Matricula.Focus();
                            menu.SetStudents();
                        }
                    }
                    else
                    {
                        CheckIn(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Se ha ingresado al alumno " + AlumnoName + " con exito"
                            , "ENTRADA EXITOSA.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        if (Result == DialogResult.OK)
                        {
                            SName.Text = "";
                            Matricula.Focus();
                            menu.SetStudents();
                        }
                    }
                    //DialogResult result = MessageBox.Show(Stat + " de Alumno: " + Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2 + " Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //if (result == DialogResult.OK)
                    //{
                    //    SName.Text = "";
                    //    this.swipe(false);
                    //}
                    menu.SetStudents();
                }
            }
            else
            {
                CheckInOut.Text = "Entrada";
                CheckInOut.BackColor = Color.SpringGreen;
            }

            //if fill one by one
            GetScannerInput(true);
        }

        private void Matricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ScannerBipass)
            {
                if ((e.KeyData == Keys.Space))
                {
                    DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Esta en modo Escaner, para ingresar una matricula manualmente quitar modo Escaner"
                        , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (Result == DialogResult.OK)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                else
                {
                    if ((e.KeyData != Keys.Back) && (e.KeyData != Keys.Enter) && (!char.IsNumber((char)e.KeyData)))
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Esta en modo Escaner, para ingresar una matricula manualmente quitar modo Escaner"
                        , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (Result == DialogResult.OK)
                        {
                            e.Handled = true;
                            return;
                        }
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Once)
            {
                Matricula.Focus();
                Once = false;
            }
        }

        private void GetScannerInput(bool Scan)
        {
            if (Scan && !zero)
            {
                if (count > 3)
                    matricula_scanner += Matricula.Text;
                else
                {
                    if (Matricula.Text.StartsWith("0"))
                    {
                        Matricula.Text = "";
                        count++;
                    }
                }
                Matricula.Text += matricula_scanner;
            }
        }

        private void Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Solo se permiten numeros"
                        , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (Result == DialogResult.OK)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

    }
}
