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

namespace FCFM_Registro_Alumnos.UI_Forms
{
    public partial class Notificaciones : Form
    {
        public List<StudentData> Notifiy = new List<StudentData>();
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public Notificaciones()
        {
            InitializeComponent();
        }

        public Notificaciones(List<StudentData> Notifications)
        {
            InitializeComponent();
            Notifiy = Notifications;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //buscar registro
            Registro TempReg = new Registro();
            TempReg = DM.GetLastRegistroAddedByMatricula(int.Parse(NotificationsList.GetSubItemsFromSelectedIndex(1)));
            //modificarlo
            TempReg.Hora_Salida = Hora_S.Text;
            //guardar
            DM.UpdateFromNotification(TempReg);
            //eliminarlo de la lista
            DeleteSelectedIndex(false, NotificationsList.SelectedIndices);
            NotificationsList.DeleteSelectedIndex(false);
        }

        private void EliminaHorario_Click(object sender, EventArgs e)
        {
            DeleteSelectedIndex(true, NotificationsList.SelectedIndices);
            NotificationsList.DeleteSelectedIndex(true);
        }

        private void DeleteSelectedIndex(bool All, ListView.SelectedIndexCollection Selection)
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
                    if (((StudentData)Notifiy[Selection[0]]).Registros.Matricula.CompareTo(int.Parse(NotificationsList.GetSubItemsFromSelectedIndex(1))) != 1)
                    {
                        Notifiy.RemoveAt(Selection[0]);
                    }
                }
                else
                {
                    for (int i = Selection.Count - 1; i >= 0; i--)
                        Notifiy.RemoveAt(Selection[i]);
                }
                
            }
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection v = NotificationsList.SelectedItems;
            DeleteSelectedIndex(false, NotificationsList.SelectedIndices);
            NotificationsList.DeleteSelectedIndex(false);
        }

        private void LoadNotifications(List<StudentData> Notifications)
        {
            foreach (var notif in Notifications)
            {
                NotificationsList.SetItemSubItems(notif.Name, notif.Registros.Matricula.ToString());
                NotificationsList.SetItemSubItems(notif.Name, notif.Registros.Hora_Entrada);
                NotificationsList.SetItemSubItems(notif.Name, notif.Registros.Hora_Salida);
            }
        }

        private void NotificationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotificationsList.FocusedItem == null)
            {
                NotificationsList.FocusedItem = (ListViewItem)NotificationsList.Items[NotificationsList.Items.Count - 1];
            }

            if (NotificationsList.FocusedItem.Focused)
            {
                if (NotificationsList.SelectedIndices.Count <= 1)
                {
                    Editar.Enabled = true;
                    EliminaTodos.Enabled = false;
                    EliminaTodos.Text = "Eliminar Todos";
                    EliminarNotificacion.Enabled = true;
                    Hora_S.Enabled = true;
                }
                else
                {
                    Editar.Enabled = false;
                    EliminaTodos.Enabled = true;
                    EliminaTodos.Text = "Eliminar Seleccion";
                    EliminarNotificacion.Enabled = false;
                    Hora_S.Enabled = true;
                }
                
            }
            else
            {
                Editar.Enabled = false;
                EliminaTodos.Enabled = true;
                EliminarNotificacion.Enabled = false;
                Hora_S.Enabled = false;
            }
        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {
            NotificationsList.View = View.Details;
            LoadNotifications(Notifiy);
        }
    }
}
