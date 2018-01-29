namespace FCFM_Registro_Alumnos.UI_Forms
{
    partial class ControlHoras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgAlumnosList = new MetroFramework.Controls.MetroGrid();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mbCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumnosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mgAlumnosList
            // 
            this.mgAlumnosList.AllowUserToAddRows = false;
            this.mgAlumnosList.AllowUserToDeleteRows = false;
            this.mgAlumnosList.AllowUserToResizeRows = false;
            this.mgAlumnosList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlumnosList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAlumnosList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAlumnosList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlumnosList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgAlumnosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlumnosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.mgNombre,
            this.Carrera,
            this.Semestre,
            this.Periodo,
            this.TipoServicio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlumnosList.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgAlumnosList.EnableHeadersVisualStyles = false;
            this.mgAlumnosList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlumnosList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlumnosList.Location = new System.Drawing.Point(23, 69);
            this.mgAlumnosList.Name = "mgAlumnosList";
            this.mgAlumnosList.ReadOnly = true;
            this.mgAlumnosList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlumnosList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgAlumnosList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAlumnosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAlumnosList.Size = new System.Drawing.Size(772, 274);
            this.mgAlumnosList.TabIndex = 44;
            this.mgAlumnosList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mgAlumnosList_MouseDown);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // mgNombre
            // 
            this.mgNombre.HeaderText = "Nombre";
            this.mgNombre.Name = "mgNombre";
            this.mgNombre.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // TipoServicio
            // 
            this.TipoServicio.HeaderText = "Tipo Servicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.ReadOnly = true;
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // mbCancelar
            // 
            this.mbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCancelar.Location = new System.Drawing.Point(646, 359);
            this.mbCancelar.Name = "mbCancelar";
            this.mbCancelar.Size = new System.Drawing.Size(149, 49);
            this.mbCancelar.TabIndex = 48;
            this.mbCancelar.Text = "Cerrar";
            this.mbCancelar.UseSelectable = true;
            this.mbCancelar.Click += new System.EventHandler(this.mbCancelar_Click);
            // 
            // ControlHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 440);
            this.ControlBox = false;
            this.Controls.Add(this.mbCancelar);
            this.Controls.Add(this.mgAlumnosList);
            this.Name = "ControlHoras";
            this.Text = "ControlHoras";
            this.Load += new System.EventHandler(this.ControlHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumnosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgAlumnosList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Controls.MetroButton mbCancelar;
    }
}