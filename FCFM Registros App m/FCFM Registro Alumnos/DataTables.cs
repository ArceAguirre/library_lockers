using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq.Expressions;
using System.Collections;
using System.Globalization;
using FCFM_Registro_Alumnos;



namespace DataTables{
    public class Connection_heritage : Connection{}
    
    #region SQL_Tables
    [Table(Name = "alumnos")]
    public class Student
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        [Column(Name = "matricula",IsPrimaryKey = true)]
        public int Matricula;
        [Column(Name = "nombre")]
        public String Nombre;
        [Column(Name = "ap_paterno")]
        public String Second_Name;
        [Column(Name = "ap_materno")]
        public String Second_Name2;
        [Column(Name = "carrera")]
        public String Carrera;
        [Column(Name = "semestre")]
        public int Semestre;
        [Column(Name = "tipo_servicio")]
        public String T_Servicio;
        [Column(Name = "periodo")]
        public String Periodo;
    }

    [Table(Name = "horario")]
    public class Horario
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "IdHorario")]
        public int IdHorario;
        [Column(Name = "Matricula")]
        public int Matricula;
        [Column(Name = "Entrada")]
        public String Entrada;
        [Column(Name = "Salida")]
        public String Salida;
        [Column(Name = "Dia")]
        public String Dia;
    }

    [Table(Name = "Registros")]
    public class Registro
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "IdRegistros")]
        public int IdRegistros;
        [Column(Name = "Matricula")]
        public int Matricula;
        [Column(Name = "Hora_E")]
        public String Hora_Entrada;
        [Column(Name = "Hora_S")]
        public String Hora_Salida;
        [Column(Name = "Fecha_E")]
        public DateTime Fecha_Entrada;
        [Column(Name = "Fecha_S")]
        public DateTime Fecha_Salida;
        [Column(Name = "Tipo_Reg")]
        public String Tipo_Registro;
    }

    [Table(Name = "LoginUsers")]
    public class Login
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "idUser")]
        public int IdUsuarios;
        [Column(Name = "UserName")]
        public String NombreUsuario;
        [Column(Name = "UserPassword")]
        public String PasswordUsuario;
    }
    #endregion

    #region DataContext_Table
    public partial class TableContext : DataContext
    {
        public Table<Student> Students;
        public Table<Horario> Horarios;
        public Table<Registro> Registros;
        public Table<Login> InicioSesion;
        public TableContext(string connection) : base(connection) { }
    }
    #endregion

   #region Data Managment Class
    public class DataManagment : TableContext{
        public static string ConnectionString = Connection_heritage.CONNECTION_STRING;

        //public static string ConnectionString = "Database=FCFM Registro Horas;Server=(local);Integrated Security=SSPI";
        public DataManagment(string connection) : base(connection) { }

        #region Insert Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void InsertStudent(Student StudentData)
        {
            try
            {
                using (TableContext ST = new TableContext(ConnectionString))
                {
                    Student Stdnt = new Student();
                    Stdnt.Matricula = StudentData.Matricula;
                    Stdnt.Nombre = StudentData.Nombre;
                    Stdnt.Second_Name = StudentData.Second_Name;
                    Stdnt.Second_Name2 = StudentData.Second_Name2;
                    Stdnt.T_Servicio = StudentData.T_Servicio;
                    Stdnt.Semestre = StudentData.Semestre;
                    Stdnt.Periodo = StudentData.Periodo;
                    Stdnt.Carrera = StudentData.Carrera;
                    ST.Students.InsertOnSubmit(Stdnt);
                    ST.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void InsertHorario(Horario HorarioData)
        {
            try
            {
                using (TableContext HT = new TableContext(ConnectionString))
                {
                    Horario horario = new Horario();
                    horario.Matricula = HorarioData.Matricula;
                    horario.Dia = HorarioData.Dia;
                    horario.Entrada = HorarioData.Entrada;
                    horario.Salida = HorarioData.Salida;
                    HT.Horarios.InsertOnSubmit(horario);
                    HT.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void InsertRegistro(Registro RegData)
        {
            try
            {
                using (TableContext RT = new TableContext(ConnectionString))
                {
                    Registro hora = new Registro();
                    hora.Matricula = RegData.Matricula;
                    hora.Hora_Entrada = RegData.Hora_Entrada;
                    hora.Hora_Salida = RegData.Hora_Salida;
                    hora.Fecha_Entrada = RegData.Fecha_Entrada;
                    hora.Fecha_Salida = RegData.Fecha_Salida;
                    hora.Tipo_Registro = RegData.Tipo_Registro;
                    RT.Registros.InsertOnSubmit(hora);
                    RT.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pass"></param>
        public void InsertUser(string Name, string Pass)
        {
            try
            {
                using (TableContext ST = new TableContext(ConnectionString))
                {
                    Login sesion = new Login();
                    sesion.NombreUsuario = Name;
                    sesion.PasswordUsuario = Pass;
                    ST.InicioSesion.InsertOnSubmit(sesion);
                    ST.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                while (ex2.InnerException != null)
                {
                    ex2 = ex2.InnerException;
                }
                throw;
            }
        }
        
        #endregion

        #region Update Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void UpdateStudent(Student StudentData)
        {
            using (TableContext ST = new TableContext(ConnectionString))
            {
                var student = (from Row in ST.Students where Row.Matricula == StudentData.Matricula select Row).FirstOrDefault();
                student.Matricula = StudentData.Matricula;
                student.Nombre = StudentData.Nombre;
                student.Second_Name = StudentData.Second_Name;
                student.Second_Name2 = StudentData.Second_Name2;
                student.Carrera = StudentData.Carrera;
                student.Semestre = StudentData.Semestre;
                student.T_Servicio = StudentData.T_Servicio;
                student.Periodo = StudentData.Periodo;
                ST.SubmitChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void UpdateHorario(Horario HorarioData)
        {
            using (TableContext HT = new TableContext(ConnectionString))
            {
                var horario = (from Row in HT.Horarios where Row.Matricula == HorarioData.Matricula select Row).FirstOrDefault();
                horario.Matricula = HorarioData.Matricula;
                HT.SubmitChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void UpdateRegistro(Registro RegData)
        {
            using (TableContext RT = new TableContext(ConnectionString))
            {
                var horario = (from Row in RT.Registros
                               where Row.Matricula == RegData.Matricula & Row.Hora_Salida == "00:00" & Row.Tipo_Registro == "E"
                               select Row).FirstOrDefault();
                if (horario != null)
                {
                    horario.Hora_Salida = RegData.Hora_Salida;
                    horario.Fecha_Salida = RegData.Fecha_Salida;
                    horario.Tipo_Registro = RegData.Tipo_Registro;
                    RT.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RegData"></param>
        public void UpdateFromNotification(Registro RegData)
        {
            using (TableContext RT = new TableContext(ConnectionString))
            {
                var horario = (from Row in RT.Registros where Row.Matricula == RegData.Matricula select Row).AsEnumerable().LastOrDefault();

                if (horario != null)
                {
                    horario.Hora_Salida = RegData.Hora_Salida;
                    horario.Fecha_Salida = RegData.Fecha_Salida;
                    horario.Tipo_Registro = RegData.Tipo_Registro;
                    RT.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RegData"></param>
        public void UpdateRegistroFromControl(Registro RegData, Registro NewData)
        {
            using (TableContext RT = new TableContext(ConnectionString))
            {
                var horario = (from Row in RT.Registros where Row.Matricula == RegData.Matricula 
                               & Row.Fecha_Entrada == RegData.Fecha_Entrada
                               & Row.Fecha_Salida == RegData.Fecha_Salida
                               & Row.Hora_Entrada == RegData.Hora_Entrada
                               & Row.Hora_Salida == RegData.Hora_Salida
                               select Row).FirstOrDefault();

                if (horario != null)
                {
                    horario.Hora_Entrada = NewData.Hora_Entrada;
                    horario.Hora_Salida = NewData.Hora_Salida;
                    horario.Fecha_Entrada = NewData.Fecha_Entrada;
                    horario.Fecha_Salida = NewData.Fecha_Salida;
                    RT.SubmitChanges();
                }
            }
        }

        #endregion

        #region Delete Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StudentData"></param>
        public void DeleteStudent(Student StudentData)
        {
            using (TableContext ST = new TableContext(ConnectionString))
            {
                var student = (from Row in ST.Students where Row.Matricula == StudentData.Matricula select Row).FirstOrDefault();

                if (student != null)
                {
                    ST.Students.DeleteOnSubmit(student);
                    ST.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HorarioData"></param>
        public void DeleteHorario(Horario HorarioData)
        {
            using (TableContext HT = new TableContext(ConnectionString))
            {
                var student = (from Row in HT.Horarios
                               where Row.Matricula == HorarioData.Matricula
                               & Row.Dia == HorarioData.Dia
                               & Row.Entrada == HorarioData.Entrada
                               & Row.Salida == HorarioData.Salida
                               select Row).FirstOrDefault();

                if (student != null)
                {
                    HT.Horarios.DeleteOnSubmit(student);
                    HT.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HorarioData"></param>
        public void DeleteRegistro(Registro HorarioData)
        {
            using (TableContext HT = new TableContext(ConnectionString))
            {
                var student = (from Row in HT.Registros
                               where Row.Matricula == HorarioData.Matricula
                                   //& Row.Dia == HorarioData.Dia
                               & Row.Fecha_Entrada == HorarioData.Fecha_Entrada
                               & Row.Fecha_Salida == HorarioData.Fecha_Salida
                               & Row.Hora_Entrada == HorarioData.Hora_Entrada
                               & Row.Hora_Salida == HorarioData.Hora_Salida
                               select Row).FirstOrDefault();

                if (student != null)
                {
                    HT.Registros.DeleteOnSubmit(student);
                    HT.SubmitChanges();
                }
            }
        }

        #endregion

        #region GetBy Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public Student GetStudentByMatricula(int Matricula)
        {
            Table<Student> Stdnt = GetTable<Student>();
            var student = (from Row in Stdnt where Row.Matricula == Matricula select Row).FirstOrDefault();
            return student;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public Horario GetLastHorarioAddedByMatricula(int Matricula)
        {
            Table<Horario> schedules = GetTable<Horario>();
            var horario = (from Row in schedules where Row.Matricula == Matricula select Row).AsEnumerable().LastOrDefault();
            return horario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public Registro GetLastRegistroAddedByMatricula(int Matricula)
        {
            Table<Registro> schedules = GetTable<Registro>();
            var horario = (from Row in schedules where Row.Matricula == Matricula select Row).AsEnumerable().LastOrDefault();
            return horario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <param name="Day"></param>
        /// <returns></returns>
        public Registro GetRegistrosByMatriculaAndDay(int Matricula, string Day)
        {
            Table<Registro> schedules = GetTable<Registro>();
            var horarios = (from Row in schedules
                            where Row.Matricula == Matricula
                            select Row).FirstOrDefault();
            return horarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public Login GetUserByPasswordAndName(string Password, string Name)
        {
            Table<Login> Users = GetTable<Login>();
            var user = (from Row in Users
                        where Row.NombreUsuario == Name
                        & Row.PasswordUsuario == Password
                            select Row).FirstOrDefault();
            return user;
        }

        public Login GetUserByName(string Name)
        {
            Table<Login> Users = GetTable<Login>();
            var user = (from Row in Users
                        where Row.NombreUsuario == Name
                        select Row).FirstOrDefault();
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <param name="Day"></param>
        /// <param name="Hour"></param>
        /// <returns></returns>
        public List<Horario> GetHorariosByMatriculaDayAndHour(int Matricula, string Day, string Hour)
        {
            Table<Horario> schedules = GetTable<Horario>();

            var horarios = (from Row in schedules
                            where Row.Matricula == Matricula
                            & Row.Dia == Day
                            select Row).ToList();
            return horarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<Student> GetAllStudents()
        {
            Table<Student> students = GetTable<Student>();
            var Students = (from Row in students select Row);
            return Students;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<Registro> GetUncheckedOutRegistro()
        {
            Table<Registro> schedules = GetTable<Registro>();
            var horarios = (from Row in schedules
                            where Row.Hora_Salida == "00:00"
                            & Row.Fecha_Entrada == Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-d"))
                            select Row);
            return horarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public IQueryable<Horario> GetHorariosByMatricula(int Matricula)
        {
            Table<Horario> schedules = GetTable<Horario>();
            var horarios = (from Row in schedules where Row.Matricula == Matricula select Row);
            return horarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public IQueryable<Registro> GetRegistrosByMatricula(int Matricula)
        {
            Table<Registro> schedules = GetTable<Registro>();
            var horarios = (from Row in schedules where Row.Matricula == Matricula select Row);
            return horarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <param name="Day"></param>
        /// <returns></returns>
        public IQueryable<Horario> GetHorariosByMatriculaAndDay(int Matricula, string Day)
        {
            Table<Horario> schedules = GetTable<Horario>();
            var horarios = (from Row in schedules
                            where Row.Matricula == Matricula & Row.Dia == Day
                            select Row);
            return horarios;
        }

        #endregion

        #region Misc Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public bool IsNewReg(int Matricula)
        {
            Table<Registro> Registro = GetTable<Registro>();
            var Locker = (from Row in Registro where Row.Matricula == Matricula & Row.Hora_Salida == "00:00" & Row.Tipo_Registro == "E" select Row).FirstOrDefault();

            if (Locker != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hour"></param>
        /// <param name="Minute"></param>
        /// <returns></returns>
        public string GetHour(int Hour, int Minute)
        {
            string h = Hour.ToString();
            string m = Minute.ToString();

            if (h.Length <= 1)
                h = "0" + h;
            if (m.Length <= 1)
                m = "0" + m;

            return h + ":" + m;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDay()
        {
            CultureInfo Spanish = new CultureInfo("es-Es");
            return Spanish.DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        public int TotalTimeToInt(string hour)
        {
            DateTime time = DateTime.Parse(hour, CultureInfo.InvariantCulture);
            int OutST = Convert.ToInt32(time.TimeOfDay.TotalHours);
            return OutST;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        public int TotalMinutesToInt(string hour)
        {
            DateTime time = DateTime.Parse(hour, CultureInfo.InvariantCulture);
            int OutST = Convert.ToInt32(time.TimeOfDay.Minutes);
            return OutST;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Matricula"></param>
        /// <returns></returns>
        public bool StudentExistByMatricula(int Matricula)
        {
            Table<Student> Stdnt = GetTable<Student>();
            var student = (from Row in Stdnt where Row.Matricula == Matricula select Row).FirstOrDefault();

            if (student != null)
                return true;
            else
                return false;
        }

        public bool UserExistByNameAndPassword(string Name, string Password)
        {
            Table<Login> Users = GetTable<Login>();
            var user = (from Row in Users
                        where Row.NombreUsuario == Name
                        & Row.PasswordUsuario == Password
                        select Row).FirstOrDefault();

            if (user != null)
                return true;
            else
                return false;
        }

        public bool UserExistByName(string Name)
        {
            Table<Login> Users = GetTable<Login>();
            var user = (from Row in Users
                        where Row.NombreUsuario == Name
                        select Row).FirstOrDefault();

            if (user != null)
                return true;
            else
                return false;
        } 

        #endregion

    }
    #endregion 

    #region Data Managment types

    public struct SettingsData 
    {
        public bool AutoCorte;
        public bool VerActividad;
        public bool Notificaciones;
        public bool Vacaciones;
        public bool DiaFestivo;
        public bool Escaner;
        public bool Automatico;
        public bool Manual;
        public bool DarkTheme;
        public bool LighTheme;
        public bool Ayuda;
        public string HoraCorte;
        public string Estilo;
    }

    public struct StudentData
    {
        public string Name;
        public Student Alumno;
        public Registro Registros;
        public List<Horario> Horario;
    }

    #endregion
}
