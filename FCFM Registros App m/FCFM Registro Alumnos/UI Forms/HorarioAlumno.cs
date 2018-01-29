using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTables;
using MetroFramework.Forms;
using MetroFramework;

namespace FCFM_Registro_Alumnos
{
    public partial class HorarioAlumno : MetroForm
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        string Matricula_Alumno;
        string[] days = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"};
        string[] Data; 
        string dia;
        string entrada;
        string salida;

        public HorarioAlumno(SettingsData _Opciones)
        {
            InitializeComponent();
            this.StyleManager = msManager;
            Opciones = _Opciones;
        }

        public HorarioAlumno(string Matricula, SettingsData _Opciones)
        {
            Matricula_Alumno = Matricula;
            InitializeComponent();
            this.StyleManager = msManager;
            Opciones = _Opciones;
        }

        private void SetItems()
        {
            int result = 0;
            int indx = 1;

            mgHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

            while (true)
            {
                if (result == 6)
                    break;
                else
                { 
                    int r = SortByDay(days[result], ref indx);
                    if (result == -1)
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Error al cargar horarios de alumno, verifique la integridad de los datos"
                            + " o contacte con el administrador de la base de datos"
                    , "ERROR - CARGA DE DATOS FALLIDA.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (Result == DialogResult.OK)
                        {
                        }
                    }
                    else
                        result += r;
                }
            }
        }

        private int SortByDay(string Dia, ref int index)
        {
            IQueryable<Horario> horarios = DM.GetHorariosByMatriculaAndDay(int.Parse(Matricula_Alumno), Dia);
            
            if (horarios != null)
            {
                if (horarios.Count() > 0)
                {
                    foreach (var hrs in horarios)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(mgHorarios);  // this line was missing
                        row.Cells[0].Value = hrs.Dia;
                        row.Cells[1].Value = hrs.Entrada;
                        row.Cells[2].Value = hrs.Salida;
                        mgHorarios.Rows.Add(row);
                        index++;
                    }
                    return 1;
                }
                else
                    return 1;
            }
            else
                return -1;
        }

        private void HorarioAlumno_Load(object sender, EventArgs e)
        {
            mbEliminaHorario.Enabled = false;

            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

            mcbDia.SelectedIndex = 0;

            SetItems();
        }

        private void AgregaHorario_Click(object sender, EventArgs e)
        {
            Horario Temphorario = new Horario();
            Temphorario.Matricula = int.Parse(Matricula_Alumno);
            Temphorario.Dia = mcbDia.Text;
            Temphorario.Entrada = dtpHora_E.Text;
            Temphorario.Salida = dtpHora_S.Text;
            DM.InsertHorario(Temphorario);

            Horario hrs = DM.GetLastHorarioAddedByMatricula(int.Parse(Matricula_Alumno));

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(mgHorarios);  // this line was missing
            row.Cells[0].Value = hrs.Dia;
            row.Cells[1].Value = hrs.Entrada;
            row.Cells[2].Value = hrs.Salida;
            mgHorarios.Rows.Add(row);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminaHorario_Click(object sender, EventArgs e)
        {
            Horario Temphorario = new Horario();

            Temphorario.Matricula = int.Parse(Matricula_Alumno);
            Temphorario.Dia = mgHorarios.Rows[mgHorarios.SelectedRows[0].Index].Cells[0].Value.ToString();
            Temphorario.Entrada = mgHorarios.Rows[mgHorarios.SelectedRows[0].Index].Cells[1].Value.ToString();
            Temphorario.Salida = mgHorarios.Rows[mgHorarios.SelectedRows[0].Index].Cells[2].Value.ToString();
            DM.DeleteHorario(Temphorario);

            mbEliminaHorario.Enabled = false;
            DeleteSelectedIndexFromDataGrid(false, mgHorarios.SelectedRows);
        }

        public void DeleteSelectedIndexFromDataGrid(bool All, DataGridViewSelectedRowCollection Selection)
        {
            if (mgHorarios.Rows[Selection[0].Index].Cells[1].Value != null || All)
            {
                if (All)
                {
                    for (int i = mgHorarios.Rows.Count - 1; i >= 0; i--)
                    {
                        mgHorarios.Rows.RemoveAt(i);
                    }
                }
                else
                {
                    if (Selection.Count <= 1)
                    {
                        for (int i = Selection.Count - 1; i <= 0; i++)
                        {
                            mgHorarios.Rows.RemoveAt(Selection[i].Index);
                        }
                    }
                    else
                    {
                        for (int i = Selection.Count - 1; i >= 0; i--)
                            mgHorarios.Rows.RemoveAt(Selection[i].Index);
                    }
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            mbEliminaHorario.Enabled = false;
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            mbEliminaHorario.Enabled = false;
        }

        private void metroGrid1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = mgHorarios.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    mgHorarios.ClearSelection();
                    mgHorarios.Rows[currentMouseOverRow].Selected = true;
                    mbEliminaHorario.Enabled = true;
                    //mcMenu.Show(mgHorarios, new Point(e.X, e.Y));
                }
            } 
        }
    }
}
