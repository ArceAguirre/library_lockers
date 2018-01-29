namespace MetroPanelSlide.Panel
{
    partial class pnlDataEdition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpHora_S = new System.Windows.Forms.DateTimePicker();
            this.dtpHora_E = new System.Windows.Forms.DateTimePicker();
            this.mbCancelar = new MetroFramework.Controls.MetroButton();
            this.mbEditar = new MetroFramework.Controls.MetroButton();
            this.mbElimina = new MetroFramework.Controls.MetroButton();
            this.mdtFecha_E = new MetroFramework.Controls.MetroDateTime();
            this.mdtFecha_S = new MetroFramework.Controls.MetroDateTime();
            this.mgEntradas = new MetroFramework.Controls.MetroGrid();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpData = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mgEntradas)).BeginInit();
            this.mpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(22, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 25);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Salida";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(22, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 25);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Entrada";
            // 
            // dtpHora_S
            // 
            this.dtpHora_S.CustomFormat = "HH:mm";
            this.dtpHora_S.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_S.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora_S.Location = new System.Drawing.Point(32, 219);
            this.dtpHora_S.Name = "dtpHora_S";
            this.dtpHora_S.ShowUpDown = true;
            this.dtpHora_S.Size = new System.Drawing.Size(157, 33);
            this.dtpHora_S.TabIndex = 51;
            this.dtpHora_S.Value = new System.DateTime(2016, 1, 21, 15, 44, 30, 0);
            this.dtpHora_S.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // dtpHora_E
            // 
            this.dtpHora_E.CustomFormat = "HH:mm";
            this.dtpHora_E.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_E.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora_E.Location = new System.Drawing.Point(32, 97);
            this.dtpHora_E.Name = "dtpHora_E";
            this.dtpHora_E.ShowUpDown = true;
            this.dtpHora_E.Size = new System.Drawing.Size(157, 33);
            this.dtpHora_E.TabIndex = 50;
            this.dtpHora_E.Value = new System.DateTime(2016, 1, 21, 15, 44, 26, 0);
            this.dtpHora_E.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // mbCancelar
            // 
            this.mbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCancelar.Location = new System.Drawing.Point(661, 360);
            this.mbCancelar.Name = "mbCancelar";
            this.mbCancelar.Size = new System.Drawing.Size(149, 49);
            this.mbCancelar.TabIndex = 47;
            this.mbCancelar.Text = "Cerrar";
            this.mbCancelar.UseSelectable = true;
            this.mbCancelar.Click += new System.EventHandler(this.mbCancelar_Click);
            // 
            // mbEditar
            // 
            this.mbEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbEditar.Enabled = false;
            this.mbEditar.Location = new System.Drawing.Point(37, 360);
            this.mbEditar.Name = "mbEditar";
            this.mbEditar.Size = new System.Drawing.Size(149, 49);
            this.mbEditar.TabIndex = 48;
            this.mbEditar.Text = "Editar";
            this.mbEditar.UseSelectable = true;
            this.mbEditar.EnabledChanged += new System.EventHandler(this.mbEditar_EnabledChanged);
            this.mbEditar.Click += new System.EventHandler(this.mbEditar_Click);
            // 
            // mbElimina
            // 
            this.mbElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbElimina.Enabled = false;
            this.mbElimina.Location = new System.Drawing.Point(210, 360);
            this.mbElimina.Name = "mbElimina";
            this.mbElimina.Size = new System.Drawing.Size(149, 49);
            this.mbElimina.TabIndex = 49;
            this.mbElimina.Text = "Eliminar";
            this.mbElimina.UseSelectable = true;
            this.mbElimina.Click += new System.EventHandler(this.mbElimina_Click);
            // 
            // mdtFecha_E
            // 
            this.mdtFecha_E.Location = new System.Drawing.Point(32, 62);
            this.mdtFecha_E.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFecha_E.Name = "mdtFecha_E";
            this.mdtFecha_E.Size = new System.Drawing.Size(157, 29);
            this.mdtFecha_E.TabIndex = 54;
            this.mdtFecha_E.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // mdtFecha_S
            // 
            this.mdtFecha_S.Location = new System.Drawing.Point(32, 184);
            this.mdtFecha_S.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFecha_S.Name = "mdtFecha_S";
            this.mdtFecha_S.Size = new System.Drawing.Size(157, 29);
            this.mdtFecha_S.TabIndex = 54;
            this.mdtFecha_S.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // mgEntradas
            // 
            this.mgEntradas.AllowUserToAddRows = false;
            this.mgEntradas.AllowUserToDeleteRows = false;
            this.mgEntradas.AllowUserToResizeRows = false;
            this.mgEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaEntrada,
            this.HoraEntrada,
            this.FechaSalida,
            this.HoraSalida,
            this.TipoReg});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEntradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgEntradas.EnableHeadersVisualStyles = false;
            this.mgEntradas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEntradas.Location = new System.Drawing.Point(241, 24);
            this.mgEntradas.Name = "mgEntradas";
            this.mgEntradas.ReadOnly = true;
            this.mgEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgEntradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEntradas.Size = new System.Drawing.Size(569, 330);
            this.mgEntradas.TabIndex = 55;
            this.mgEntradas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mgEntradas_MouseDown);
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.HeaderText = "Fecha Entrada";
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Hora Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha Salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // TipoReg
            // 
            this.TipoReg.HeaderText = "Tipo Registro";
            this.TipoReg.Name = "TipoReg";
            this.TipoReg.ReadOnly = true;
            // 
            // mpData
            // 
            this.mpData.Controls.Add(this.mdtFecha_S);
            this.mpData.Controls.Add(this.metroLabel2);
            this.mpData.Controls.Add(this.mdtFecha_E);
            this.mpData.Controls.Add(this.dtpHora_E);
            this.mpData.Controls.Add(this.metroLabel3);
            this.mpData.Controls.Add(this.dtpHora_S);
            this.mpData.HorizontalScrollbarBarColor = true;
            this.mpData.HorizontalScrollbarHighlightOnWheel = false;
            this.mpData.HorizontalScrollbarSize = 10;
            this.mpData.Location = new System.Drawing.Point(3, 3);
            this.mpData.Name = "mpData";
            this.mpData.Size = new System.Drawing.Size(214, 268);
            this.mpData.TabIndex = 56;
            this.mpData.VerticalScrollbarBarColor = true;
            this.mpData.VerticalScrollbarHighlightOnWheel = false;
            this.mpData.VerticalScrollbarSize = 10;
            // 
            // pnlDataEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpData);
            this.Controls.Add(this.mgEntradas);
            this.Controls.Add(this.mbCancelar);
            this.Controls.Add(this.mbEditar);
            this.Controls.Add(this.mbElimina);
            this.Name = "pnlDataEdition";
            this.Size = new System.Drawing.Size(835, 434);
            ((System.ComponentModel.ISupportInitialize)(this.mgEntradas)).EndInit();
            this.mpData.ResumeLayout(false);
            this.mpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtpHora_S;
        private System.Windows.Forms.DateTimePicker dtpHora_E;
        private MetroFramework.Controls.MetroButton mbCancelar;
        private MetroFramework.Controls.MetroButton mbEditar;
        private MetroFramework.Controls.MetroButton mbElimina;
        private MetroFramework.Controls.MetroDateTime mdtFecha_E;
        private MetroFramework.Controls.MetroDateTime mdtFecha_S;
        private MetroFramework.Controls.MetroGrid mgEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReg;
        private MetroFramework.Controls.MetroPanel mpData;
    }
}
