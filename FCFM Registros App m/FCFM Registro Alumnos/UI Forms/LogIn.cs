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

namespace FCFM_Registro_Alumnos.UI_Forms
{
    public partial class LogIn : MetroForm
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        Encrypting encript = new Encrypting();
        string DBName;
        private bool TimeControl;
        private string Matricula;

        public LogIn(string _DBName, SettingsData _Opciones)
        {
            InitializeComponent();
            this.StyleManager = msManager;
            Opciones = _Opciones;
            DBName = _DBName;
        }

        //public LogIn(string _DBName, SettingsData _Opciones)
        //{
        //    InitializeComponent();
        //    this.StyleManager = msManager;
        //    Opciones = _Opciones;
        //    DBName = _DBName;
        //}

        public LogIn(string _DBName, SettingsData _Opciones, bool _TimeControl, string _Matricula)
        {
            InitializeComponent();
            this.StyleManager = msManager;
            Opciones = _Opciones;
            DBName = _DBName;
            TimeControl = _TimeControl;
            Matricula = _Matricula;
        }

        private void metroCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroAceptar_Click(object sender, EventArgs e){
        //    if (string.IsNullOrEmpty(metroName.Text) | string.IsNullOrEmpty(metroPass.Text))
        //    {
        //        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Debe de ingresar Nombre y Contraseña para continuar. "
        //                , "ADVERTENCIA - USUARIO O CLAVE INCORRECTA.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        if (Result == DialogResult.OK)
        //        {
        //            return;
        //        }
        //    }
        //    else
        //    {
                if (!DM.UserExistByName(metroName.Text))
                {
                    DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El usuario no existe o ah ingresado datos invalidos. "
                    + "ingrese un usuario valido o existente", "ERROR - USUARIO INEXISTEMTE.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (Result == DialogResult.OK)
                    {
                        metroName.Text = "";
                        metroPass.Text = "";
                        return;
                    }
                }
                else
                {
                    Login user = DM.GetUserByName(metroName.Text);
                    if (!encript.VerifyHash(metroPass.Text, "SHA512", user.PasswordUsuario))
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El usuario o clave es incorrecta. "
                        + "ingrese un usuario o clave valida o existente", "ERROR - USUARIO O CLAVE INCORRECTA.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (Result == DialogResult.OK)
                        {
                            metroName.Text = "";
                            metroPass.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Ha ingresado exitosamente. "
                        , "BIENVENIDO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        if (TimeControl)
                        {
                            ControlHoras CtrlHoras = new ControlHoras(Matricula, Opciones);
                            CtrlHoras.Show();
                            this.Close();
                        }
                        else
                        {
                            if (Result == DialogResult.OK)
                            {
                                Manager Mngr = new Manager(DBName, "C:\\AppBackUp", Opciones);
                                Mngr.Show();
                                this.Close();
                            }
                        }
                    }

          //      }
                
            }
        }

        private void metroPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(metroName.Text) | string.IsNullOrEmpty(metroPass.Text))
                {
                    DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Debe de ingresar Nombre y Contraseña para continuar. "
                        , "ADVERTENCIA - USUARIO O CLAVE INCORRECTA.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (Result == DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    if (!DM.UserExistByName(metroName.Text))
                    {
                        DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El usuario no existe o ah ingresado datos invalidos. "
                        + "ingrese un usuario valido o existente", "ERROR - USUARIO INEXISTEMTE.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (Result == DialogResult.OK)
                        {
                            metroName.Text = "";
                            metroPass.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        Login user = DM.GetUserByName(metroName.Text);
                        if (!encript.VerifyHash(metroPass.Text, "SHA512", user.PasswordUsuario))
                        {
                            DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "El usuario o clave es incorrecta. "
                            + "ingrese un usuario o clave valida o existente", "ERROR - USUARIO O CLAVE INCORRECTA.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            if (Result == DialogResult.OK)
                            {
                                metroName.Text = "";
                                metroPass.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            DialogResult Result = MetroFramework.MetroMessageBox.Show(this, "Ha ingresado exitosamente. "
                            , "BIENVENIDO.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            if (TimeControl)
                            {
                                ControlHoras CtrlHoras = new ControlHoras(Matricula, Opciones);
                                CtrlHoras.Show();
                                this.Close();
                            }
                            else
                            {
                                if (Result == DialogResult.OK)
                                {
                                    Manager Mngr = new Manager(DBName, "C:\\AppBackUp", Opciones);
                                    Mngr.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void metroCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (Opciones.Ayuda)
            {
                mttHelp.SetToolTip(this.metroCancelar, "  Cancela y regresa a la pantalla de Opciones.  ");
                mttHelp.SetToolTip(this.metroAceptar, "  Accede a las opciones administrativas.  ");
                //mttHelp.SetToolTip(this.metroAceptar, "  Ingresa a las opciones avanzadas de la aplicacion.  ");
                mttHelp.SetToolTip(this.metroName, "  Ingresa el nombre de usuario.  ");
                mttHelp.SetToolTip(this.metroPass, "  Ingresa la contraseña.  ");
            }

            if (Opciones.DarkTheme)
                msManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                msManager.Theme = MetroFramework.MetroThemeStyle.Light;

            string[] s;
            s = Opciones.Estilo.Split('-');
            msManager.Style = (MetroColorStyle)Convert.ToInt32(s[1]);
        }
    }
}
