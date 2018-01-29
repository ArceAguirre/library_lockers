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

namespace FCFM_Registro_Alumnos
{
    public partial class RptHorasTotales : MetroForm
    {
        public SettingsData Opciones = new SettingsData();
        private string Matricula_Alumno;
        private bool LoadFromContext;
        private string FechaInicio;
        private string FechaFin;

        public RptHorasTotales(SettingsData _opciones)
        {
            InitializeComponent();
            LoadFromContext = false;
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        public RptHorasTotales(string Matricula, SettingsData _opciones)
        {
            Matricula_Alumno = Matricula;
            InitializeComponent();
            LoadFromContext = true;
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

            int month;
            if (mdtStartDate.Value.Month >= 1)
                month = mdtStartDate.Value.Month;
            else
                month = mdtStartDate.Value.Month - 1;
            

            if (month < 10)
                FechaInicio = mdtStartDate.Value.Year + "-0" + month + "-" + mdtStartDate.Value.Day;
            else
                FechaInicio = mdtStartDate.Value.Year + "-" + month + "-" + mdtStartDate.Value.Day;

            mdtStartDate.Value = Convert.ToDateTime(FechaInicio);

            //FechaInicio = StartDate.Value.Date.ToString("yyyy-MM-d");
            FechaFin = mdtEndDate.Value.Date.ToString("yyyy-MM-d");

            if (LoadFromContext)
            {
                this.alumnos1TableAdapter.FillByMatricula(this.DataSet1.alumnos1, int.Parse(Matricula_Alumno), FechaInicio, FechaFin);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!LoadFromContext)
            {
                FechaInicio = mdtStartDate.Value.Date.ToString("yyyy-MM-d");
                FechaFin = mdtEndDate.Value.Date.ToString("yyyy-MM-d");
                this.alumnos1TableAdapter.Fill(this.DataSet1.alumnos1, FechaInicio, FechaFin);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                FechaInicio = mdtStartDate.Value.Date.ToString("yyyy-MM-d");
                FechaFin = mdtEndDate.Value.Date.ToString("yyyy-MM-d");
                this.alumnos1TableAdapter.FillByMatricula(this.DataSet1.alumnos1, int.Parse(Matricula_Alumno), FechaInicio, FechaFin);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
