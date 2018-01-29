using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataTables;

namespace FCFM_Registro_Alumnos
{

    public partial class RegistroHoras : Form
    {
        private Menu menu;
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        SettingsData opciones = new SettingsData();

        string Stat;
        DateTime x = DateTime.Now;
        List<string> settings = new List<string>(5);
        string matricula_scanner;
        int count;
        bool zero = false;
        string RegIn = "E";
        string RegOut = "S";
        private bool Once;
        private bool ScannerBipass;

        public RegistroHoras()
        {
            InitializeComponent();
        }

        public RegistroHoras(SettingsData Opciones, Menu _menu)
        {
            InitializeComponent();
            opciones = Opciones;
            menu = _menu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (opciones.Manual)
                Modo_Manual.Enabled = true;
            else
                Modo_Manual.Enabled = false;

            //if (opciones.VerActividad)
            //    Activity.Enabled = true;
            //else
            //    Activity.Enabled = false;

            if (opciones.Escaner)
                CheckInOut.Enabled = false;
            else
                CheckInOut.Enabled = true;

            CheckInOut.BringToFront();
            Once = true;

            ScannerBipass = !opciones.Escaner;

            Hora_E.Text = DM.GetHour(DateTime.Now.Hour, DateTime.Now.Minute);
            Fecha_E.Value = DateTime.Now;
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
                MessageBox.Show("Matricula invalida, debe de tener 7 Digitos");
                Matricula.Text = "";
                Matricula.Focus();
            }
            else
            {
                if (!DM.StudentExistByMatricula(int.Parse(Matricula.Text)))
                {
                    MessageBox.Show("Alumno Inexistente");
                    Matricula.Text = "";
                    Matricula.Focus();
                }
                else
                {
                    x = DateTime.Now;
                    if (!DM.IsNewReg(int.Parse(Matricula.Text)))
                    {
                        if (opciones.Automatico)
                        {
                            //auto
                            CheckIn(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        }
                        else
                        {
                            //manual
                            CheckIn( Convert.ToDateTime(Fecha_E.Value.Date.ToString("yyyy-MM-d")), Hora_E.Text);
                        }
                        Matricula.Text = "";
                        Status.Text = "Entrada Exitosa...";
                        AlumnoName.Text = "";
                        Matricula.Focus();
                        menu.SetStudents();
                    }
                    else
                    {
                        if (opciones.Automatico)
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
                        Status.Text = "Salida Exitosa...";
                        AlumnoName.Text = "";
                        Matricula.Focus();
                        menu.SetStudents();
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //cancel = true;
            this.Close();
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {
            Status.Text = "";
            //if fill all numbers in one event

            if (Matricula.Text.Length == 7)
            {
                Student Temp = new Student();
               Temp = DM.GetStudentByMatricula(int.Parse(Matricula.Text));

                if (Temp != null)
                    AlumnoName.Text = "Nombre: " + Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2;
                else
                    AlumnoName.Text = "Alumno Inexistente.";

                bool isnew = DM.IsNewReg(int.Parse(Matricula.Text));

                if (isnew)
                {
                    CheckInOut.Text = "Salida";
                    CheckInOut.BackColor = Color.Yellow;
                }

                if (opciones.Escaner && Temp != null)
                {
                    //auto
                    if (isnew)
                    { 
                        CheckOut(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        Stat = "Salida";
                        MessageBox.Show("Salida de Alumno: " + Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2 + " Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    { 
                        CheckIn(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(x.Hour, x.Minute));
                        Stat = "Entrada";
                        MessageBox.Show("Entrada de Alumno: " + Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2 + " Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    DialogResult result = MessageBox.Show(Stat + " de Alumno: " + Temp.Nombre + " " + Temp.Second_Name + " " + Temp.Second_Name2 + " Exitosa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Once)
            {
                Matricula.Focus();
                Once = false;
            }
            Time.Text = DM.GetHour(DateTime.Now.Hour, DateTime.Now.Minute);
        }

        private void Matricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ScannerBipass)
            {
                if ((e.KeyData == Keys.Space))
                {
                    MessageBox.Show("Esta en modo Escaner, para ingresar una matricula manualmente quitar modo Escaner", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                else
                {
                    if ((e.KeyData != Keys.Back) && (e.KeyData != Keys.Enter) && (!char.IsNumber((char)e.KeyData)))
                    {
                        MessageBox.Show("Esta en modo Escaner, para ingresar una matricula manualmente quitar modo Escaner", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

    }
}
