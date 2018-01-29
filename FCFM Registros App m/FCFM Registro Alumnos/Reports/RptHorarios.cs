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
    public partial class RptHorarios : MetroForm
    {
        public SettingsData Opciones = new SettingsData();

        public RptHorarios(SettingsData _opciones)
        {
            InitializeComponent();
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

            // TODO: esta línea de código carga datos en la tabla 'DataSet1.horarios' Puede moverla o quitarla según sea necesario.
            this.horariosTableAdapter.Fill(this.DataSet1.horarios);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
