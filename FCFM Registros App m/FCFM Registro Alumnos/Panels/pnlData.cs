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
using FCFM_Registro_Alumnos;
using FCFM_Registro_Alumnos.UI_Forms;

namespace MetroPanelSlide.Panel
{
    public partial class pnlData : pnlSlider, IMetroControl
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        Student student = new Student();
        private bool FromContext;
        private string Matricula_Alumno;
        private string tipoServicio;
        private string periodo;
        private bool Once;
        private string mat;
        private bool FirstLoad;
        private string DBName;


        public pnlData(Form owner, SettingsData _Opciones, string _DBName)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            this.StyleManager.Update();
            DBName = _DBName;
        }

        public pnlData(Form owner, SettingsData _Opciones, string Matricula, string _DBName)
            : base(owner)
        {
            Matricula_Alumno = Matricula;
            InitializeComponent();
            FromContext = true;
            Opciones = _Opciones;
            this.StyleManager.Update();
            DBName = _DBName;
        }

        private void SetStudents()
        {
            AlumnosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (var Student in DM.GetAllStudents())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(AlumnosList);  // this line was missing
                string Nombre = Student.Nombre + " " + Student.Second_Name + " " + Student.Second_Name2;
                row.Cells[0].Value = Student.Matricula.ToString();
                row.Cells[1].Value = Nombre;
                row.Cells[2].Value = Student.Carrera;
                row.Cells[3].Value = Student.Semestre.ToString();
                row.Cells[4].Value = Student.Periodo;
                row.Cells[5].Value = Student.T_Servicio;
                AlumnosList.Rows.Add(row);
            }

        }

        private void pnlData_Load(object sender, EventArgs e)
        {
            if (!FromContext)
            {
                metroCarrera.SelectedIndex = 0;
                metroSemestre.SelectedIndex = 0;
                AddStudent.Enabled = true;
                Cancel.Enabled = true;
                DeleteStudent.Enabled = false;
                Edit.Enabled = false;
                FirstLoad = false;
                SetStudents();
                A_Matricula.Focus();
                AlumnosList.ClearSelection();
                FirstLoad = true;
            }
            else
            {
                metroCarrera.SelectedIndex = 0;
                metroSemestre.SelectedIndex = 0;
                AddStudent.Enabled = false;
                Cancel.Enabled = true;
                DeleteStudent.Enabled = false;
                AlumnosList.Enabled = false;

                A_Matricula.Enabled = false;
                A_Nombre.Enabled = false;
                A_ApellidoP.Enabled = false;
                A_ApellidoM.Enabled = false;
                metroCarrera.Enabled = false;
                metroSemestre.Enabled = false;
                Becario.Enabled = false;
                ServicioSocial.Enabled = false;
                Verano.Enabled = false;
                Invierno.Enabled = false;

                //AlumnosList.View = View.Details;
                //SetSingleStudent(int.Parse("1427409"));
                SetSingleStudent(int.Parse(Matricula_Alumno));
                A_Matricula.Focus();
                Edit.Enabled = false;
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (A_Matricula.Text.Length < 7)
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La matricula tiene que tener minimo 7 caracteres"
                        , "ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    return;
                }

            }
            else
            {

                if (A_Nombre.Text.Length > 0 && A_ApellidoP.Text.Length > 0 && A_ApellidoM.Text.Length > 0)
                {
                    if (Becario.Checked)
                    {
                        tipoServicio = "B";
                    }
                    else
                    {
                        if (ServicioSocial.Checked)
                            tipoServicio = "SS";
                    }

                    if (Verano.Checked)
                    {
                        periodo = "EJ";
                    }
                    else
                    {
                        if (Invierno.Checked)
                            periodo = "AD";
                    }

                    student.Matricula = int.Parse(A_Matricula.Text);
                    student.Nombre = A_Nombre.Text.ToUpper();
                    student.Second_Name = A_ApellidoP.Text.ToUpper();
                    student.Second_Name2 = A_ApellidoM.Text.ToUpper();
                    student.Carrera = metroCarrera.Text;
                    student.Semestre = int.Parse(metroSemestre.Text);
                    student.T_Servicio = tipoServicio.ToString();
                    student.Periodo = periodo.ToString();

                    if (!DM.StudentExistByMatricula(int.Parse(A_Matricula.Text)))
                    {
                        DM.InsertStudent(student);

                        string Nombre = A_Nombre.Text.ToUpper() + " " + A_ApellidoP.Text.ToUpper() + " " + A_ApellidoM.Text.ToUpper();
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(AlumnosList);  // this line was missing
                        row.Cells[0].Value = A_Matricula.Text;
                        row.Cells[1].Value = Nombre;
                        row.Cells[2].Value = metroCarrera.Text;
                        row.Cells[3].Value = metroSemestre.Text;
                        row.Cells[4].Value = periodo.ToString();
                        row.Cells[5].Value = tipoServicio.ToString();
                        AlumnosList.Rows.Add(row);

                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El alumno " + Nombre + " ah sido agregado exitosamente"
                            , "AGREGADO.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (Result == DialogResult.OK)
                        {
                            A_Matricula.Text = "";
                            A_Nombre.Text = "";
                            A_ApellidoP.Text = "";
                            A_ApellidoM.Text = "";
                            metroCarrera.SelectedIndex = 0;
                            metroSemestre.SelectedIndex = 0;
                            Becario.Checked = true;
                            Verano.Checked = true;
                        }
                    }
                    else
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El alumno ya existe en la base de datos"
                            , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (Result == DialogResult.OK)
                        {
                            return;
                        }
                    } 
                }
                else
                {
                    DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Todos los campos son obligatorios."
                            , "ADVERTENCIA - ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (Result == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
        }

        private void SetSingleStudent(int matricula)
        {
            Student temp = DM.GetStudentByMatricula(matricula);
            string Nombre = temp.Nombre + " " + temp.Second_Name + " " + temp.Second_Name2;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(AlumnosList);  // this line was missing
            row.Cells[0].Value = temp.Matricula.ToString();
            row.Cells[1].Value = Nombre;
            row.Cells[2].Value = temp.Carrera;
            row.Cells[3].Value = temp.Semestre.ToString();
            row.Cells[4].Value = temp.Periodo;
            row.Cells[5].Value = temp.T_Servicio;
            //row.
            AlumnosList.Rows.Add(row);
            //AlumnosList.Rows.IndexOf((DataGridViewRow)AlumnosList.SelectedCells[0].Value);

            //AlumnosList.SelectedCells.
            A_Matricula.Text = temp.Matricula.ToString();
            A_Nombre.Text = temp.Nombre;
            A_ApellidoP.Text = temp.Second_Name;
            A_ApellidoM.Text = temp.Second_Name2;
            metroCarrera.Text = temp.Carrera;
            metroSemestre.Text = temp.Semestre.ToString();
            tipoServicio = temp.T_Servicio;
            periodo = temp.Periodo;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DialogResult Result1 = MetroFramework.MetroMessageBox.Show(this, "Esta seguro que desea modificar el registro?."
                        , "ADVERTENCIA - CAMBIO EN PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result1 == DialogResult.Yes)
            {
                //AlumnosList.UpdateItemSubItems(SaveStudent());
                //string lastMat = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString();
                student.Matricula = int.Parse(A_Matricula.Text);
                student.Nombre = A_Nombre.Text.ToUpper();
                student.Second_Name = A_ApellidoP.Text.ToUpper();
                student.Second_Name2 = A_ApellidoM.Text.ToUpper();
                student.Carrera = metroCarrera.Text;
                student.Semestre = int.Parse(metroSemestre.Text);

                if (Becario.Checked)
                {
                    student.T_Servicio = "B";
                }
                else
                {
                    if (ServicioSocial.Checked)
                        student.T_Servicio = "SS";
                }

                if (Verano.Checked)
                {
                    student.Periodo = "EJ";
                }
                else
                {
                    if (Invierno.Checked)
                        student.Periodo = "AD";
                }

                DM.UpdateStudent(student);

                //StateText.Text = "Alumno Editado...";
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La modificacion se ha aplicado con exito."
                            , "EDICION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Result == DialogResult.OK)
                {
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    metroCarrera.SelectedIndex = 0;
                    metroSemestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;

                    A_Matricula.Focus();
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                    Edit.Enabled = false;
                    this.swipe(false);
                }
            }
            if (Result1 == DialogResult.No)
            {
                return;
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (!Edit.Enabled)
            {

                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Esta seguro que desea eliminar el registro?"
                       , "ADVERTENCIA - CAMBIO EN PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Result == DialogResult.Yes)
                {
                    student.Matricula = int.Parse(A_Matricula.Text);
                    student.Nombre = A_Nombre.Text;
                    student.Second_Name = A_ApellidoP.Text;
                    student.Second_Name2 = A_ApellidoM.Text;
                    student.Carrera = metroCarrera.Text;
                    student.Semestre = int.Parse(metroSemestre.Text);
                    student.T_Servicio = tipoServicio.ToString();
                    student.Periodo = periodo.ToString();
                    DM.DeleteStudent(student);

                    //AlumnosList.DeleteSelectedIndex(false);

                    //StateText.Text = "Alumno Eliminado...";
                    DialogResult Result2 = MetroFramework.MetroMessageBox.Show(this, "El registro ha sido eliminado con exito."
                            , "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Result2 == DialogResult.OK)
                    {
                        A_Matricula.Text = "";
                        A_Nombre.Text = "";
                        A_ApellidoP.Text = "";
                        A_ApellidoM.Text = "";
                        metroCarrera.SelectedIndex = 0;
                        metroSemestre.SelectedIndex = 0;
                        Becario.Checked = true;
                        Verano.Checked = true;

                        A_Matricula.Focus();
                        AddStudent.Enabled = true;
                        Cancel.Enabled = true;
                        DeleteStudent.Enabled = false;
                        Edit.Enabled = false;
                        this.swipe(false);
                    }
                }
                else if (Result == DialogResult.No)
                {
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    metroCarrera.SelectedIndex = 0;
                    metroSemestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;

                    A_Matricula.Focus();
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                    Edit.Enabled = false;
                }
            }
            else
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Desea continuar sin aplicar los cambios?"
                        , "ADVERTENCIA - CAMBIO EN PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Result == DialogResult.Yes)
                {
                    DeleteStudent.Text = "Eliminar";
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    metroCarrera.SelectedIndex = 0;
                    metroSemestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;

                    A_Matricula.Focus();
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                    Edit.Enabled = false;
                    AlumnosList.ClearSelection();
                    mat = null;
                }
                if (Result == DialogResult.No)
                {
                    ////Continue in code
                }

            }
        }

        private void A_Matricula_TextChanged(object sender, EventArgs e)
        {
            
            if (A_Matricula.Text.Length > 7)
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La Matricula no puede ser mayor a 7 digitos"
                        , "ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Result == DialogResult.OK)
                {
                    string matr = A_Matricula.Text.Remove(A_Matricula.Text.Count() - 1);
                    A_Matricula.Text = matr;
                    Edit.Enabled = false;
                }
            }
            else
            {
                    if (AlumnosList.SelectedRows.Count > 0)
                        Edit.Enabled = true;
                    else
                        Edit.Enabled = false;
            }

            if (mat != null)
            {
                if (!mat.Equals(A_Matricula.Text))
                {
                    if (!string.IsNullOrEmpty(A_Matricula.Text))
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La Matricula no puede ser modificada"
                            , "ERROR AL INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (Result == DialogResult.OK)
                        {
                            A_Matricula.Text = mat;
                            //Edit.Enabled = false;
                        }
                    }
                }
            }

        }

        private void A_TextChanged(object sender, EventArgs e)
        {
                if (AlumnosList.SelectedRows.Count > 0)
                    Edit.Enabled = true;
                else
                    Edit.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Once)
            {
                A_Matricula.Focus();
                Once = false;
            }
        }

        private void A_Matricula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Edit_EnabledChanged(object sender, EventArgs e)
        {
            if (Edit.Enabled)
                DeleteStudent.Text = "Cancelar Edicion";
            else
                DeleteStudent.Text = "Eliminar";
        }

        private void AlumnosList_SelectionChanged(object sender, EventArgs e)
        {
            if (AlumnosList.SelectedRows.Count <= 0)
            {
                return;
            }

            if (FirstLoad)
            {
                string[] name = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString().Split(' ');
                //string[] name = AlumnosList.GetSubItemsFromSelectedIndex(1).Split(' ');
                if (name.Count() > 1)
                {
                    //if (Edit.Enabled)
                    //{
                        mat = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString();
                        A_Matricula.Text = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString();
                        if (name.Count() > 3)
                        {
                            if (name.Count() > 4)
                            {
                                A_Nombre.Text = name[0] + " " + name[1] + " " + name[2];
                                A_ApellidoP.Text = name[3];
                                A_ApellidoM.Text = name[4];
                            }
                            else
                            {
                                A_Nombre.Text = name[0] + " " + name[1];
                                A_ApellidoP.Text = name[2];
                                A_ApellidoM.Text = name[3];
                            }
                        }
                        else
                        {
                            A_Nombre.Text = name[0];
                            A_ApellidoP.Text = name[1];
                            A_ApellidoM.Text = name[2];
                        }

                        metroCarrera.Text = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[2].Value.ToString();
                        metroSemestre.Text = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[3].Value.ToString();
                        tipoServicio = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[5].Value.ToString();
                        periodo = AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[4].Value.ToString();

                        if (tipoServicio == "B")
                        {
                            Becario.Checked = true;
                        }
                        else
                        {
                            if (tipoServicio == "SS")
                                ServicioSocial.Checked = true;
                        }

                        if (periodo == "EJ")
                        {
                            Verano.Checked = true;
                        }
                        else
                        {
                            if (periodo == "AD")
                                Invierno.Checked = true;
                        }
                    //}
                }

                if (AlumnosList.SelectedRows.Count <= 1)
                {
                    AddStudent.Enabled = false;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = true;
                    Edit.Enabled = false;
                    A_Matricula.Focus();
                }
                else
                {
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                    Edit.Enabled = false;
                    A_Matricula.Focus();
                } 
            }
        }

        private void AlumnosList_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Edit.Enabled = true;
        }

        private void pnlData_Shown(object sender, EventArgs e)
        {
            AlumnosList.ClearSelection();
        }

        private void AlumnosList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = AlumnosList.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    AlumnosList.ClearSelection();
                    AlumnosList.Rows[currentMouseOverRow].Selected = true;
                    mcMenu.Show(AlumnosList, new Point(e.X, e.Y));
                }
            } 
        }

        private void mcMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            
            switch (item.Text)
            {
                case "Horario del Alumno":
                    using (HorarioAlumno Horario = new HorarioAlumno(AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString(), Opciones))
                    {
                        DialogResult Result = Horario.ShowDialog();
                        if (Result == DialogResult.Cancel)
                        {

                        }
                    }
                break;

                case "Reporte del Alumno":
                using (RptHoras ReporteHoras = new RptHoras(AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString(), Opciones))
                {
                    DialogResult Result = ReporteHoras.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;

                case "Horas Mensuales":
                using (RptHorasTotales HorasMensuales = new RptHorasTotales(AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString(), Opciones))
                {
                    DialogResult Result = HorasMensuales.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;

                case "Control de Horas":
                using (LogIn CtrlHoras = new LogIn(DBName, Opciones, true, AlumnosList.Rows[AlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString()))
                {
                    DialogResult Result = CtrlHoras.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;
                default:
                    break;
            }
        
        }

        private void A_CheckedChanged(object sender, EventArgs e)
        {
            if (AlumnosList.SelectedRows.Count > 0)
                Edit.Enabled = true;
            else
                Edit.Enabled = false;
        }
    }
}
