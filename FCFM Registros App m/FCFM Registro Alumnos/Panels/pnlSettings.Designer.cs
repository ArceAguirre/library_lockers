namespace MetroPanelSlide.Panel
{
    partial class pnlSettings
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
            this.components = new System.ComponentModel.Container();
            this.metroCancel = new MetroFramework.Controls.MetroButton();
            this.metroTabSettings = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.HoraCorte = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroAutoCorte = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroHolyDays = new MetroFramework.Controls.MetroToggle();
            this.metroVacations = new MetroFramework.Controls.MetroToggle();
            this.metroManual = new MetroFramework.Controls.MetroRadioButton();
            this.metroAutomatico = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroDarkTheme = new MetroFramework.Controls.MetroRadioButton();
            this.metroLightTheme = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroAyuda = new MetroFramework.Controls.MetroToggle();
            this.metroScanner = new MetroFramework.Controls.MetroToggle();
            this.metroNotificaciones = new MetroFramework.Controls.MetroToggle();
            this.metroActividad = new MetroFramework.Controls.MetroToggle();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mttHelp = new MetroFramework.Components.MetroToolTip();
            this.metroTabSettings.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCancel
            // 
            this.metroCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCancel.Location = new System.Drawing.Point(555, 273);
            this.metroCancel.Name = "metroCancel";
            this.metroCancel.Size = new System.Drawing.Size(168, 37);
            this.metroCancel.TabIndex = 0;
            this.metroCancel.Text = "Cancelar";
            this.metroCancel.UseSelectable = true;
            this.metroCancel.Click += new System.EventHandler(this.metroCancel_Click);
            // 
            // metroTabSettings
            // 
            this.metroTabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabSettings.Controls.Add(this.metroTabPage1);
            this.metroTabSettings.Controls.Add(this.metroTabPage2);
            this.metroTabSettings.Location = new System.Drawing.Point(0, 0);
            this.metroTabSettings.Name = "metroTabSettings";
            this.metroTabSettings.SelectedIndex = 0;
            this.metroTabSettings.Size = new System.Drawing.Size(723, 260);
            this.metroTabSettings.TabIndex = 7;
            this.metroTabSettings.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.HoraCorte);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroAutoCorte);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroHolyDays);
            this.metroTabPage1.Controls.Add(this.metroVacations);
            this.metroTabPage1.Controls.Add(this.metroManual);
            this.metroTabPage1.Controls.Add(this.metroAutomatico);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(715, 218);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Control de Horas";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // HoraCorte
            // 
            this.HoraCorte.CustomFormat = "HH:mm";
            this.HoraCorte.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraCorte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HoraCorte.Location = new System.Drawing.Point(143, 26);
            this.HoraCorte.Name = "HoraCorte";
            this.HoraCorte.ShowUpDown = true;
            this.HoraCorte.Size = new System.Drawing.Size(200, 33);
            this.HoraCorte.TabIndex = 30;
            this.HoraCorte.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Corte Automatico";
            // 
            // metroAutoCorte
            // 
            this.metroAutoCorte.AutoSize = true;
            this.metroAutoCorte.Location = new System.Drawing.Point(20, 38);
            this.metroAutoCorte.Name = "metroAutoCorte";
            this.metroAutoCorte.Size = new System.Drawing.Size(80, 17);
            this.metroAutoCorte.TabIndex = 12;
            this.metroAutoCorte.Text = "Off";
            this.metroAutoCorte.UseSelectable = true;
            this.metroAutoCorte.CheckedChanged += new System.EventHandler(this.metroAutoCorte_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Dia Festivo";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 66);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Vacaciones";
            this.metroLabel5.Visible = false;
            // 
            // metroHolyDays
            // 
            this.metroHolyDays.AutoSize = true;
            this.metroHolyDays.Location = new System.Drawing.Point(20, 150);
            this.metroHolyDays.Name = "metroHolyDays";
            this.metroHolyDays.Size = new System.Drawing.Size(80, 17);
            this.metroHolyDays.TabIndex = 10;
            this.metroHolyDays.Text = "Off";
            this.metroHolyDays.UseSelectable = true;
            this.metroHolyDays.Visible = false;
            this.metroHolyDays.CheckedChanged += new System.EventHandler(this.metroHolyDays_CheckedChanged);
            // 
            // metroVacations
            // 
            this.metroVacations.AutoSize = true;
            this.metroVacations.Location = new System.Drawing.Point(20, 94);
            this.metroVacations.Name = "metroVacations";
            this.metroVacations.Size = new System.Drawing.Size(80, 17);
            this.metroVacations.TabIndex = 11;
            this.metroVacations.Text = "Off";
            this.metroVacations.UseSelectable = true;
            this.metroVacations.Visible = false;
            this.metroVacations.CheckedChanged += new System.EventHandler(this.metroVacations_CheckedChanged);
            // 
            // metroManual
            // 
            this.metroManual.AutoSize = true;
            this.metroManual.Location = new System.Drawing.Point(143, 96);
            this.metroManual.Name = "metroManual";
            this.metroManual.Size = new System.Drawing.Size(98, 15);
            this.metroManual.TabIndex = 9;
            this.metroManual.Text = "Modo Manual";
            this.metroManual.UseSelectable = true;
            this.metroManual.CheckedChanged += new System.EventHandler(this.metroManual_CheckedChanged);
            // 
            // metroAutomatico
            // 
            this.metroAutomatico.AutoSize = true;
            this.metroAutomatico.Location = new System.Drawing.Point(143, 150);
            this.metroAutomatico.Name = "metroAutomatico";
            this.metroAutomatico.Size = new System.Drawing.Size(121, 15);
            this.metroAutomatico.TabIndex = 9;
            this.metroAutomatico.Text = "Modo Automatico";
            this.metroAutomatico.UseSelectable = true;
            this.metroAutomatico.CheckedChanged += new System.EventHandler(this.metroAutomatico_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroDarkTheme);
            this.metroTabPage2.Controls.Add(this.metroLightTheme);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.flpSettings);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroAyuda);
            this.metroTabPage2.Controls.Add(this.metroScanner);
            this.metroTabPage2.Controls.Add(this.metroNotificaciones);
            this.metroTabPage2.Controls.Add(this.metroActividad);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(715, 218);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Opciones Generales";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroDarkTheme
            // 
            this.metroDarkTheme.AutoSize = true;
            this.metroDarkTheme.Location = new System.Drawing.Point(457, 50);
            this.metroDarkTheme.Name = "metroDarkTheme";
            this.metroDarkTheme.Size = new System.Drawing.Size(56, 15);
            this.metroDarkTheme.TabIndex = 12;
            this.metroDarkTheme.Text = "Negro";
            this.metroDarkTheme.UseSelectable = true;
            this.metroDarkTheme.CheckedChanged += new System.EventHandler(this.metroDarkTheme_CheckedChanged);
            // 
            // metroLightTheme
            // 
            this.metroLightTheme.AutoSize = true;
            this.metroLightTheme.Location = new System.Drawing.Point(457, 82);
            this.metroLightTheme.Name = "metroLightTheme";
            this.metroLightTheme.Size = new System.Drawing.Size(59, 15);
            this.metroLightTheme.TabIndex = 13;
            this.metroLightTheme.Text = "Blanco";
            this.metroLightTheme.UseSelectable = true;
            this.metroLightTheme.CheckedChanged += new System.EventHandler(this.metroLightTheme_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(445, 10);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Tema";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(133, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Estilo";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Location = new System.Drawing.Point(133, 32);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(306, 186);
            this.flpSettings.TabIndex = 9;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(448, 123);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(86, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Modo Ayuda";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Escaner";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Ver Notificaciones";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ver Informacion";
            // 
            // metroAyuda
            // 
            this.metroAyuda.AutoSize = true;
            this.metroAyuda.Location = new System.Drawing.Point(465, 150);
            this.metroAyuda.Name = "metroAyuda";
            this.metroAyuda.Size = new System.Drawing.Size(80, 17);
            this.metroAyuda.TabIndex = 7;
            this.metroAyuda.Text = "Off";
            this.metroAyuda.UseSelectable = true;
            this.metroAyuda.CheckedChanged += new System.EventHandler(this.metroAyuda_CheckedChanged);
            // 
            // metroScanner
            // 
            this.metroScanner.AutoSize = true;
            this.metroScanner.Location = new System.Drawing.Point(20, 150);
            this.metroScanner.Name = "metroScanner";
            this.metroScanner.Size = new System.Drawing.Size(80, 17);
            this.metroScanner.TabIndex = 7;
            this.metroScanner.Text = "Off";
            this.metroScanner.UseSelectable = true;
            this.metroScanner.CheckedChanged += new System.EventHandler(this.metroScanner_CheckedChanged);
            // 
            // metroNotificaciones
            // 
            this.metroNotificaciones.AutoSize = true;
            this.metroNotificaciones.Location = new System.Drawing.Point(20, 94);
            this.metroNotificaciones.Name = "metroNotificaciones";
            this.metroNotificaciones.Size = new System.Drawing.Size(80, 17);
            this.metroNotificaciones.TabIndex = 7;
            this.metroNotificaciones.Text = "Off";
            this.metroNotificaciones.UseSelectable = true;
            this.metroNotificaciones.CheckedChanged += new System.EventHandler(this.metroNotificaciones_CheckedChanged);
            // 
            // metroActividad
            // 
            this.metroActividad.AutoSize = true;
            this.metroActividad.Location = new System.Drawing.Point(20, 38);
            this.metroActividad.Name = "metroActividad";
            this.metroActividad.Size = new System.Drawing.Size(80, 17);
            this.metroActividad.TabIndex = 7;
            this.metroActividad.Text = "Off";
            this.metroActividad.UseSelectable = true;
            this.metroActividad.CheckedChanged += new System.EventHandler(this.metroActividad_CheckedChanged);
            // 
            // metroSave
            // 
            this.metroSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSave.Location = new System.Drawing.Point(381, 273);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(168, 37);
            this.metroSave.TabIndex = 0;
            this.metroSave.Text = "Guardar";
            this.metroSave.UseSelectable = true;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(9, 276);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(189, 23);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "&Opciones Avanzadas";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // mttHelp
            // 
            this.mttHelp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttHelp.StyleManager = null;
            this.mttHelp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pnlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTabSettings);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.metroCancel);
            this.Name = "pnlSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(726, 313);
            this.UseCustomBackColor = false;
            this.Load += new System.EventHandler(this.pnlSettings_Load);
            this.metroTabSettings.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroCancel;
        private MetroFramework.Controls.MetroTabControl metroTabSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroRadioButton metroManual;
        private MetroFramework.Controls.MetroRadioButton metroAutomatico;
        private MetroFramework.Controls.MetroToggle metroScanner;
        private MetroFramework.Controls.MetroToggle metroNotificaciones;
        private MetroFramework.Controls.MetroToggle metroActividad;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle metroHolyDays;
        private MetroFramework.Controls.MetroToggle metroVacations;
        private MetroFramework.Controls.MetroToggle metroAutoCorte;
        private MetroFramework.Controls.MetroButton metroSave;
        private System.Windows.Forms.DateTimePicker HoraCorte;
        private MetroFramework.Controls.MetroRadioButton metroDarkTheme;
        private MetroFramework.Controls.MetroRadioButton metroLightTheme;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle metroAyuda;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Components.MetroToolTip mttHelp;
    }
}
