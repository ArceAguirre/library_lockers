namespace FCFM_Registro_Alumnos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.datosDelAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDelAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MetroStudentsRpts = new MetroFramework.Controls.MetroButton();
            this.MetroRpts = new MetroFramework.Controls.MetroButton();
            this.MetroTotalHrs = new MetroFramework.Controls.MetroButton();
            this.MetroCut = new MetroFramework.Controls.MetroButton();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtTime = new MetroFramework.Controls.MetroTile();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.mgAlumnosList = new MetroFramework.Controls.MetroGrid();
            this.NombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mttHelp = new MetroFramework.Components.MetroToolTip();
            this.mlData = new MetroFramework.Controls.MetroLink();
            this.mlNotifications = new MetroFramework.Controls.MetroLink();
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mcMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.datosAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioDelAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDelAlumnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.mtTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumnosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 228);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelAlumnoToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.reporteDelAlumnoToolStripMenuItem,
            this.horasTotalesToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.salidaToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // datosDelAlumnoToolStripMenuItem
            // 
            this.datosDelAlumnoToolStripMenuItem.Name = "datosDelAlumnoToolStripMenuItem";
            this.datosDelAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosDelAlumnoToolStripMenuItem.Text = "Datos del Alumno";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionToolStripMenuItem.Text = "Horario del Alumno";
            // 
            // reporteDelAlumnoToolStripMenuItem
            // 
            this.reporteDelAlumnoToolStripMenuItem.Name = "reporteDelAlumnoToolStripMenuItem";
            this.reporteDelAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDelAlumnoToolStripMenuItem.Text = "Reporte del Alumno";
            // 
            // horasTotalesToolStripMenuItem
            // 
            this.horasTotalesToolStripMenuItem.Name = "horasTotalesToolStripMenuItem";
            this.horasTotalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horasTotalesToolStripMenuItem.Text = "Horas Mensuales";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidaToolStripMenuItem.Text = "Control de Horas";
            // 
            // salidaToolStripMenuItem1
            // 
            this.salidaToolStripMenuItem1.Name = "salidaToolStripMenuItem1";
            this.salidaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salidaToolStripMenuItem1.Text = "Salida";
            // 
            // MetroStudentsRpts
            // 
            this.MetroStudentsRpts.Location = new System.Drawing.Point(464, 302);
            this.MetroStudentsRpts.Name = "MetroStudentsRpts";
            this.MetroStudentsRpts.Size = new System.Drawing.Size(187, 41);
            this.MetroStudentsRpts.TabIndex = 36;
            this.MetroStudentsRpts.Text = "Reporte Alumnos";
            this.MetroStudentsRpts.UseSelectable = true;
            this.MetroStudentsRpts.Click += new System.EventHandler(this.MetroStudentsRpts_Click);
            // 
            // MetroRpts
            // 
            this.MetroRpts.Location = new System.Drawing.Point(256, 302);
            this.MetroRpts.Name = "MetroRpts";
            this.MetroRpts.Size = new System.Drawing.Size(187, 41);
            this.MetroRpts.TabIndex = 36;
            this.MetroRpts.Text = "Reporte de Horas";
            this.MetroRpts.UseSelectable = true;
            this.MetroRpts.Click += new System.EventHandler(this.MetroRpts_Click);
            // 
            // MetroTotalHrs
            // 
            this.MetroTotalHrs.Location = new System.Drawing.Point(464, 349);
            this.MetroTotalHrs.Name = "MetroTotalHrs";
            this.MetroTotalHrs.Size = new System.Drawing.Size(187, 41);
            this.MetroTotalHrs.TabIndex = 36;
            this.MetroTotalHrs.Text = "Total de Horas";
            this.MetroTotalHrs.UseSelectable = true;
            this.MetroTotalHrs.Click += new System.EventHandler(this.MetroTotalHrs_Click);
            // 
            // MetroCut
            // 
            this.MetroCut.BackColor = System.Drawing.Color.Tomato;
            this.MetroCut.Location = new System.Drawing.Point(256, 349);
            this.MetroCut.Name = "MetroCut";
            this.MetroCut.Size = new System.Drawing.Size(187, 41);
            this.MetroCut.TabIndex = 36;
            this.MetroCut.Text = "Corte";
            this.MetroCut.UseCustomBackColor = true;
            this.MetroCut.UseSelectable = true;
            this.MetroCut.Click += new System.EventHandler(this.MetroCut_Click);
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(256, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 25);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "ALUMNOS EN TURNO";
            // 
            // mtTime
            // 
            this.mtTime.ActiveControl = null;
            this.mtTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtTime.Controls.Add(this.mlTime);
            this.mtTime.Location = new System.Drawing.Point(0, 406);
            this.mtTime.Name = "mtTime";
            this.mtTime.Size = new System.Drawing.Size(766, 31);
            this.mtTime.TabIndex = 40;
            this.mtTime.UseSelectable = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlTime.Location = new System.Drawing.Point(3, 3);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(56, 25);
            this.mlTime.TabIndex = 41;
            this.mlTime.Text = "00:00";
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
            this.NombreM,
            this.Matricula,
            this.EntradaM});
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
            this.mgAlumnosList.Location = new System.Drawing.Point(256, 78);
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
            this.mgAlumnosList.Size = new System.Drawing.Size(487, 201);
            this.mgAlumnosList.TabIndex = 41;
            this.mgAlumnosList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlumnosList_MouseDown);
            // 
            // NombreM
            // 
            this.NombreM.HeaderText = "Nombre";
            this.NombreM.Name = "NombreM";
            this.NombreM.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // EntradaM
            // 
            this.EntradaM.HeaderText = "Entrada";
            this.EntradaM.Name = "EntradaM";
            this.EntradaM.ReadOnly = true;
            // 
            // mttHelp
            // 
            this.mttHelp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttHelp.StyleManager = null;
            this.mttHelp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mlData
            // 
            this.mlData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlData.Image = ((System.Drawing.Image)(resources.GetObject("mlData.Image")));
            this.mlData.ImageSize = 32;
            this.mlData.Location = new System.Drawing.Point(716, 302);
            this.mlData.Name = "mlData";
            this.mlData.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlData.NoFocusImage")));
            this.mlData.Size = new System.Drawing.Size(41, 41);
            this.mlData.TabIndex = 37;
            this.mlData.UseSelectable = true;
            this.mlData.Click += new System.EventHandler(this.mlData_Click);
            // 
            // mlNotifications
            // 
            this.mlNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlNotifications.Image = ((System.Drawing.Image)(resources.GetObject("mlNotifications.Image")));
            this.mlNotifications.ImageSize = 32;
            this.mlNotifications.Location = new System.Drawing.Point(669, 359);
            this.mlNotifications.Name = "mlNotifications";
            this.mlNotifications.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlNotifications.NoFocusImage")));
            this.mlNotifications.Size = new System.Drawing.Size(41, 41);
            this.mlNotifications.TabIndex = 37;
            this.mlNotifications.UseSelectable = true;
            this.mlNotifications.Click += new System.EventHandler(this.lnkNotifications_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("lnkSettings.Image")));
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(716, 359);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSettings.NoFocusImage")));
            this.lnkSettings.Size = new System.Drawing.Size(41, 41);
            this.lnkSettings.TabIndex = 37;
            this.lnkSettings.UseSelectable = true;
            this.lnkSettings.Click += new System.EventHandler(this.lnkSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(669, 302);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.NoFocusImage")));
            this.metroLink1.Size = new System.Drawing.Size(41, 41);
            this.metroLink1.TabIndex = 37;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.mlCheckInOuts_Click);
            // 
            // mcMenu
            // 
            this.mcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosAlumnoToolStripMenuItem,
            this.horarioDelAlumnoToolStripMenuItem,
            this.reporteDelAlumnoToolStripMenuItem1,
            this.horasMensualesToolStripMenuItem,
            this.controlDeHorasToolStripMenuItem,
            this.salidaToolStripMenuItem2,
            this.salidaToolStripMenuItem3});
            this.mcMenu.Name = "metroContextMenu1";
            this.mcMenu.Size = new System.Drawing.Size(181, 158);
            this.mcMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // datosAlumnoToolStripMenuItem
            // 
            this.datosAlumnoToolStripMenuItem.Name = "datosAlumnoToolStripMenuItem";
            this.datosAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosAlumnoToolStripMenuItem.Text = "Datos del Alumno";
            // 
            // horarioDelAlumnoToolStripMenuItem
            // 
            this.horarioDelAlumnoToolStripMenuItem.Name = "horarioDelAlumnoToolStripMenuItem";
            this.horarioDelAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horarioDelAlumnoToolStripMenuItem.Text = "Horario del Alumno";
            // 
            // reporteDelAlumnoToolStripMenuItem1
            // 
            this.reporteDelAlumnoToolStripMenuItem1.Name = "reporteDelAlumnoToolStripMenuItem1";
            this.reporteDelAlumnoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reporteDelAlumnoToolStripMenuItem1.Text = "Reporte del Alumno";
            // 
            // horasMensualesToolStripMenuItem
            // 
            this.horasMensualesToolStripMenuItem.Name = "horasMensualesToolStripMenuItem";
            this.horasMensualesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horasMensualesToolStripMenuItem.Text = "Horas Mensuales";
            // 
            // controlDeHorasToolStripMenuItem
            // 
            this.controlDeHorasToolStripMenuItem.Name = "controlDeHorasToolStripMenuItem";
            this.controlDeHorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlDeHorasToolStripMenuItem.Text = "Control de Horas";
            // 
            // salidaToolStripMenuItem2
            // 
            this.salidaToolStripMenuItem2.Name = "salidaToolStripMenuItem2";
            this.salidaToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.salidaToolStripMenuItem2.Text = "Salida Manual";
            // 
            // salidaToolStripMenuItem3
            // 
            this.salidaToolStripMenuItem3.Name = "salidaToolStripMenuItem3";
            this.salidaToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.salidaToolStripMenuItem3.Text = "Salida";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 437);
            this.Controls.Add(this.mgAlumnosList);
            this.Controls.Add(this.mtTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.mlData);
            this.Controls.Add(this.mlNotifications);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.MetroCut);
            this.Controls.Add(this.MetroRpts);
            this.Controls.Add(this.MetroStudentsRpts);
            this.Controls.Add(this.MetroTotalHrs);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Biblioteca FCFM";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.mtTime.ResumeLayout(false);
            this.mtTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumnosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDelAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem1;
        private MetroFramework.Controls.MetroButton MetroStudentsRpts;
        private MetroFramework.Controls.MetroButton MetroRpts;
        private MetroFramework.Controls.MetroButton MetroTotalHrs;
        private MetroFramework.Controls.MetroButton MetroCut;
        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mlTime;
        private MetroFramework.Controls.MetroTile mtTime;
        private MetroFramework.Controls.MetroLink mlNotifications;
        private MetroFramework.Controls.MetroGrid mgAlumnosList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaM;
        private MetroFramework.Components.MetroToolTip mttHelp;
        private MetroFramework.Controls.MetroLink mlData;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroContextMenu mcMenu;
        private System.Windows.Forms.ToolStripMenuItem datosAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioDelAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDelAlumnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horasMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem3;
    }
}