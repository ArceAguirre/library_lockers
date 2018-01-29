using DataTables;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFM_Registro_Alumnos
{
    public partial class RptHoras : MetroForm
    {
        public SettingsData Opciones = new SettingsData();
        private bool LoadFromContext;
        private string Matricula_Alumno;

        public RptHoras(SettingsData _opciones)
        {
            InitializeComponent();
            LoadFromContext = false;
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        public RptHoras(string Matricula, SettingsData _opciones)
        {
            Matricula_Alumno = Matricula;
            InitializeComponent();
            Opciones = _opciones;
            this.StyleManager = msManager;
            LoadFromContext = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

            if (!LoadFromContext)
            {
                this.Registro_horasTableAdapter.Fill(this.DataSet1.Registro_horas);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                mtbMatricula.Text = Matricula_Alumno;
                mtbMatricula.Enabled = false;
                mbFiltrar.Enabled = false;

                this.Registro_horasTableAdapter.FillByRegistroHoras(this.DataSet1.Registro_horas, int.Parse(mtbMatricula.Text));
                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Registro_horasTableAdapter.FillByRegistroHoras(this.DataSet1.Registro_horas,int.Parse(mtbMatricula.Text));
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (mtbMatricula.Text.Length > 7)
            {
                MessageBox.Show("La Matricula no puede ser mayor a 7 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string mat = mtbMatricula.Text.Remove(mtbMatricula.Text.Count() - 1);
                mtbMatricula.Text = mat;
            }
        }
    }
}
