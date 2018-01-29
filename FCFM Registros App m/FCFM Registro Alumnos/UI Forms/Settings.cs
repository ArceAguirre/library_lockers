using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTables;

namespace FCFM_Registro_Alumnos.UI_Forms
{
    public partial class Settings : Form
    {
        List<string> settings = new List<string>(5);
        public SettingsData Temp = new SettingsData();
        //Menu M = new Menu();

        public Settings()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            WriteSetting(HoraCorte.Text, HoraCorte.Text, true, false);
            SaveSettings(settings, "Settings.txt");
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ReadSettings("Settings.txt");

            if (AutoCorte.Checked)
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
                    Manual.Checked = true;
                    Temp.Manual = true;
                    Temp.Automatico = false;
                }

                if (setting == "A")
                {
                    Automatico.Checked = true;
                    Temp.Manual = false;
                    Temp.Automatico = true;
                }


                if (setting == "AE")
                { 
                    Actividad.Checked = true;
                    Temp.VerActividad = true;
                }

                if (setting == "AD")
                { 
                    Actividad.Checked = false;
                    Temp.VerActividad = false;
                }


                if (setting == "SE")
                { 
                    Scanner.Checked = true;
                    Temp.Escaner = true;
                }

                if (setting == "SD")
                { 
                    Scanner.Checked = false;
                    Temp.Escaner = false;
                }


                if (setting == "HE")
                { 
                    HolyDays.Checked = true;
                    Temp.DiaFestivo = true;
                }

                if (setting == "HD")
                { 
                    HolyDays.Checked = false;
                    Temp.DiaFestivo = false;
                }


                if (setting == "VE")
                { 
                    Vacations.Checked = true;
                    Temp.Vacaciones = true;
                }

                if (setting == "VD")
                { 
                    Vacations.Checked = false;
                    Temp.Vacaciones = false;
                }

                if (setting == "CE")
                {
                    AutoCorte.Checked = true;
                    Temp.AutoCorte = true;
                }

                if (setting == "CD")
                {
                    AutoCorte.Checked = false;
                    Temp.AutoCorte = false;
                }

                if (setting == "NE")
                {
                    Notificaciones.Checked = true;
                    Temp.Notificaciones = true;
                }

                if (setting == "ND")
                {
                    Notificaciones.Checked = false;
                    Temp.Notificaciones = false;
                }

                if (setting.Contains(":"))
                {
                    HoraCorte.Text = setting;
                    Temp.HoraCorte = setting;
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

        #region Controls_Callbacks

        private void Automatico_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("M", "A", Automatico.Checked, true);

            if (Automatico.Checked)
                 Temp.Automatico = true;
            else
                Temp.Automatico = false;
        }

        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("A", "M", Manual.Checked, true);

            if (Manual.Checked)
            {
                Temp.Manual = true;
                Scanner.Enabled = false;
                Scanner.Checked = false;
            }
            else
            {
                Temp.Manual = false;
                Scanner.Enabled = true;
            }
        }

        private void Actividad_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("AE", "AD", Actividad.Checked, false);

            if (Actividad.Checked)
                Temp.VerActividad = true;
            else
                Temp.VerActividad = false;
        }

        private void Notificaciones_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("NE", "ND", Notificaciones.Checked, false);

            if (Notificaciones.Checked)
                Temp.Notificaciones = true;
            else
                Temp.Notificaciones = false;
        }

        private void Scanner_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("SE", "SD", Scanner.Checked, false);

            if (Scanner.Checked)
                 Temp.Escaner = true;
            else
                Temp.Escaner = false;
        }

        private void HolyDays_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("HE", "HD", HolyDays.Checked, false);

            if (HolyDays.Checked)
            {
                Vacations.Enabled = false;
                Temp.DiaFestivo = true;
            }
            else
            {
                Vacations.Enabled = true;
                Temp.DiaFestivo = false;
            }
        }

        private void Vacations_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("VE", "VD", Vacations.Checked, false);

            if (Vacations.Checked)
            {
                HolyDays.Enabled = false;
                Temp.Vacaciones = true;
            }
            else
            {
                HolyDays.Enabled = true;
                Temp.Vacaciones = false;
            }
        }

        private void AutoCorte_CheckedChanged(object sender, EventArgs e)
        {
            WriteSetting("CE", "CD", AutoCorte.Checked, false);

            if (AutoCorte.Checked)
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

        #endregion
    }
}
