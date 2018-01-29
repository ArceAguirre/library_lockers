using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Runtime.InteropServices;
using DataTables;
using MetroFramework.Forms;

namespace FCFM_Registro_Alumnos
{
    public partial class AltaAlumno : MetroForm
    {
        //FCFM_Registro_Alumnos.DataSet1TableAdapters.alumnosTableAdapter AL = new DataSet1TableAdapters.alumnosTableAdapter();
        //static string ConnectionString = "Database=FCFM Registro Horas;Server=DARKKNESS;Integrated Security=SSPI";

        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        Student student = new Student();
        string tipoServicio;
        string periodo;
        private bool Once = true;
        private string Matricula_Alumno;
        private bool FromContext;


        public AltaAlumno()
        {
            InitializeComponent();
            FromContext = false;
        }

        public AltaAlumno(string Matricula)
        {
            Matricula_Alumno = Matricula;
            InitializeComponent();
            FromContext = true;
        }

        private void SetStudents()
        {
            foreach (var Student in DM.GetAllStudents())
            {
                string Nombre = Student.Nombre + " " + Student.Second_Name + " " + Student.Second_Name2;
                AlumnosList.SetItemSubItems(Student.Matricula.ToString(), Nombre);
                AlumnosList.SetItemSubItems(Student.Matricula.ToString(), Student.Carrera);
                AlumnosList.SetItemSubItems(Student.Matricula.ToString(), Student.Semestre.ToString());
                AlumnosList.SetItemSubItems(Student.Matricula.ToString(), Student.Periodo);
                AlumnosList.SetItemSubItems(Student.Matricula.ToString(), Student.T_Servicio);
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

            if (A_Matricula.TextLength < 7)
            {
                MessageBox.Show("La matricula tiene que tener minimo 7 caracteres");
            }
            else
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
                student.Carrera = Carrera.Text;
                student.Semestre = int.Parse(Semestre.Text);
                student.T_Servicio = tipoServicio.ToString();
                student.Periodo = periodo.ToString();

                if (!DM.StudentExistByMatricula(int.Parse(A_Matricula.Text)))
                {
                    DM.InsertStudent(student);

                    string Nombre = A_Nombre.Text.ToUpper() + " " + A_ApellidoP.Text.ToUpper() + " " + A_ApellidoM.Text.ToUpper();
                    AlumnosList.SetItemSubItems(A_Matricula.Text, Nombre);
                    AlumnosList.SetItemSubItems(A_Matricula.Text, Carrera.Text);
                    AlumnosList.SetItemSubItems(A_Matricula.Text, Semestre.Text);
                    AlumnosList.SetItemSubItems(A_Matricula.Text, periodo.ToString());
                    AlumnosList.SetItemSubItems(A_Matricula.Text, tipoServicio.ToString());

                    StateText.Text = "Alumno Agregado...";

                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    Carrera.SelectedIndex = 0;
                    Semestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;
                }
                else
                {
                    MessageBox.Show("El alumno ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AltaAlumno_Load(object sender, EventArgs e)
        {
            if (!FromContext)
            {
                Carrera.SelectedIndex = 0;
                Semestre.SelectedIndex = 0;
                AddStudent.Enabled = true;
                Cancel.Enabled = true;
                DeleteStudent.Enabled = false;
                Edit.Enabled = false;
                AlumnosList.View = View.Details;
                SetStudents();
                A_Matricula.Focus();
            }
            else
            {
                Carrera.SelectedIndex = 0;
                Semestre.SelectedIndex = 0;
                AddStudent.Enabled = false;
                Cancel.Enabled = true;
                DeleteStudent.Enabled = false;
                Edit.Enabled = false;
                AlumnosList.Enabled = false;

                A_Matricula.Enabled = false;
                A_Nombre.Enabled = false;
                A_ApellidoP.Enabled = false;
                A_ApellidoM.Enabled = false;
                Carrera.Enabled = false;
                Semestre.Enabled = false;
                Becario.Enabled = false;
                ServicioSocial.Enabled = false;
                Verano.Enabled = false;
                Invierno.Enabled = false;

                AlumnosList.View = View.Details;
                SetSingleStudent(int.Parse(Matricula_Alumno));
                A_Matricula.Focus();
            }
        }


        private void SetSingleStudent(int matricula)
        {
            Student temp = DM.GetStudentByMatricula(matricula);
            string Nombre = temp.Nombre + " " + temp.Second_Name + " " + temp.Second_Name2;
            AlumnosList.SetItemSubItems(temp.Matricula.ToString(), Nombre);
            AlumnosList.SetItemSubItems(temp.Matricula.ToString(), temp.Carrera);
            AlumnosList.SetItemSubItems(temp.Matricula.ToString(), temp.Semestre.ToString());
            AlumnosList.SetItemSubItems(temp.Matricula.ToString(), temp.Periodo);
            AlumnosList.SetItemSubItems(temp.Matricula.ToString(), temp.T_Servicio);

            A_Matricula.Text = temp.Matricula.ToString();
            A_Nombre.Text = temp.Nombre;
            A_ApellidoP.Text = temp.Second_Name;
            A_ApellidoM.Text = temp.Second_Name2;
            Carrera.Text = temp.Carrera;
            Semestre.Text = temp.Semestre.ToString();
            tipoServicio = temp.T_Servicio;
            periodo = temp.Periodo;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            StateText.Text = "";
            this.Close();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            if (AlumnosList.SelectedItems.Count > 0)
                Edit.Enabled = true;
            else
                Edit.Enabled = false;
        }

        private void A_Matricula_TextChanged(object sender, EventArgs e)
        {
            if (A_Matricula.TextLength > 7)
            {
                MessageBox.Show("La Matricula no puede ser mayor a 7 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string mat = A_Matricula.Text.Remove(A_Matricula.Text.Count() - 1);
                A_Matricula.Text = mat;
                Edit.Enabled = false;
            }
            else
                if (AlumnosList.SelectedItems.Count > 0)
                    Edit.Enabled = true;
                else
                    Edit.Enabled = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            AlumnosList.UpdateItemSubItems(SaveStudent());

            StateText.Text = "Alumno Editado...";
            A_Matricula.Text = "";
            A_Nombre.Text = "";
            A_ApellidoP.Text = "";
            A_ApellidoM.Text = "";
            Carrera.SelectedIndex = 0;
            Semestre.SelectedIndex = 0;
            Becario.Checked = true;
            Verano.Checked = true;

            A_Matricula.Focus();
            AddStudent.Enabled = true;
            Cancel.Enabled = true;
            DeleteStudent.Enabled = false;
            Edit.Enabled = false;
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (!Edit.Enabled)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el registro?", "Atencion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    student.Matricula = int.Parse(A_Matricula.Text);
                    student.Nombre = A_Nombre.Text;
                    student.Second_Name = A_ApellidoP.Text;
                    student.Second_Name2 = A_ApellidoM.Text;
                    student.Carrera = Carrera.Text;
                    student.Semestre = int.Parse(Semestre.Text);
                    student.T_Servicio = tipoServicio.ToString();
                    student.Periodo = periodo.ToString();
                    DM.DeleteStudent(student);

                    AlumnosList.DeleteSelectedIndex(false);

                    StateText.Text = "Alumno Eliminado...";
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    Carrera.SelectedIndex = 0;
                    Semestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;

                    A_Matricula.Focus();
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                    Edit.Enabled = false;
                }
                else if (result == DialogResult.No)
                {
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    Carrera.SelectedIndex = 0;
                    Semestre.SelectedIndex = 0;
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
                DialogResult result = MessageBox.Show("Desea continuar sin aplicar los cambios?", "Atencion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteStudent.Text = "Eliminar";
                    A_Matricula.Text = "";
                    A_Nombre.Text = "";
                    A_ApellidoP.Text = "";
                    A_ApellidoM.Text = "";
                    Carrera.SelectedIndex = 0;
                    Semestre.SelectedIndex = 0;
                    Becario.Checked = true;
                    Verano.Checked = true;

                    A_Matricula.Focus();
                    AddStudent.Enabled = true;
                    Cancel.Enabled = true;
                    DeleteStudent.Enabled = false;
                }
                else if (result == DialogResult.No)
                {
                    ////Continue in code
                }

            }
        }

        private List<string> SaveStudent()
        {
            List<string> data = new List<string>();

            student.Matricula = int.Parse(A_Matricula.Text);
            student.Nombre = A_Nombre.Text.ToUpper();
            student.Second_Name = A_ApellidoP.Text.ToUpper();
            student.Second_Name2 = A_ApellidoM.Text.ToUpper();
            student.Carrera = Carrera.Text;
            student.Semestre = int.Parse(Semestre.Text);
            student.T_Servicio = tipoServicio.ToString();
            student.Periodo = periodo.ToString();
            //DM.UpdateStudent(student);

            data.Add(A_Matricula.Text);
            string Name = A_Nombre.Text.ToUpper() + " " + A_ApellidoP.Text.ToUpper() + " " + A_ApellidoM.Text.ToUpper();
            data.Add(Name);
            data.Add(Carrera.Text);
            data.Add(Semestre.Text);
            data.Add(periodo.ToString());
            data.Add(tipoServicio.ToString());

            ///update
            return data;
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
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void AlumnosList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string[] name = AlumnosList.GetSubItemsFromSelectedIndex(1).Split(' ');
            if (name.Count() > 1)
            {
                A_Matricula.Text = AlumnosList.GetSubItemsFromSelectedIndex(0);

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

                Carrera.Text = AlumnosList.GetSubItemsFromSelectedIndex(2);
                Semestre.Text = AlumnosList.GetSubItemsFromSelectedIndex(3);
                tipoServicio = AlumnosList.GetSubItemsFromSelectedIndex(5);
                periodo = AlumnosList.GetSubItemsFromSelectedIndex(4);

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
            }

            if (AlumnosList.SelectedIndices.Count <= 1)
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

        private void Edit_EnabledChanged(object sender, EventArgs e)
        {
            if (Edit.Enabled)
                DeleteStudent.Text = "Cancelar Edicion";
            else
                DeleteStudent.Text = "Eliminar";
        }
    }
}
