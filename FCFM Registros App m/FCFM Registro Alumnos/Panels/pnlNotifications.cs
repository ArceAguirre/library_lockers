using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroPanelSlide.Panel;
using MetroFramework.Interfaces;
using DataTables;
using System.IO;

namespace MetroPanelSlide.Panel
{
    public partial class pnlNotifications : pnlSlider, IMetroControl
    {

        public List<StudentData> Notifiy = new List<StudentData>();
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();

        public pnlNotifications(Form owner, SettingsData _Opciones)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            this.StyleManager.Update();
        }

        public pnlNotifications(List<StudentData> Notifications, Form owner, SettingsData _Opciones)
            : base(owner)
        {
            InitializeComponent();
            Notifiy = Notifications;
            LoadNotifications(Notifiy);
            Opciones = _Opciones;
            this.StyleManager.Update();
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

        private void mlNotificaciones_Click(object sender, EventArgs e)
        {
            SaveNotificacion(Notifiy, "Notifications.txt");
            this.swipe(false);
            //this.close(true);
        }

        private void LoadNotifications(List<StudentData> Notifications)
        {
            mgNotificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (var notif in Notifications)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(mgNotificaciones);  // this line was missing
                row.Cells[0].Value = notif.Name;
                row.Cells[1].Value = notif.Registros.Matricula.ToString();
                row.Cells[2].Value = notif.Registros.Hora_Entrada;
                row.Cells[3].Value = notif.Registros.Hora_Salida;
                mgNotificaciones.Rows.Add(row);
            }

            if (mgNotificaciones.RowCount <= 0)
            {
                EliminarNotificacion.Enabled = false;
                EliminaTodos.Enabled = false;
                Editar.Enabled = false;
                HoraCorte.Enabled = false;
            }
            else
            {
                EliminarNotificacion.Enabled = true;
                EliminaTodos.Enabled = true;
                Editar.Enabled = true;
                HoraCorte.Enabled = true;
            }

        }

        private void DeleteSelectedIndex(bool All, DataGridViewSelectedRowCollection Selection)
        {
            if (mgNotificaciones.Rows[Selection[0].Index].Cells[1].Value != null || All)
            {
                if (All)
                {
                    for (int i = Notifiy.Count - 1; i >= 0; i--)
                    {
                        Notifiy.RemoveAt(i);
                    }
                }
                else
                {
                    if (Selection.Count <= 1)
                    {
                        string val = mgNotificaciones.Rows[Selection[0].Index].Cells[1].Value.ToString();
                        if (((StudentData)Notifiy[Selection[0].Index]).Registros.Matricula.CompareTo(int.Parse(val)) != 1)
                        {
                            Notifiy.RemoveAt(Selection[0].Index);
                        }
                    }
                    else
                    {
                        if (Selection[0].Index > 0)
                        {
                            for (int i = 0; i < Selection.Count; i++)
                                Notifiy.RemoveAt(Selection[i].Index);
                        }
                        else
                        {
                            for (int i = Selection.Count - 1; i >= 0; i--)
                                Notifiy.RemoveAt(Selection[i].Index);
                        }

                    }

                }
            }

        }

        public void DeleteSelectedIndexFromDataGrid(bool All, DataGridViewSelectedRowCollection Selection)
        {
            if (mgNotificaciones.Rows[Selection[0].Index].Cells[1].Value != null || All)
            {
                if (All)
                {
                    for (int i = mgNotificaciones.Rows.Count - 1; i >= 0; i--)
                    {
                        mgNotificaciones.Rows.RemoveAt(i);
                    }
                }
                else
                {
                    if (Selection.Count <= 1)
                    {
                        for (int i = Selection.Count - 1; i <= 0; i++)
                        {
                            mgNotificaciones.Rows.RemoveAt(Selection[i].Index);
                        }
                    }
                    else
                    {
                        for (int i = Selection.Count - 1; i >= 0; i--)
                            mgNotificaciones.Rows.RemoveAt(Selection[i].Index);

                    }

                }
            }

        }

        private void EliminarNotificacion_Click(object sender, EventArgs e)
        {
            DeleteSelectedIndex(false, mgNotificaciones.SelectedRows);
            DeleteSelectedIndexFromDataGrid(false, mgNotificaciones.SelectedRows);
        }

        private void mgNotificaciones_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (mgNotificaciones.SelectedRows.Count <= 0)
            {
                EliminarNotificacion.Enabled = false;
                EliminaTodos.Enabled = false;
                Editar.Enabled = false;
                HoraCorte.Enabled = false;
            }
            else
            {
                EliminarNotificacion.Enabled = true;
                EliminaTodos.Enabled = true;
                Editar.Enabled = true;
                HoraCorte.Enabled = true;
            }
        }

        private void EliminaTodos_Click(object sender, EventArgs e)
        {
            DeleteSelectedIndex(true, mgNotificaciones.SelectedRows);
            DeleteSelectedIndexFromDataGrid(true, mgNotificaciones.SelectedRows);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //buscar registro
            Registro TempReg = new Registro();
            int matricula = int.Parse(mgNotificaciones.Rows[mgNotificaciones.SelectedRows[0].Index].Cells[1].Value.ToString());
            TempReg = DM.GetLastRegistroAddedByMatricula(matricula);
            //modificarlo
            TempReg.Hora_Salida = HoraCorte.Text;
            //guardar
            DM.UpdateFromNotification(TempReg);
            //eliminarlo de la lista
            DeleteSelectedIndex(false, mgNotificaciones.SelectedRows);
            DeleteSelectedIndexFromDataGrid(false, mgNotificaciones.SelectedRows);
            //DeleteSelectedIndex(false, NotificationsList.SelectedIndices);
            //NotificationsList.DeleteSelectedIndex(false);
        }

        private void pnlNotifications_Load(object sender, EventArgs e)
        {
            if (Opciones.Ayuda)
            {
                mttHelp.SetToolTip(this.EliminarNotificacion, "  Elimina las notificaciones seleccionadas de la lista.  ");
                mttHelp.SetToolTip(this.EliminaTodos, "  Elimina todas las notificaciones de la lista.  ");
                //mttHelp.SetToolTip(this.metroAceptar, "  Ingresa a las opciones avanzadas de la aplicacion.  ");
                mttHelp.SetToolTip(this.Editar, "  Edita la hora de salida de la notificacion seleccionada.  ");
                mttHelp.SetToolTip(this.HoraCorte, "  Ingresa una hora valida para la hora de salida de la notificacion seleccionada.  ");
                mttHelp.SetToolTip(this.mlNotificaciones, "  Regresa a la pantalla anterior sin hacer ningun cambio.  ");
                mttHelp.SetToolTip(this.mgNotificaciones, "  Lista de todas las notificaciones existemtes.  ");
            }
        }
    }
}
