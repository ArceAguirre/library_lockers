namespace MetroPanelSlide.Panel
{
    partial class pnlNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlNotifications));
            this.mgNotificaciones = new MetroFramework.Controls.MetroGrid();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarNotificacion = new MetroFramework.Controls.MetroButton();
            this.EliminaTodos = new MetroFramework.Controls.MetroButton();
            this.mlNotificaciones = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Editar = new MetroFramework.Controls.MetroButton();
            this.mtTime = new MetroFramework.Controls.MetroTile();
            this.HoraCorte = new System.Windows.Forms.DateTimePicker();
            this.mttHelp = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.mgNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // mgNotificaciones
            // 
            this.mgNotificaciones.AllowUserToAddRows = false;
            this.mgNotificaciones.AllowUserToDeleteRows = false;
            this.mgNotificaciones.AllowUserToResizeRows = false;
            this.mgNotificaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgNotificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgNotificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgNotificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgNotificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Matricula,
            this.Entrada,
            this.Salida});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgNotificaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgNotificaciones.EnableHeadersVisualStyles = false;
            this.mgNotificaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgNotificaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgNotificaciones.Location = new System.Drawing.Point(33, 61);
            this.mgNotificaciones.Name = "mgNotificaciones";
            this.mgNotificaciones.ReadOnly = true;
            this.mgNotificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgNotificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgNotificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgNotificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgNotificaciones.Size = new System.Drawing.Size(441, 198);
            this.mgNotificaciones.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // EliminarNotificacion
            // 
            this.EliminarNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarNotificacion.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.EliminarNotificacion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.EliminarNotificacion.Location = new System.Drawing.Point(493, 61);
            this.EliminarNotificacion.Name = "EliminarNotificacion";
            this.EliminarNotificacion.Size = new System.Drawing.Size(243, 42);
            this.EliminarNotificacion.TabIndex = 1;
            this.EliminarNotificacion.Text = "Eliminar";
            this.EliminarNotificacion.UseSelectable = true;
            this.EliminarNotificacion.Click += new System.EventHandler(this.EliminarNotificacion_Click);
            // 
            // EliminaTodos
            // 
            this.EliminaTodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminaTodos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.EliminaTodos.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.EliminaTodos.Location = new System.Drawing.Point(493, 109);
            this.EliminaTodos.Name = "EliminaTodos";
            this.EliminaTodos.Size = new System.Drawing.Size(243, 42);
            this.EliminaTodos.TabIndex = 1;
            this.EliminaTodos.Text = "Elimina Todos";
            this.EliminaTodos.UseSelectable = true;
            this.EliminaTodos.Click += new System.EventHandler(this.EliminaTodos_Click);
            // 
            // mlNotificaciones
            // 
            this.mlNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlNotificaciones.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlNotificaciones.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.mlNotificaciones.Image = ((System.Drawing.Image)(resources.GetObject("mlNotificaciones.Image")));
            this.mlNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlNotificaciones.ImageSize = 28;
            this.mlNotificaciones.Location = new System.Drawing.Point(15, 267);
            this.mlNotificaciones.Name = "mlNotificaciones";
            this.mlNotificaciones.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlNotificaciones.NoFocusImage")));
            this.mlNotificaciones.Size = new System.Drawing.Size(150, 33);
            this.mlNotificaciones.TabIndex = 2;
            this.mlNotificaciones.Text = "&Volver";
            this.mlNotificaciones.UseSelectable = true;
            this.mlNotificaciones.Click += new System.EventHandler(this.mlNotificaciones_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(32, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Notificaciones";
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Editar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Editar.Location = new System.Drawing.Point(493, 217);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(249, 42);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.UseSelectable = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // mtTime
            // 
            this.mtTime.ActiveControl = null;
            this.mtTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtTime.Location = new System.Drawing.Point(493, 157);
            this.mtTime.Name = "mtTime";
            this.mtTime.Size = new System.Drawing.Size(243, 4);
            this.mtTime.TabIndex = 41;
            this.mtTime.UseSelectable = true;
            // 
            // HoraCorte
            // 
            this.HoraCorte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraCorte.CustomFormat = "HH:mm";
            this.HoraCorte.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraCorte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HoraCorte.Location = new System.Drawing.Point(493, 178);
            this.HoraCorte.Name = "HoraCorte";
            this.HoraCorte.ShowUpDown = true;
            this.HoraCorte.Size = new System.Drawing.Size(249, 33);
            this.HoraCorte.TabIndex = 42;
            this.HoraCorte.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // mttHelp
            // 
            this.mttHelp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttHelp.StyleManager = null;
            this.mttHelp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pnlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HoraCorte);
            this.Controls.Add(this.mtTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlNotificaciones);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.EliminaTodos);
            this.Controls.Add(this.EliminarNotificacion);
            this.Controls.Add(this.mgNotificaciones);
            this.Size = new System.Drawing.Size(750, 312);
            this.UseCustomBackColor = false;
            this.Load += new System.EventHandler(this.pnlNotifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgNotificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private MetroFramework.Controls.MetroButton EliminarNotificacion;
        private MetroFramework.Controls.MetroButton EliminaTodos;
        private MetroFramework.Controls.MetroLink mlNotificaciones;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton Editar;
        private MetroFramework.Controls.MetroTile mtTime;
        private System.Windows.Forms.DateTimePicker HoraCorte;
        private MetroFramework.Components.MetroToolTip mttHelp;
    }
}
