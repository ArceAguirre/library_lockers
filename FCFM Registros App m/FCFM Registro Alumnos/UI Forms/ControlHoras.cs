using DataTables;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroPanelSlide.Panel;

namespace FCFM_Registro_Alumnos.UI_Forms
{
    public partial class ControlHoras : MetroForm
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        pnlDataEdition _EditData;
        private string Alumno_Matricula;
        private bool FromContext;


        string Nombre;
        string HE;
        string HS;
        string FE;
        string FS;

        public ControlHoras(SettingsData _Opciones)
        {
            InitializeComponent();
            FromContext = false;
            this.StyleManager = msManager;
            Opciones = _Opciones;
        }

        public ControlHoras(string matricula, SettingsData _Opciones)
        {
            InitializeComponent();
            Alumno_Matricula = matricula;
            this.StyleManager = msManager;
            Opciones = _Opciones;
            FromContext = true;
        }

        private void ControlHoras_Load(object sender, EventArgs e)
        {
            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

            mgAlumnosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

            if (FromContext)
            {
                _EditData = new pnlDataEdition(this, Opciones, Alumno_Matricula);
                _EditData.swipe(true);

                SetSingleStudent(int.Parse(Alumno_Matricula));
            }
            else
            {
                mgAlumnosList.Enabled = true;
                SetStudents();
            }
        }

        private void SetStudents()
        {
            foreach (var Student in DM.GetAllStudents())
            {
                string Nombre = Student.Nombre + " " + Student.Second_Name + " " + Student.Second_Name2;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(mgAlumnosList);  // this line was missing
                row.Cells[0].Value = Student.Matricula.ToString();
                row.Cells[1].Value = Nombre;
                row.Cells[2].Value = Student.Carrera;
                row.Cells[3].Value = Student.Semestre.ToString();
                row.Cells[4].Value = Student.Periodo;
                row.Cells[5].Value = Student.T_Servicio;
                mgAlumnosList.Rows.Add(row);
            }
        }

        private void SetSingleStudent(int matricula)
        {
            Student temp = DM.GetStudentByMatricula(matricula);

            Nombre = temp.Nombre + " " + temp.Second_Name + " " + temp.Second_Name2;

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(mgAlumnosList);  // this line was missing
            row.Cells[0].Value = temp.Matricula.ToString();
            row.Cells[1].Value = Nombre;
            row.Cells[2].Value = temp.Carrera;
            row.Cells[3].Value = temp.Semestre.ToString();
            row.Cells[4].Value = temp.Periodo;
            row.Cells[5].Value = temp.T_Servicio;
            mgAlumnosList.Rows.Add(row);
            ///load horarios
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mgAlumnosList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = mgAlumnosList.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    mgAlumnosList.ClearSelection();
                    mgAlumnosList.Rows[currentMouseOverRow].Selected = true;

                    _EditData = new pnlDataEdition(this, Opciones, mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[0].Value.ToString());
                    _EditData.swipe(true);
                    //mbEliminaHorario.Enabled = true;
                    //mcMenu.Show(mgHorarios, new Point(e.X, e.Y));
                }
            } 
        }

        private void mbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
