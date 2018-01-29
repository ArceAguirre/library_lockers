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

namespace MetroPanelSlide.Panel
{
    public partial class pnlDataEdition : pnlSlider, IMetroControl
    {
        DataManagment DM = new DataManagment(DataManagment.ConnectionString);
        public SettingsData Opciones = new SettingsData();
        private string Matricula;
        string HE;
        string HS;
        string FE;
        string FS;

        public pnlDataEdition(Form owner, SettingsData _Opciones, string _Matricula)
            : base(owner)
        {
            InitializeComponent();
            Opciones = _Opciones;
            Matricula = _Matricula;
            this.StyleManager.Update();
            SetRegistros(int.Parse(_Matricula));
            //mbEditar.Enabled = false;
            //mbElimina.Enabled = false;
            mpData.Enabled = false;
        }

        private void SetRegistros(int matricula)
        {
            foreach (var Reg in DM.GetRegistrosByMatricula(matricula))
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(mgEntradas);  // this line was missing
                row.Cells[0].Value = Reg.Fecha_Entrada.ToString("yyyy-MM-d");
                row.Cells[1].Value = Reg.Hora_Entrada;
                row.Cells[2].Value = Reg.Fecha_Salida.ToString("yyyy-MM-d");

                if (Reg.Hora_Salida != "00:00")
                    row.Cells[3].Value = Reg.Hora_Salida;
                else
                    row.Cells[3].Value = "EN TURNO";

                row.Cells[4].Value = Reg.Tipo_Registro;

                mgEntradas.Rows.Add(row);
            }
        }

        private List<string> SaveRegister()
        {
            List<string> data = new List<string>();
            Registro NewReg = new Registro();
            NewReg.Fecha_Entrada = Convert.ToDateTime(mdtFecha_E.Value.ToString("yyyy-MM-d"));
            NewReg.Hora_Entrada = dtpHora_E.Text;
            NewReg.Fecha_Salida = Convert.ToDateTime(mdtFecha_S.Value.ToString("yyyy-MM-d"));
            NewReg.Hora_Salida = dtpHora_S.Text;

            Registro Reg = new Registro();
            Reg.Matricula = int.Parse(Matricula);

            Reg.Fecha_Entrada = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString());
            Reg.Hora_Entrada = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
            Reg.Fecha_Salida = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString());
            Reg.Hora_Salida = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();
            Reg.Tipo_Registro = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[4].Value.ToString();

            DM.UpdateRegistroFromControl(Reg, NewReg);

            data.Add(mdtFecha_E.Value.ToString("yyyy-MM-d"));
            data.Add(dtpHora_E.Text);
            data.Add(mdtFecha_S.Value.ToString("yyyy-MM-d"));
            data.Add(dtpHora_S.Text);

            ///update
            return data;
        }

        private void mbCancelar_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void mbEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que deseas continuar y aplicar los cambios al registro seleccionado?"
                    , "ADVERTENCIA - EDICION DE DATOS.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                List<string> New = SaveRegister();

                mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value = New.ElementAt(0);
                mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value = New.ElementAt(1);
                mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value = New.ElementAt(2);
                mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value = New.ElementAt(3);

                /////Reset controls
                mpData.Enabled = true;

                mbEditar.Enabled = false;
                mbElimina.Enabled = true;

                mdtFecha_E.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString());
                dtpHora_E.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
                mdtFecha_S.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString());
                dtpHora_S.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();
            }
            else if (result == DialogResult.Cancel)
            {
            }
        }

        public void DeleteSelectedIndexFromDataGrid(bool All, DataGridViewSelectedRowCollection Selection)
        {
            if (mgEntradas.Rows[Selection[0].Index].Cells[1].Value != null || All)
            {
                if (All)
                {
                    for (int i = mgEntradas.Rows.Count - 1; i >= 0; i--)
                    {
                        mgEntradas.Rows.RemoveAt(i);
                    }
                }
                else
                {
                    if (Selection.Count <= 1)
                    {
                        for (int i = Selection.Count - 1; i <= 0; i++)
                        {
                            mgEntradas.Rows.RemoveAt(Selection[i].Index);
                        }
                    }
                    else
                    {
                        for (int i = Selection.Count - 1; i >= 0; i--)
                            mgEntradas.Rows.RemoveAt(Selection[i].Index);
                    }
                }
            }
        }

        private void mbElimina_Click(object sender, EventArgs e)
        {
            if (!mbEditar.Enabled)
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que deseas eliminar el registro seleccionado?"
                    , "ADVERTENCIA - EDICION DE DATOS.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Registro Regis = new Registro();

                    Regis.Matricula = int.Parse(Matricula);

                    Regis.Fecha_Entrada = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Regis.Hora_Entrada = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
                    Regis.Fecha_Salida = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString());
                    Regis.Hora_Salida = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();
                    Regis.Tipo_Registro = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[4].Value.ToString();

                    DM.DeleteRegistro(Regis);

                    DeleteSelectedIndexFromDataGrid(false, mgEntradas.SelectedRows);
                }
                else if (result == DialogResult.Cancel)
                {
                }
            }
            else
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que deseas continuar sin aplicar los cambios el registro seleccionado?"
                    , "ADVERTENCIA - EDICION DE DATOS.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    /////Reset controls
                    mpData.Enabled = true;

                    mbEditar.Enabled = false;
                    mbElimina.Enabled = true;

                    mdtFecha_E.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString());
                    dtpHora_E.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
                    mdtFecha_S.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString());
                    dtpHora_S.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();
                }
                else if (result == DialogResult.Cancel)
                {
                    ////Continue in code
                }
            }
        }

        private void mgEntradas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = mgEntradas.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    mgEntradas.ClearSelection();
                    mgEntradas.Rows[currentMouseOverRow].Selected = true;

                    string data = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(data))
                    {
                        if (mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString() != "EN TURNO")
                        {
                            mpData.Enabled = true;

                            HE = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
                            HS = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();
                            FE = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString();
                            FS = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString();

                            mdtFecha_E.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[0].Value.ToString());
                            dtpHora_E.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[1].Value.ToString();
                            mdtFecha_S.Value = Convert.ToDateTime(mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[2].Value.ToString());
                            dtpHora_S.Text = mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString();

                            mbEditar.Enabled = false;
                        }
                        else
                        {
                            //MessageBox.Show("El Registro no puede ser modificado porque el Alumno "
                            //+ Nombre + " Esta actualmente en turno", "Atencion",
                            //MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            mpData.Enabled = true;

                            mdtFecha_E.Value = DateTime.Today;
                            dtpHora_E.Text = DateTime.Now.ToShortTimeString();
                            mdtFecha_S.Value = DateTime.Today;
                            dtpHora_S.Text = DateTime.Now.ToShortTimeString();
                        }
                    }
                    //mcMenu.Show(mgHorarios, new Point(e.X, e.Y));
                }
            } 
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            if (mgEntradas.SelectedRows.Count > 0)
            {
                mbElimina.Enabled = true;

                if (HE != null && HS != null && FE != null && FS != null)
                {
                    if (mgEntradas.Rows[mgEntradas.SelectedRows[0].Index].Cells[3].Value.ToString() != "EN TURNO")
                    {
                        if (HE != dtpHora_E.Text || HS != dtpHora_S.Text || FE != mdtFecha_E.Value.ToString("yyyy-MM-d") || FS != mdtFecha_S.Value.ToString("yyyy-MM-d"))
                            mbEditar.Enabled = true;
                        else
                            mbEditar.Enabled = false;
                    }
                    else
                    {
                        mbEditar.Enabled = false;
                        mbElimina.Enabled = false;
                    }
                }
            }
            else
                mbElimina.Enabled = false;
        }

        private void mbEditar_EnabledChanged(object sender, EventArgs e)
        {
            if (mbEditar.Enabled)
                mbElimina.Text = "Cancelar Edicion";
            else
                mbElimina.Text = "Eliminar";
        }
    }
}
