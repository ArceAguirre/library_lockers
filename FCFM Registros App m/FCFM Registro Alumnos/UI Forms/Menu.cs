using FCFM_Registro_Alumnos.UI_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTables;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MetroPanelSlide.Panel;
using MetroFramework;

namespace FCFM_Registro_Alumnos
{
    public partial class Menu : MetroForm
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        List<StudentData> Alumnos = new List<StudentData>();
        List<StudentData> Notifications = new List<StudentData>();

        pnlSettings _Settings;
        pnlNotifications _Notifications;
        pnlCheckInOut _CheckInOut;
        pnlData _Data;

        List<StudentData> AlumnosIn = new List<StudentData>();
        const string DBName = "FCFM Registro Horas";
        string[] Data;
        private bool Exit = true;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public Menu()
        {
            InitializeComponent();
            this.StyleManager = msManager;
        }

        public SettingsData GetSettings()
        {
            return Opciones;
        }

        private void ResetScreenSize(int H, int W)
        {
            Size Temp = new Size(W, H);
            this.Size = Temp;
        }

        public void SetStudents()
        {
            if (mgAlumnosList.RowCount <= 0 && AlumnosIn.Count <= 0)
            {
                ///traer todos los alumnos sin salida
                foreach (var item in DM.GetUncheckedOutRegistro())
                {
                    StudentData TempSD = new StudentData();
                    TempSD.Registros = item;
                    TempSD.Horario = GetHorarios(item.Matricula, DM.GetCurrentDay());
                    TempSD.Alumno = DM.GetStudentByMatricula(item.Matricula);
                    AlumnosIn.Add(TempSD);
                }
                mgAlumnosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                foreach (var InTurn in AlumnosIn)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(mgAlumnosList);  // this line was missing
                    row.Cells[0].Value = InTurn.Alumno.Nombre;
                    row.Cells[1].Value = InTurn.Registros.Matricula.ToString();
                    row.Cells[2].Value = InTurn.Registros.Hora_Entrada;
                    mgAlumnosList.Rows.Add(row);
                }
            }
            else
            {
                AlumnosIn.RemoveRange(0, AlumnosIn.Count);
                DeleteSelectedIndexFromDataGrid(true, mgAlumnosList.SelectedRows);

                ///traer todos los alumnos sin salida
                foreach (var item in DM.GetUncheckedOutRegistro())
                {
                    StudentData TempSD = new StudentData();
                    TempSD.Registros = item;
                    TempSD.Horario = GetHorarios(item.Matricula, DM.GetCurrentDay());
                    TempSD.Alumno = DM.GetStudentByMatricula(item.Matricula);
                    AlumnosIn.Add(TempSD);
                }
                foreach (var InTurn in AlumnosIn)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(mgAlumnosList);  // this line was missing
                    row.Cells[0].Value = InTurn.Alumno.Nombre;
                    row.Cells[1].Value = InTurn.Registros.Matricula.ToString();
                    row.Cells[2].Value = InTurn.Registros.Hora_Entrada;
                    mgAlumnosList.Rows.Add(row);
                }
            }

            
        }

        public void DeleteSelectedIndexFromDataGrid(bool All, DataGridViewSelectedRowCollection Selection)
        {
            if (mgAlumnosList.Rows[Selection[0].Index].Cells[1].Value != null || All)
            {
                if (All)
                {
                    for (int i = mgAlumnosList.Rows.Count - 1; i >= 0; i--)
                    {
                        mgAlumnosList.Rows.RemoveAt(i);
                    }
                }
                else
                {
                    if (Selection.Count <= 1)
                    {
                        for (int i = Selection.Count - 1; i <= 0; i++)
                        {
                            mgAlumnosList.Rows.RemoveAt(Selection[i].Index);
                        }
                    }
                    else
                    {
                        for (int i = Selection.Count - 1; i >= 0; i--)
                            mgAlumnosList.Rows.RemoveAt(Selection[i].Index);
                    }
                }
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
                    Opciones.Manual = true;
                    Opciones.Automatico = false;
                }

                if (setting == "A")
                {
                    Opciones.Manual = false;
                    Opciones.Automatico = true;
                }

                if (setting == "D")
                { 
                    msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    Opciones.DarkTheme = true;
                }

                if (setting == "L")
                {
                    msManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    Opciones.LighTheme = true;
                }

                if (setting == "AE")
                    Opciones.VerActividad = true;

                if (setting == "AD")
                    Opciones.VerActividad = false;

                if (setting == "HELPE")
                    Opciones.Ayuda = true;

                if (setting == "HELPD")
                    Opciones.Ayuda = false;

                if (setting == "SE")
                    Opciones.Escaner = true;

                if (setting == "SD")
                    Opciones.Escaner = false;


                if (setting == "HE")
                    Opciones.DiaFestivo = true;

                if (setting == "HD")
                    Opciones.DiaFestivo = false;


                if (setting == "VE")
                    Opciones.Vacaciones = true;

                if (setting == "VD")
                    Opciones.Vacaciones = false;

                if (setting == "CE")
                    Opciones.AutoCorte = true;

                if (setting == "CD")
                    Opciones.AutoCorte = false;

                if (setting == "NE")
                    Opciones.Notificaciones = true;

                if (setting == "ND")
                    Opciones.Notificaciones = false;

                if (setting.Contains(":"))
                {
                    Opciones.HoraCorte = setting;
                }

                if (setting.Contains("-"))
                {
                    string[] s;
                    s = setting.Split('-');
                    msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);
                    Opciones.Estilo = setting;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ReadSettings("Settings.txt");
            VerifyDirectories();
            VerifyIfDBExist("(local)", DBName);
            TablesExist("(local)");
            ReadNotidications("Notifications.txt");

            MetroCut.Enabled = !Opciones.AutoCorte;
            this.mlNotifications.Enabled = Opciones.Notificaciones;

            SetStudents();
            //mgAlumnosList.ClearSelection();

            if (Notifications.Count > 0)
            {
                mlNotifications.Image = Properties.Resources.NotificationsYellow;
                mlNotifications.NoFocusImage = Properties.Resources.NotificationsYellowNotFocus;
            }

            if (Opciones.Ayuda)
            {
                mttHelp.SetToolTip(this.lnkSettings, "  Opciones - Edita el comportamiento de la aplicacion, tema y estilos.  ");
                mttHelp.SetToolTip(this.mlNotifications, "  Notificaciones - En caso de tener, Visualiza, edita y elimina las notificaciones.  ");

                mttHelp.SetToolTip(this.mgAlumnosList, "  Lista de los Alumnos que estan en turno.  ");
                //mttHelp.SetToolTip(this.metroAceptar, "  Accede a las opciones administrativas.  ");
                ////mttHelp.SetToolTip(this.metroAceptar, "  Ingresa a las opciones avanzadas de la aplicacion.  ");
                //mttHelp.SetToolTip(this.metroName, "  Ingresa el nombre de usuario.  ");
                //mttHelp.SetToolTip(this.metroPass, "  Ingresa la contraseña.  ");
            }

        }

        private void VerifyDirectories()
        {
            if (!Directory.Exists("C:\\AppBackUp"))
                Directory.CreateDirectory("C:\\AppBackUp");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\SettingsFiles"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\SettingsFiles");

            string PathSettingsFile = Environment.CurrentDirectory + "\\SettingsFiles\\Settings.txt";
            string PathNotifFile = Environment.CurrentDirectory + "\\SettingsFiles\\Notifications.txt";

            if (!File.Exists(PathNotifFile))
            {
                File.Create(PathNotifFile).Dispose();
            }

            if (!File.Exists(PathSettingsFile))
            {
                File.Create(PathSettingsFile).Dispose();
                using (TextWriter tw = new StreamWriter(PathSettingsFile))
                {
                    tw.WriteLine("NE");
                    tw.WriteLine("AE");
                    tw.WriteLine("CE");
                    tw.WriteLine("A");
                    tw.WriteLine("L");
                    tw.WriteLine("HELPE");
                    tw.WriteLine("S-1");
                    tw.WriteLine("20:45");
                    tw.Close();
                }
            }
        }

        private bool VerifyIfDBExist(string str, string DB)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; Integrated Security=SSPI");
            con.Open();
            cmd = new SqlCommand("select * from sysdatabases", con);
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
            
            if (!exist)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "No se ha detectado la base de datos, Preparando la aplicacion para crear la base de datos"
                    , "ADVERTENCIA - BASE DE DATOS INEXISTENTE.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (Manager Mngr = new Manager(true, DB, "C:\\AppBackUp", Opciones))
                    {
                        DialogResult Result = Mngr.ShowDialog();
                        if (Result == DialogResult.Cancel)
                        {
                            //
                        }
                    }
                }

                return VerifyIfDBExist("(local)", DB);
            }
            else
            {
                return true;
            }

        }

        private bool TablesExist(string str)
        {
            con = new SqlConnection("Data Source=" + str + ";Database=Master;data source=.; Integrated Security=SSPI");
            con.Open();
            cmd = new SqlCommand("SELECT TABLE_NAME FROM [FCFM Registro Horas].INFORMATION_SCHEMA.Tables ", con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "No se han detectado las tablas para almacenar datos en la base de datos" + 
                    ", Preparando la aplicacion para crear las tablas necesarias"
                    , "ADVERTENCIA - TABLAS INEXISTENTES.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (Manager Mngr = new Manager(true, "FCFM Registro Horas", "C:\\AppBackUp", Opciones))
                    {
                        DialogResult Result = Mngr.ShowDialog();
                        if (Result == DialogResult.Cancel)
                        {
                            //
                        }
                    }
                }
                return TablesExist("(local)");
            }
            
        }

        public List<Horario> GetHorarios(int matricula, string day)
        {
            return DM.GetHorariosByMatriculaDayAndHour(matricula, day, Opciones.HoraCorte);
        }

        public void SaveNotificacion(List<StudentData> NotifList, string FileName)
        {
            try
            {
                string PathSettingsFile = Environment.CurrentDirectory + "\\SettingsFiles\\" + FileName;
                StreamWriter sw = new StreamWriter(PathSettingsFile);

                foreach (var Set in NotifList)
                {
                    //Write a line of text
                    Student stud = DM.GetStudentByMatricula(Set.Registros.Matricula);
                    string Name = stud.Nombre + " " + stud.Second_Name + " " + stud.Second_Name2;
                    string Data = Set.Registros.Matricula.ToString() + "," + Set.Registros.Hora_Entrada + ","
                        + Set.Registros.Hora_Salida + "," + Set.Registros.Fecha_Entrada.ToString("yyyy-MM-d");
                    sw.WriteLine(Name + "," + Data);
                }
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Guardar Configuracion, Error: " + e.Message);
            }
        }

        public void ReadNotidications(string FileName)
        {
            try
            {
                //String[] line;
                List<string> line = new List<string>();
                //Pass the file path and file name to the StreamReader constructor\
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

                if (line[0] != null)
                {
                    foreach (var item in line)
                    {
                        Data = item.Split(",".ToCharArray());
                        StudentData Temp = new StudentData();
                        Temp.Registros = new Registro();
                        Temp.Name = Data[0];
                        Temp.Registros.Matricula = int.Parse(Data[1].ToString());
                        Temp.Registros.Hora_Entrada = Data[2];
                        Temp.Registros.Hora_Salida = Data[3];
                        Temp.Registros.Fecha_Entrada = Convert.ToDateTime(Data[4]);
                        Notifications.Add(Temp);
                    }
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al Leer las Configuraciones, Error: " + e.Message);
            }
        }

        public bool CorteAlumnos()
        {
            try
            {
                foreach (var item in DM.GetUncheckedOutRegistro())
                {
                    StudentData TempSD = new StudentData();
                    TempSD.Registros = item;
                    TempSD.Horario = GetHorarios(item.Matricula, DM.GetCurrentDay());
                    Alumnos.Add(TempSD);
                }

                if (Alumnos.Count <= 0)
                {
                    return false;
                }

                int i = 0;
                foreach (var item in Alumnos)
                {
                    //convertir hora de entrada a este metodo para saber en que hora entro y que hora de salida ponerle
                    int In = DM.TotalTimeToInt(item.Registros.Hora_Entrada);

                    foreach (var horas in item.Horario)
                    {
                        int HorarioIn = DM.TotalTimeToInt(item.Horario[i].Entrada);
                        int HorarioOut = DM.TotalTimeToInt(item.Horario[i].Salida);
                        if ((In >= HorarioIn || In <= HorarioIn) && In <= HorarioOut)
                        {
                            item.Registros.Hora_Salida = item.Horario[i].Salida;
                            item.Registros.Fecha_Salida = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d"));
                            item.Registros.Tipo_Registro = "S";
                            DM.UpdateRegistro(item.Registros);
                            break;
                        }
                        i++;
                    }
                    i = 0;
                }
                SaveNotificacion(Alumnos, "Notifications.txt");
                ReadNotidications("Notifications.txt");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mlTime.Text = DM.GetHour(DateTime.Now.Hour, DateTime.Now.Minute);
            int NowHour = Convert.ToInt32(DateTime.Now.Hour);
            int NowMinute = Convert.ToInt32(DateTime.Now.Minute);
            int CorteHour = 0;
            int CorteMinute = 0;
            if (Opciones.AutoCorte && Opciones.HoraCorte != null)
            {
                CorteHour = DM.TotalTimeToInt(Opciones.HoraCorte);
                CorteMinute = DM.TotalMinutesToInt(Opciones.HoraCorte);
            }
            
            MetroCut.Enabled = !Opciones.AutoCorte;
            mlNotifications.Enabled = Opciones.Notificaciones;

            if (((NowHour == (CorteHour - 1)) && (NowMinute == CorteMinute)) && Opciones.AutoCorte && Exit)
            {
                Exit = !CorteAlumnos();

                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El corte automatio se ha realizado con exito."
                    , "CORTE EXITOSO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (Result == DialogResult.OK)
                {
                    SetStudents();
                }
                
            }
        }

        private void Corte_Click(object sender, EventArgs e)
        {
            if (CorteAlumnos())
            {
                MessageBox.Show("Corte de Alumnos Exitoso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetStudents();
            }
            else
            { 
                MessageBox.Show("No hay Alumnos para realizar corte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                SetStudents();
            }
        }

        private void AlumnosList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = mgAlumnosList.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    mgAlumnosList.ClearSelection();
                    mgAlumnosList.Rows[currentMouseOverRow].Selected = true;
                    mcMenu.Show(mgAlumnosList, new Point(e.X, e.Y));
                }
            } 
        }

        private void CheckOut(DateTime CheckOut_Date, string CheckOut_Time, string Matricula)
        {
            Registro TempReg = new Registro();
            TempReg.Matricula = int.Parse(Matricula);
            TempReg.Hora_Salida = CheckOut_Time;
            TempReg.Fecha_Salida = CheckOut_Date;
            TempReg.Tipo_Registro = "S";
            DM.UpdateRegistro(TempReg);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            
            switch (item.Text)
            {
                case "Horario del Alumno":
                    using (HorarioAlumno Horario = new HorarioAlumno(mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString(), Opciones))
                    {
                        DialogResult Result = Horario.ShowDialog();
                        if (Result == DialogResult.Cancel)
                        {

                        }
                    }
                break;

                case "Datos del Alumno":
                    _Data = new pnlData(this, Opciones, mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString(), DBName);
                    _Data.swipe(true);
                break;

                case "Reporte del Alumno":
                using (RptHoras ReporteHoras = new RptHoras(mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString(), Opciones))
                {
                    DialogResult Result = ReporteHoras.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;

                case "Horas Mensuales":
                using (RptHorasTotales HorasMensuales = new RptHorasTotales(mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString(), Opciones))
                {
                    DialogResult Result = HorasMensuales.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;

                case "Control de Horas":
                using (LogIn CtrlHoras = new LogIn(DBName, Opciones, true,  mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString()))
                {
                    DialogResult Result = CtrlHoras.ShowDialog();
                    if (Result == DialogResult.Cancel)
                    {

                    }
                }
                break;

                case "Salida":
                    int matricula = int.Parse(mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString());
                    if (!DM.StudentExistByMatricula(matricula))
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El alumno es inexistente, verifique la integridad de los datos con el administrador de la base de datos."
                        , "ADVERTENCIA - DATOS INCORRECTOS.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (Result == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        CheckOut(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d")), DM.GetHour(DateTime.Now.Hour, DateTime.Now.Minute), matricula.ToString());
                        SetStudents();
                    }
                break;

                case "Salida Manual":
                _CheckInOut = new pnlCheckInOut(this, Opciones, this, mgAlumnosList.Rows[mgAlumnosList.SelectedRows[0].Index].Cells[1].Value.ToString(), true);
                _CheckInOut.swipe(true);
                break;

                default:
                    break;
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            //LogIn Login = new LogIn();
            //Login.Show();
            using (LogIn Login = new LogIn(DBName, Opciones))
            {
                DialogResult Result = Login.ShowDialog();
                if (Result == DialogResult.Cancel)
                {
                    //Opciones = stngs.Temp;
                }
            }
        }

        private void MetroCut_Click(object sender, EventArgs e)
        {
            if (CorteAlumnos())
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Corte de alumnos exitoso."
                        , "CORTE EXITOSO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (Result == DialogResult.OK)
                {
                    SetStudents();
                }
            }
            else
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "No hay Alumnos para realizar corte."
                        , "ADVERTENCIA.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (Result == DialogResult.OK)
                {
                    SetStudents();
                }
            }
        }

        private void MetroRpts_Click(object sender, EventArgs e)
        {
            RptHoras f5 = new RptHoras(Opciones);
            f5.Show();
        }

        private void MetroStudentsRpts_Click(object sender, EventArgs e)
        {
            RptAlumnos f6 = new RptAlumnos(Opciones);
            f6.Show();
        }

        private void MetroTotalHrs_Click(object sender, EventArgs e)
        {
            RptHorasTotales f8 = new RptHorasTotales(Opciones);
            f8.Show();
        }

        private void lnkNotifications_Click(object sender, EventArgs e)
        {
            _Notifications = new pnlNotifications(Notifications, this, Opciones);
            ////_Settings.Closed += _pnlone_Closed;
            ////_Settings.Shown += _pnlone_Shown;
            _Notifications.Closed += _Notifications_Closed;
            _Notifications.swipe(true);

            //Opciones = _Settings.Temp;
        }

        private void mlCheckInOuts_Click(object sender, EventArgs e)
        {
            _CheckInOut = new pnlCheckInOut(this, Opciones, this);
            ////_Settings.Closed += _pnlone_Closed;
            ////_Settings.Shown += _pnlone_Shown;
            //_CheckInOut.Closed += _Notifications_Closed;
            _CheckInOut.swipe(true);

            //Opciones = _Settings.Temp;
        }

        private void mlData_Click(object sender, EventArgs e)
        {
            _Data = new pnlData(this, Opciones, DBName);
            ////_Settings.Closed += _pnlone_Closed;
            ////_Settings.Shown += _pnlone_Shown;
            _Data.swipe(true);
        }

        void _Notifications_Closed(object sender, EventArgs e)
        {
            if (Notifications.Count <= 0)
            {
                mlNotifications.Image = Properties.Resources.Notifications2NotFocus;
                mlNotifications.NoFocusImage = Properties.Resources.Notifications2;
                mlNotifications.Refresh();
                Notifications = _Notifications.Notifiy;
                SaveNotificacion(Notifications, "Notifications.txt");
            }
            else
            {
                mlNotifications.Image = Properties.Resources.NotificationsYellow;
                mlNotifications.NoFocusImage = Properties.Resources.NotificationsYellowNotFocus;
                mlNotifications.Refresh();
                Notifications = _Notifications.Notifiy;
                SaveNotificacion(Notifications, "Notifications.txt");
            }
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            _Settings = new pnlSettings(this, DBName);
            _Settings.swipe(true);
        }

        private void MetroSettings_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            if (Notifications.Count > 0)
            {
                DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Tiene notificaciones pendientes en el sistema. "
                + "presione 'OK' para abrir el panel de notificaciones y editarlas, puede continuar con la edicion de notificaciones "
                + "mas tarde dando click al boton de advertencia", "ADVERTENCIA - NOTIFICACIONES PENDIENTES.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (Result == DialogResult.OK)
                {
                    _Notifications = new pnlNotifications(Notifications, this, Opciones);
                    _Notifications.Closed +=_Notifications_Closed;
                    _Notifications.swipe(true);
                }
            }

            if ((Opciones.AutoCorte && Opciones.HoraCorte == null))
            {
                MetroFramework.MetroMessageBox.Show(this, "No se ah podido leer la hora de corte automatica y la opcion esta activada. "
                + "Entre a opciones, valla a la pestaña 'Control de Horas', ingrese una hora valida y de click al boton guardar", "ADVERTENCIA - HA OCURRIDO UN ERROR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
