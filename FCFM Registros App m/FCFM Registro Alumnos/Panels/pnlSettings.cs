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
using System.IO;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using FCFM_Registro_Alumnos.UI_Forms;

namespace MetroPanelSlide.Panel
{
    public partial class pnlSettings : pnlSlider, IMetroControl
    {
        List<string> settings = new List<string>(5);
        public SettingsData Temp = new SettingsData();
        string DBName;

        public pnlSettings(Form owner, string _DBName) : base(owner)
        {
            InitializeComponent();
            ReadSettings("Settings.txt");
            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
                if (Temp.Ayuda)
                { 
                    string color = ((MetroTile)_tile).Style.ToString();
                    switch (color)
                    {
                        case "Silver":
                            mttHelp.SetToolTip((Control)_tile, "Planta");
                            break;
                        case "Blue":
                            mttHelp.SetToolTip((Control)_tile, "Azul");
                            break;
                        case "Green":
                            mttHelp.SetToolTip((Control)_tile, "Verde");
                            break;
                        case "Lime":
                            mttHelp.SetToolTip((Control)_tile, "Verde Limon");
                            break;
                        case "Teal":
                            mttHelp.SetToolTip((Control)_tile, "Celeste");
                            break;
                        case "Orange":
                            mttHelp.SetToolTip((Control)_tile, "Naranja");
                            break;
                        case "Brown":
                            mttHelp.SetToolTip((Control)_tile, "Cafe");
                            break;
                        case "Pink":
                            mttHelp.SetToolTip((Control)_tile, "Rosa");
                            break;
                        case "Magenta":
                            mttHelp.SetToolTip((Control)_tile, "Magenta");
                            break;
                        case "Purple":
                            mttHelp.SetToolTip((Control)_tile, "Morado");
                            break;
                        default:
                            break;
                    }
                }
            }
            DBName = _DBName;
            this.StyleManager.Update();
        }

        void _tile_Click(object sender, EventArgs e)
        {
            msManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void metroSave_Click(object sender, EventArgs e)
        {
            WriteSetting("S-" + Convert.ToInt32(msManager.Style), "S-" + Convert.ToInt32(msManager.Style), true, true);
            WriteSetting(HoraCorte.Text, HoraCorte.Text, true, false);
            SaveSettings(settings, "Settings.txt");

            DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "La aplicacion se reiniciara para que tomen efecto los cambios realizados"
                , "ADVERTENCIA - REINICIO DE APLICACION.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (Result == DialogResult.OK)
            {
                this.swipe(false);
                Application.Restart();
                
            }

        }

        private void metroCancel_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void SaveSettings(List<string> Settings, string FileName)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                string PathSettingsFile = Environment.CurrentDirectory + "\\SettingsFiles\\" + FileName;
                StreamWriter sw = new StreamWriter(PathSettingsFile);

                foreach (var Set in Settings)
                {
                    //Write a line of text
                    sw.WriteLine(Set);
                }
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Guardar Configuracion, Error: " + e.Message);
            }
        }

        private void ReadSettings(string FileName)
        {
            try
            {
                //String[] line;
                List<string> line = new List<string>();
                //Pass the file path and file name to the StreamReader constructor
                string PathSettingsFile = Environment.CurrentDirectory + "\\SettingsFiles\\" + FileName;
                StreamReader sr = new StreamReader(PathSettingsFile);

                //Read the first line of text
                if (sr != null)
                {
                    line.Add(sr.ReadLine());
                }

                //Continue to read until you reach end of file
                while (line.Count > 0 && !sr.EndOfStream)
                {
                    //Read the next line
                    line.Add(sr.ReadLine());
                }

                //close the file
                sr.Close();
                SetSettings(line);
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al Leer las Configuraciones, Error: " + e.Message);
            }
        }

        private void SetSettings(List<string> settings_List)
        {
            foreach (var setting in settings_List)
            {
                if (setting == "M")
                {
                    metroManual.Checked = true;
                    Temp.Manual = true;
                    Temp.Automatico = false;
                }

                if (setting == "A")
                {
                    metroAutomatico.Checked = true;
                    Temp.Manual = false;
                    Temp.Automatico = true;
                }

                if (setting == "D")
                {
                    metroDarkTheme.Checked = true;
                    Temp.DarkTheme = true;
                    Temp.LighTheme = false;
                }

                if (setting == "L")
                {
                    metroLightTheme.Checked = true;
                    Temp.DarkTheme = false;
                    Temp.LighTheme = true;
                }

                if (setting == "AE")
                {
                    metroActividad.Checked = true;
                    Temp.VerActividad = true;
                }

                if (setting == "AD")
                {
                    metroActividad.Checked = false;
                    Temp.VerActividad = false;
                }

                if (setting == "HELPE")
                {
                    metroAyuda.Checked = true;
                    Temp.Ayuda = true;
                }

                if (setting == "HELPD")
                {
                    metroAyuda.Checked = false;
                    Temp.Ayuda = false;
                }


                if (setting == "SE")
                {
                    metroScanner.Checked = true;
                    Temp.Escaner = true;
                }

                if (setting == "SD")
                {
                    metroScanner.Checked = false;
                    Temp.Escaner = false;
                }


                if (setting == "HE")
                {
                    metroHolyDays.Checked = true;
                    Temp.DiaFestivo = true;
                }

                if (setting == "HD")
                {
                    metroHolyDays.Checked = false;
                    Temp.DiaFestivo = false;
                }


                if (setting == "VE")
                {
                    metroVacations.Checked = true;
                    Temp.Vacaciones = true;
                }

                if (setting == "VD")
                {
                    metroVacations.Checked = false;
                    Temp.Vacaciones = false;
                }

                if (setting == "CE")
                {
                    metroAutoCorte.Checked = true;
                    Temp.AutoCorte = true;
                }

                if (setting == "CD")
                {
                    metroAutoCorte.Checked = false;
                    Temp.AutoCorte = false;
                }

                if (setting == "NE")
                {
                    metroNotificaciones.Checked = true;
                    Temp.Notificaciones = true;
                }

                if (setting == "ND")
                {
                    metroNotificaciones.Checked = false;
                    Temp.Notificaciones = false;
                }

                if (setting.Contains(":"))
                {
                    HoraCorte.Text = setting;
                    Temp.HoraCorte = setting;
                }

                if (setting.Contains("-"))
                {
                    string[] s;
                    s = setting.Split('-');
                    msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);
                    Temp.Estilo = setting;
                }
            }
        }

        private void WriteSetting(string enabled, string disabled, bool Checked, bool swipe)
        {
            if (settings.Contains(enabled))
            {
                settings[settings.IndexOf(enabled)] = disabled;
            }
            else
            {
                if (!swipe)
                {
                    if (settings.Contains(disabled))
                    {
                        settings[settings.IndexOf(disabled)] = enabled;
                    }
                    else
                    {
                        if (Checked)
                            settings.Add(enabled);
                        else
                            settings.Add(disabled);
                    }
                }
                else
                {
                    if (Checked)
                        settings.Add(disabled);
                }

            }
        }

        #region CheckedChangedControls

        private void metroActividad_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("AE", "AD", metroActividad.Checked, false);

            if (metroActividad.Checked)
                Temp.VerActividad = true;
            else
                Temp.VerActividad = false;
        }

        private void metroNotificaciones_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("NE", "ND", metroNotificaciones.Checked, false);

            if (metroNotificaciones.Checked)
                Temp.Notificaciones = true;
            else
                Temp.Notificaciones = false;
        }

        private void metroScanner_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("SE", "SD", metroScanner.Checked, false);

            if (metroScanner.Checked)
                Temp.Escaner = true;
            else
                Temp.Escaner = false;
        }

        private void metroAyuda_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("HELPE", "HELPD", metroAyuda.Checked, false);

            if (metroAyuda.Checked)
                Temp.Ayuda = true;
            else
                Temp.Ayuda = false;
        }

        private void metroAutoCorte_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("CE", "CD", metroAutoCorte.Checked, false);

            if (metroAutoCorte.Checked)
            {
                Temp.AutoCorte = true;
                HoraCorte.Enabled = true;
            }
            else
            {
                Temp.AutoCorte = false;
                HoraCorte.Enabled = false;
            }
        }

        private void metroVacations_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("VE", "VD", metroVacations.Checked, false);

            if (metroVacations.Checked)
            {
                metroHolyDays.Enabled = false;
                Temp.Vacaciones = true;
            }
            else
            {
                metroHolyDays.Enabled = true;
                Temp.Vacaciones = false;
            }
        }

        private void metroHolyDays_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("HE", "HD", metroHolyDays.Checked, false);

            if (metroHolyDays.Checked)
            {
                metroVacations.Enabled = false;
                Temp.DiaFestivo = true;
            }
            else
            {
                metroVacations.Enabled = true;
                Temp.DiaFestivo = false;
            }
        }

        private void metroManual_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("A", "M", metroManual.Checked, true);

            if (metroManual.Checked)
            {
                Temp.Manual = true;
                metroScanner.Enabled = false;
                metroScanner.Checked = false;
            }
            else
            {
                Temp.Manual = false;
                metroScanner.Enabled = true;
            }
        }

        private void metroAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("M", "A", metroAutomatico.Checked, true);

            if (metroAutomatico.Checked)
                Temp.Automatico = true;
            else
                Temp.Automatico = false;
        }

        private void metroDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("L", "D", metroDarkTheme.Checked, true);

            if (metroDarkTheme.Checked)
            {
                Temp.DarkTheme = true;
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                Temp.DarkTheme = false;
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }
                
        }

        private void metroLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("D", "L", metroLightTheme.Checked, true);

            if (metroLightTheme.Checked)
            {
                Temp.LighTheme = true;
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            else
            {
                Temp.LighTheme = false;
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        #endregion

        private void pnlSettings_Load(object sender, EventArgs e)
        {
            

            if (metroAutoCorte.Checked)
            {
                Temp.AutoCorte = true;
                HoraCorte.Enabled = true;
            }
            else
            {
                Temp.AutoCorte = false;
                HoraCorte.Enabled = false;
            }

            if (Temp.Ayuda)
            {
                mttHelp.SetToolTip(this.metroCancel, "  Cancela y regresa a la pantalla anterior.  ");
                mttHelp.SetToolTip(this.metroSave, "  Guarda los cambios realizados.  \n  SE REINICIARA LA APLICACION  ");
                //mttHelp.SetToolTip(this.metroAceptar, "  Ingresa a las opciones avanzadas de la aplicacion.  ");
                mttHelp.SetToolTip(this.metroDarkTheme, "  Cambia el tema a un color Negro.  ");
                mttHelp.SetToolTip(this.metroLightTheme, "  Cambia el tema a un color Blanco.  ");
                mttHelp.SetToolTip(this.metroAyuda, "  Activa o Desactiva el modo de ayuda.  ");

                mttHelp.SetToolTip(this.metroActividad, "  Activa o Desactiva el modo para ver Actividades.  ");
                mttHelp.SetToolTip(this.metroNotificaciones, "  Activa o Desactiva las Notificaciones.  ");
                mttHelp.SetToolTip(this.metroScanner, "  Activa o Desactiva el modo Escaner.  ");
                mttHelp.SetToolTip(this.metroLink1, "  Ingresa a las opciones avanzadas de la aplicacion.  ");
                mttHelp.SetToolTip(this.metroAutoCorte, "  Activa o Desactiva el modo de corte automatico.  ");
                mttHelp.SetToolTip(this.metroVacations, "  Activa o Desactiva el modo de vacaciones.  ");
                mttHelp.SetToolTip(this.metroHolyDays, "  Activa o Desactiva el modo de dia festivo.  ");
                mttHelp.SetToolTip(this.metroManual, "  Activa o Desactiva el modo manual de la aplicacion.  ");
                mttHelp.SetToolTip(this.metroAutomatico, "  Activa o Desactiva el modo automatico de la aplicacion.  ");
                mttHelp.SetToolTip(this.HoraCorte, "  Ingresa una fecha valida para hacer el corte automatico.  ");

                mttHelp.SetToolTip(this.flpSettings, "  Cambia el estilo de la aplicacion a cualquiera de los colores disponibles.  ");
            }
            if (Temp.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;
        }
        public SettingsData Opciones = new SettingsData();
        private void metroLink1_Click(object sender, EventArgs e)
        {

            //using (LogIn Login = new LogIn(DBName, Temp))
            //{
            //    DialogResult Result = Login.ShowDialog();
            //    if (Result == DialogResult.Cancel)
            //    {
            //        //Opciones = stngs.Temp;
            //    }
            //}
            pnlAdvancedSettings _pnlAdvancedSettings = new pnlAdvancedSettings(this.ParentForm, Opciones,  DBName, null, false, false);
            _pnlAdvancedSettings.swipe(true);
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
