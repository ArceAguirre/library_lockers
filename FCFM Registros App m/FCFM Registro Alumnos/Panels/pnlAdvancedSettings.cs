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
using MetroFramework.Forms;
using MetroPanelSlide.Panel;
using MetroFramework;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using FCFM_Registro_Alumnos;
using MetroFramework.Controls;



namespace MetroPanelSlide.Panel{
   
    public partial class pnlAdvancedSettings : pnlSlider, IMetroControl{ 
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        Encrypting encript = new Encrypting();
        private bool CreatedDB;
        private bool CreatedTables;
        private bool DeletedDB;
        private bool DeletRegsDB;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        Process process;
        StringBuilder stdOutput;

        //Aplications Threads
        Thread EpicorThread;
        private string path;
        private string DBName;
        private string Args;
        private bool IsProcessRunning;
        private string stdError;
        private string output;
        private bool NoDB;
        private bool NoTables;
        private bool DbCreated;
        
        public pnlAdvancedSettings(Form owner, SettingsData _Opciones, string _DBName, string _Path, bool _NoDB, bool _NoTables)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            DBName = _DBName;
            NoDB = _NoDB;
            NoTables = _NoTables;
            path = _Path;
            this.StyleManager.Update();
            //this.StyleManager.Update();
        }

        private void pnlAdvancedSettings_Load(object sender, EventArgs e)
        {
            process = new Process();
            //this.StyleManager.Update();
            if (NoDB)
            {
                mpAddManager.Enabled = false;
                mpDelete.Enabled = false;
                CreateTables.Enabled = false;
                Cancel.Enabled = false;
            }

            if (NoTables)
            {
                mpAddManager.Enabled = false;
                mpDelete.Enabled = false;
                CreateDB.Enabled = false;
                Cancel.Enabled = false;
            }
        }

        #region Delegates
        public delegate void UpdateEnableCallBack(bool State, MetroFramework.Controls.MetroButton btn);
        private void UpdateEnable(bool State, MetroFramework.Controls.MetroButton btn)
        {
            btn.Enabled = State;
        }

        public delegate void ActivateCallBack(MetroFramework.Controls.MetroButton btn);
        private void Activate(MetroFramework.Controls.MetroButton btn)
        {
            btn.Enabled = true;
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

        private void StartProcess(object btnP)
        {
            MetroButton btn = (MetroButton)btnP;

            process.Start();

            process.BeginOutputReadLine();
            //stdError = process.StandardError.ReadToEnd();
            stdError = process.StandardError.ReadToEndAsync().ToString();

            System.Threading.Thread.Sleep(300);

            output = stdOutput.ToString();
            if (output.Length > 0)
            {
                btn.Invoke(new UpdateEnableCallBack(this.UpdateEnable), new object[] { false, btn });
            }

            if (process.HasExited || !process.HasExited)
            {
                //IsTaskAgentRunning = true;
            }

            process.WaitForExit();

            btn.Invoke(new ActivateCallBack(this.Activate), new object[] { btn });

            if (process.HasExited)
            {
                //Invoke(new IsProcessRunningCallBack(this.IsRunning), new object[] { false });
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

        private bool VerifyIfDBExist(string str, string DB)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master; Integrated Security=SSPI;User ID=" + Connection.USER + ";Password=");
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
            if (VerifyIfDBExist(str, DBName))
            {
                con = new SqlConnection("Data Source=" + str + ";Database=Master; Integrated Security=SSPI ;" +
                        "User ID=" + Connection.USER +";Password=" + Connection.PASSWORD );
                con.Open();
                cmd = new SqlCommand("SELECT TABLE_NAME FROM [" + Connection.DATA_BASE + "].INFORMATION_SCHEMA.Tables ", con);
                dr = cmd.ExecuteReader();

                
                //if (dr.HasRows)
                //    return true;
                //else
                //    return false;
            }
            //else
            //    return false;
            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            string dir = path;
            string db = "\"" + DBName + "\"";
            //DialogResult result = MessageBox.Show("Base de datos no existente, Comuniquese con su Administrador para instalar la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Esta apunto de eliminar la Base de datos " + db + ", estas seguro?    (Recuerde creear un respaldo en " +
            dir + " antes de eliminar " + db + " y debera crear la Base de datos otravez para evitar errores)"
            , "ADVERTENCIA - EDICION DE DATOS.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DeletedDB = true;

                //Usage
                string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\DeleteDB.bat";
                Args = db + " " + dir;

                if (!IsProcessRunning)
                {
                    RunExternalExe(ToolFileName, Args);
                    EpicorThread = new Thread(new ParameterizedThreadStart(StartProcess));
                    EpicorThread.Start(sender);
                }
            }
            if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void CreateTables_Click(object sender, EventArgs e)
        {
            string dir = path;
            string db = "\"" + DBName + "\"";

            CreatedTables = true;

            //Usage
            string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\CreateTables.bat";
            Args = db + " " + dir;

            if (!IsProcessRunning)
            {
                RunExternalExe(ToolFileName, Args);
                EpicorThread = new Thread(new ParameterizedThreadStart(StartProcess));
                EpicorThread.Start(sender);
            }
        }

        private void DeleteRows_Click(object sender, EventArgs e)
        {
            string dir = path;
            string db = "\"" + DBName + "\"";

            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Esta apunto de eliminar los Registros de " + db +
                ", estas seguro?    (Recuerde creear un respaldo antes de eliminar los " +
            "Registros en " + dir +
            " )", "ADVERTENCIA - EDICION DE DATOS.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DeletRegsDB = true;

                //Usage
                string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\DeleteRecordsDB.bat";
                Args = db + " " + dir;

                if (!IsProcessRunning)
                {
                    RunExternalExe(ToolFileName, Args);
                    EpicorThread = new Thread(new ParameterizedThreadStart(StartProcess));
                    EpicorThread.Start(sender);
                }
            }
            if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void CreateDB_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
            string dir = path;
            string db = "\"" + DBName + "\"";

            CreatedDB = true;

            //Usage
            string ToolFileName = Environment.CurrentDirectory + "\\BatchFiles\\CreateDB.bat";
            Args = db + " " + dir;

            if (!IsProcessRunning)
            {
                RunExternalExe(ToolFileName, Args);
                EpicorThread = new Thread(new ParameterizedThreadStart(StartProcess));
                EpicorThread.Start(sender);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbName.Text) | string.IsNullOrEmpty(mtbPass.Text))
            {
                MessageBox.Show("Debe de ingresar Nombre y Password.");
                return;
            }
            else
            {
                string pass = encript.ComputeHash(mtbPass.Text, "SHA512", null);
                DM.InsertUser(mtbName.Text, pass);
                //label8.Visible = true;
                //label8.Text = "Usuario Agregado";
                mtbName.Text = "";
                mtbPass.Text = "";
            }
        }

        private void CreateDB_EnabledChanged(object sender, EventArgs e)
        {
            if (CreateDB.Enabled)
            {
                if (!VerifyIfDBExist(Connection.SERVER, DBName))
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Se han producido un error al crear la base de datos, trate de crearla de nuevo o reiniciar la aplicacion," +
                        " en caso de que siga presentando errores contactar con el administrador del sistema.", "ERROR - FALLO AL CRERA LA BASE DE DATOS.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        mpDelete.Enabled = false;
                        mpAddManager.Enabled = false;
                        CreateTables.Enabled = false;
                    }
                }
                else
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Se ha creado la base de datos con exito."
                    , "BASE DE DATOS CREADA CON EXITO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        mpDelete.Enabled = false;
                        mpAddManager.Enabled = false;
                        CreateTables.Enabled = true;
                        CreateDB.Enabled = false;
                        DbCreated = true;
                    }
                }
            }
        }

        private void CreateTables_EnabledChanged(object sender, EventArgs e)
        {
            if (CreateTables.Enabled)
            {
                if (!TablesExist(Connection.SERVER, DBName))
                {

                    if (DbCreated)
                    {

                        DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Se han producido un error al crear las tablas, trate de crearlas de nuevo o reiniciar la aplicacion," +
                            " en caso de que siga presentando errores contactar con el administrador del sistema.", "ERROR - FALLO AL CREAR TABLAS.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (result == DialogResult.OK)
                        {
                            mpDelete.Enabled = false;
                            mpAddManager.Enabled = false;
                            CreateDB.Enabled = false;
                            Cancel.Enabled = false;
                        }
                    }
                    else
                    {
                        mpDelete.Enabled = false;
                        mpAddManager.Enabled = false;
                        CreateDB.Enabled = false;
                        Cancel.Enabled = false;
                        DbCreated = false;
                    }
                }
                else
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Se han creado las tablas para almacenar datos con exito."
                    , "TABLAS CREADAS CON EXITO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        //mpDelete.Enabled = true;
                        //mpAddManager.Enabled = true;
                        //CreateDB.Enabled = true;
                        Cancel.Enabled = true;
                        this.swipe(false);
                    }
                }
            }
        }
    }
}
