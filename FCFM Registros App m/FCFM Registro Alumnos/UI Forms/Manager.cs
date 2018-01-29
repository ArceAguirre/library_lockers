using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using DataTables;
using MetroFramework.Forms;
using MetroPanelSlide.Panel;
using MetroFramework;

namespace FCFM_Registro_Alumnos.UI_Forms
{
    public partial class Manager : MetroForm
    {
        public SettingsData Opciones = new SettingsData();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        Process process;
        StringBuilder stdOutput;

        //Aplications Threads
        Thread EpicorThread;

        pnlAdvancedSettings _ManagerSettings;

        string output;
        string stdError;
        bool IsProcessRunning;
        string Args;
        bool backup = false;
        bool restore = false;
        bool NoDB = false;
        string path;
        string DBName;

        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        Encrypting encript = new Encrypting();

        public Manager(string _DBName, string _Path, SettingsData _opciones)
        {
            InitializeComponent();
            path = _Path;
            DBName = _DBName;
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        public Manager(bool _NoDB, string _DBName, string _Path, SettingsData _opciones)
        {
            InitializeComponent();
            NoDB = _NoDB;
            path = _Path;
            DBName = _DBName;
            Opciones = _opciones;
            this.StyleManager = msManager;
        }

        #region Delegates

        public delegate void UpdateTextCallBack(string Text);
        private void UpdateText(string text)
        {
            richTextBox1.Text += text;
        }

        public delegate void ClearTextCallBack();
        private void ClearText()
        {
            richTextBox1.Text = "";
        }

        public delegate void IsProcessRunningCallBack(bool isRunning);
        private void IsRunning(bool isRunning)
        {

        }

        #endregion

        #region MainProcess

        public void RunExternalExe(string filename, string arguments = null)
        {
            try
            {
                process.StartInfo.FileName = filename;
                if (!string.IsNullOrEmpty(arguments))
                {
                    process.StartInfo.Arguments = arguments;
                }

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.StartInfo.UseShellExecute = false;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                stdOutput = new StringBuilder();
                process.OutputDataReceived += (sender, args) => stdOutput.Append(args.Data);

                stdError = null;
            }
            catch (Exception e)
            {
                throw new Exception("OS error while executing " + Format(filename, arguments) + ": " + e.Message, e);
            }
        }

        void StartProcess()
        {
            process.Start();

            process.BeginOutputReadLine();
            //stdError = process.StandardError.ReadToEnd();
            stdError = process.StandardError.ReadToEndAsync().ToString();

            System.Threading.Thread.Sleep(300);

            output = stdOutput.ToString();
            if (output.Length > 0)
            {
                string[] cutted = new string[100];
                cutted = output.Split('/');

                foreach (string output2 in cutted)
                {
                    richTextBox1.Invoke(new UpdateTextCallBack(this.UpdateText), new object[] { output2 + "\n" });
                }
            }

            if (process.HasExited || !process.HasExited)
            {
                //IsTaskAgentRunning = true;
            }

            process.WaitForExit();

            richTextBox1.Invoke(new ClearTextCallBack(this.ClearText));

            if (process.HasExited)
            {
                Invoke(new IsProcessRunningCallBack(this.IsRunning), new object[] { false });
                //IsTaskAgentRunning = false;
            }
            process.Close();
            process.Dispose();
            process = new Process();
        }

        public static bool IsRunning(Process process)
        {
            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (InvalidOperationException) { return false; }
            catch (ArgumentException) { return false; }
            return true;
        }

        #endregion

        public void EndProcess()
        {
            //process.WaitForExit();
        }

        private string Format(string filename, string arguments)
        {
            return "'" + filename +
                ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) +
                "'";
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            process = new Process();
            if (NoDB)
            {

                //mbCancel.Enabled = false;
                mbControlHoras.Enabled = false;
                metroLink1.Enabled = false;

                this.richTextBox1.Enabled = false;
                mctSettings.Enabled = false;
                IsProcessRunning = false;

                if (Opciones.DarkTheme)
                    msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                else
                    msManager.Theme = MetroFramework.MetroThemeStyle.Light;

                string[] s;
                s = Opciones.Estilo.Split('-');
                msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

                if (!TablesExist("(local)", DBName))
                {
                    if (!VerifyIfDBExist("(local)", DBName))
                    {
                        _ManagerSettings = new pnlAdvancedSettings(this, Opciones, DBName, path, true, false);
                        _ManagerSettings.swipe(true);
                    }
                    else
                    {
                        _ManagerSettings = new pnlAdvancedSettings(this, Opciones, DBName, path, false, true);
                        _ManagerSettings.swipe(true);
                    }
                }
            }
            else
            {
                IsProcessRunning = false;
                serverName("(local)");
                mcbServidor.SelectedIndex = 0;

                if (Opciones.DarkTheme)
                    msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                else
                    msManager.Theme = MetroFramework.MetroThemeStyle.Light;

                string[] s;
                s = Opciones.Estilo.Split('-');
                msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);

                if (!TablesExist("(local)", DBName))
                {
                    if (!VerifyIfDBExist("(local)", DBName))
                    {
                        _ManagerSettings = new pnlAdvancedSettings(this, Opciones, DBName, path, true, false);
                        _ManagerSettings.swipe(true);
                    }
                    else
                    {
                        _ManagerSettings = new pnlAdvancedSettings(this, Opciones, DBName, path, false, true);
                        _ManagerSettings.swipe(true);
                    }
                }
            }
        }

        public void serverName(string str)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; Integrated Security=SSPI");
            con.Open();
            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mcbServidor.Items.Add(dr[2]);
            }
            dr.Close();
        }

        public void Createconnection()
        {
            con = new SqlConnection("Data Source=" + (mcbServidor.Text) + ";Database=Master;data source=.; Integrated Security=SSPI");
            con.Open();
            mcbDB.Items.Clear();
            cmd = new SqlCommand("SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 4 and [name] <> 'ReportServer' and [name] <> 'ReportServerTempDB'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mcbDB.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private bool VerifyIfDBExist(string str, string DB)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; Integrated Security=SSPI");
            con.Open();
            cmd = new SqlCommand("SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 4 and [name] <> 'ReportServer' and [name] <> 'ReportServerTempDB'", con);
            dr = cmd.ExecuteReader();
            bool exist = false;

            while (dr.Read())
            {
                string name = dr[0].ToString();
                if (name == DB)
                {
                    exist = true;
                    break;
                }
                else
                {
                    exist = false;
                }
            }

            return exist;
        }

        private bool TablesExist(string str, string DBName)
        {
            if (VerifyIfDBExist("(local)", DBName))
            {
                con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; Integrated Security=SSPI");
                con.Open();
                cmd = new SqlCommand("SELECT TABLE_NAME FROM [FCFM Registro Horas].INFORMATION_SCHEMA.Tables ", con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            else
                return false;
            
        }

        private void Servidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Createconnection();
            mcbDB.SelectedIndex = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                if (VerifyIfDBExist("(local)", DBName))
                {
                    mbSave.Enabled = true;
                    mbRestore.Enabled = true;
                    mbControlHoras.Enabled = true;
                    mbCancel.Enabled = true;
                }
                else
                {
                    mbSave.Enabled = false;
                    mbRestore.Enabled = false;
                    mbControlHoras.Enabled = false;
                    mbCancel.Enabled = false;
                }

                if (restore)
                {
                    mlRestoreName.Text = "";
                    //label5.Text = "Base de Datos Restaurada Exitosamente";
                    restore = false;
                }
                if (backup)
                {
                    //label3.Text = "Base de Datos Creada Exitosamente";
                    backup = false;
                }
            }
            else
            {
                mbSave.Enabled = false;
                mbRestore.Enabled = false;
                mbControlHoras.Enabled = false;
                mbCancel.Enabled = false;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (NoDB)
            {
                MessageBox.Show("Base de datos creada con exito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                mcbServidor.Text = "";
            }
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mcbServidor.Text) | string.IsNullOrEmpty(mcbDB.Text))
            {
                MessageBox.Show("Seleccione un Servidor y una Base de Datos.");
                return;
            }
            else
            {
                if (Directory.Exists(path))
                    saveFileDialog1.InitialDirectory = path;

                backup = true;

                saveFileDialog1.FileName = mcbDB.Text + ".bak";

                DialogResult Result = saveFileDialog1.ShowDialog();

                if (Result == DialogResult.Yes)
                {
                    string dir = Path.GetDirectoryName(saveFileDialog1.FileName);
                    string db = "\"" + mcbDB.Text + "\"";
                    string back = "\"" + Path.GetFileName(saveFileDialog1.FileName) + "\"";

                    //Usage
                    string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\BackUpDB.bat";
                    Args = db + " " + dir + " " + back;

                    if (!IsProcessRunning)
                    {
                        RunExternalExe(ToolFileName, Args);
                        EpicorThread = new Thread(new ThreadStart(StartProcess));
                        EpicorThread.Start();
                    }
                }
            }
            //blank("backup");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = path;

            openFileDialog1.FileName = "";

            DialogResult Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                mlRestoreName.Text = openFileDialog1.FileName;
            }
        }

        private void mbControlHoras_Click(object sender, EventArgs e)
        {
            using (ControlHoras CtrlHoras = new ControlHoras(Opciones))
            {
                DialogResult Result = CtrlHoras.ShowDialog();
                if (Result == DialogResult.Cancel)
                {
                    //Opciones = stngs.Temp;
                }
            }
        }

        private void mbRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mcbServidor.Text) | string.IsNullOrEmpty(mcbDB.Text))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Seleccione un Servidor y una Base de Datos para continuar."
                    , "ADVERTENCIA - SERVIDOR Y BASE DE DATOS NO SELECCIONADO.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(mlRestoreName.Text))
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Seleccione un archivo para respaldar base de datos."
                    , "ADVERTENCIA - NO SE DETECTO ARCHIVO.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    if (Path.GetExtension(mlRestoreName.Text) != ".bak")
                    {
                        DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Solo se pueden usar Archivos de tipo '.bak'."
                    , "ERROR - EXTENCION ERRONEA.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (result == DialogResult.OK)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (Directory.Exists(path))
                            openFileDialog1.InitialDirectory = path;

                        restore = true;
                        string dir = Path.GetDirectoryName(openFileDialog1.FileName);
                        string db = "\"" + mcbDB.Text + "\"";
                        string back = "\"" + Path.GetFileName(openFileDialog1.FileName) + "\"";

                        //Usage
                        string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\RestoreDB.bat";
                        Args = db + " " + dir + " " + back;

                        if (!IsProcessRunning)
                        {
                            RunExternalExe(ToolFileName, Args);
                            EpicorThread = new Thread(new ThreadStart(StartProcess));
                            EpicorThread.Start();
                        }
                    }
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            _ManagerSettings = new pnlAdvancedSettings(this, Opciones, DBName, path, false, false);
            ////_Settings.Closed += _pnlone_Closed;
            ////_Settings.Shown += _pnlone_Shown;
            _ManagerSettings.swipe(true);
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
