namespace MetroPanelSlide.Panel
{
    partial class pnlData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AlumnosList = new MetroFramework.Controls.MetroGrid();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStudent = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.metroSemestre = new MetroFramework.Controls.MetroComboBox();
            this.metroCarrera = new MetroFramework.Controls.MetroComboBox();
            this.A_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.A_Matricula = new MetroFramework.Controls.MetroTextBox();
            this.A_ApellidoP = new MetroFramework.Controls.MetroTextBox();
            this.A_ApellidoM = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Becario = new MetroFramework.Controls.MetroRadioButton();
            this.ServicioSocial = new MetroFramework.Controls.MetroRadioButton();
            this.Verano = new MetroFramework.Controls.MetroRadioButton();
            this.Invierno = new MetroFramework.Controls.MetroRadioButton();
            this.Edit = new MetroFramework.Controls.MetroButton();
            this.DeleteStudent = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.mcMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.horarioDelAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDelAlumnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosList)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.mcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlumnosList
            // 
            this.AlumnosList.AllowUserToAddRows = false;
            this.AlumnosList.AllowUserToDeleteRows = false;
            this.AlumnosList.AllowUserToResizeRows = false;
            this.AlumnosList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AlumnosList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlumnosList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AlumnosList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AlumnosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
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
            this.AlumnosList.DefaultCellStyle = dataGridViewCellStyle2;
            this.AlumnosList.EnableHeadersVisualStyles = false;
            this.AlumnosList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AlumnosList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AlumnosList.Location = new System.Drawing.Point(469, 56);
            this.AlumnosList.Name = "AlumnosList";
            this.AlumnosList.ReadOnly = true;
            this.AlumnosList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AlumnosList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AlumnosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlumnosList.Size = new System.Drawing.Size(268, 280);
            this.AlumnosList.TabIndex = 23;
            this.AlumnosList.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlumnosList_RowLeave);
            this.AlumnosList.SelectionChanged += new System.EventHandler(this.AlumnosList_SelectionChanged);
            this.AlumnosList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlumnosList_MouseDown);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            // AddStudent
            // 
            this.AddStudent.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddStudent.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.AddStudent.Location = new System.Drawing.Point(469, 389);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(124, 46);
            this.AddStudent.TabIndex = 19;
            this.AddStudent.Text = "Agregar";
            this.AddStudent.UseSelectable = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Cancel
            // 
            this.Cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Cancel.Location = new System.Drawing.Point(613, 389);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 46);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseSelectable = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // metroSemestre
            // 
            this.metroSemestre.FormattingEnabled = true;
            this.metroSemestre.ItemHeight = 23;
            this.metroSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.metroSemestre.Location = new System.Drawing.Point(264, 190);
            this.metroSemestre.Name = "metroSemestre";
            this.metroSemestre.Size = new System.Drawing.Size(177, 29);
            this.metroSemestre.TabIndex = 12;
            this.metroSemestre.UseSelectable = true;
            this.metroSemestre.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // metroCarrera
            // 
            this.metroCarrera.FormattingEnabled = true;
            this.metroCarrera.ItemHeight = 23;
            this.metroCarrera.Items.AddRange(new object[] {
            "LA",
            "LF",
            "LM",
            "LMAD",
            "LCC",
            "LSTI",
            "POST",
            "TECNICA"});
            this.metroCarrera.Location = new System.Drawing.Point(50, 190);
            this.metroCarrera.Name = "metroCarrera";
            this.metroCarrera.Size = new System.Drawing.Size(177, 29);
            this.metroCarrera.TabIndex = 11;
            this.metroCarrera.UseSelectable = true;
            this.metroCarrera.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // A_Nombre
            // 
            // 
            // 
            // 
            this.A_Nombre.CustomButton.Image = null;
            this.A_Nombre.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.A_Nombre.CustomButton.Name = "";
            this.A_Nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.A_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A_Nombre.CustomButton.TabIndex = 1;
            this.A_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A_Nombre.CustomButton.UseSelectable = true;
            this.A_Nombre.CustomButton.Visible = false;
            this.A_Nombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.A_Nombre.Lines = new string[0];
            this.A_Nombre.Location = new System.Drawing.Point(264, 76);
            this.A_Nombre.MaxLength = 32767;
            this.A_Nombre.Name = "A_Nombre";
            this.A_Nombre.PasswordChar = '\0';
            this.A_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.A_Nombre.SelectedText = "";
            this.A_Nombre.SelectionLength = 0;
            this.A_Nombre.SelectionStart = 0;
            this.A_Nombre.Size = new System.Drawing.Size(177, 23);
            this.A_Nombre.TabIndex = 4;
            this.A_Nombre.UseSelectable = true;
            this.A_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.A_Nombre.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(17, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(175, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "DATOS DE ALUMNO";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(26, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Matricula";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(26, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Apellido Paterno";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(240, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Apellido Materno";
            // 
            // A_Matricula
            // 
            // 
            // 
            // 
            this.A_Matricula.CustomButton.Image = null;
            this.A_Matricula.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.A_Matricula.CustomButton.Name = "";
            this.A_Matricula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.A_Matricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A_Matricula.CustomButton.TabIndex = 1;
            this.A_Matricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A_Matricula.CustomButton.UseSelectable = true;
            this.A_Matricula.CustomButton.Visible = false;
            this.A_Matricula.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.A_Matricula.Lines = new string[0];
            this.A_Matricula.Location = new System.Drawing.Point(50, 76);
            this.A_Matricula.MaxLength = 32767;
            this.A_Matricula.Name = "A_Matricula";
            this.A_Matricula.PasswordChar = '\0';
            this.A_Matricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.A_Matricula.SelectedText = "";
            this.A_Matricula.SelectionLength = 0;
            this.A_Matricula.SelectionStart = 0;
            this.A_Matricula.Size = new System.Drawing.Size(177, 23);
            this.A_Matricula.TabIndex = 3;
            this.A_Matricula.UseSelectable = true;
            this.A_Matricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A_Matricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.A_Matricula.TextChanged += new System.EventHandler(this.A_Matricula_TextChanged);
            this.A_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_Matricula_KeyPress);
            // 
            // A_ApellidoP
            // 
            // 
            // 
            // 
            this.A_ApellidoP.CustomButton.Image = null;
            this.A_ApellidoP.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.A_ApellidoP.CustomButton.Name = "";
            this.A_ApellidoP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.A_ApellidoP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A_ApellidoP.CustomButton.TabIndex = 1;
            this.A_ApellidoP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A_ApellidoP.CustomButton.UseSelectable = true;
            this.A_ApellidoP.CustomButton.Visible = false;
            this.A_ApellidoP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.A_ApellidoP.Lines = new string[0];
            this.A_ApellidoP.Location = new System.Drawing.Point(50, 133);
            this.A_ApellidoP.MaxLength = 32767;
            this.A_ApellidoP.Name = "A_ApellidoP";
            this.A_ApellidoP.PasswordChar = '\0';
            this.A_ApellidoP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.A_ApellidoP.SelectedText = "";
            this.A_ApellidoP.SelectionLength = 0;
            this.A_ApellidoP.SelectionStart = 0;
            this.A_ApellidoP.Size = new System.Drawing.Size(177, 23);
            this.A_ApellidoP.TabIndex = 7;
            this.A_ApellidoP.UseSelectable = true;
            this.A_ApellidoP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A_ApellidoP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.A_ApellidoP.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // A_ApellidoM
            // 
            // 
            // 
            // 
            this.A_ApellidoM.CustomButton.Image = null;
            this.A_ApellidoM.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.A_ApellidoM.CustomButton.Name = "";
            this.A_ApellidoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.A_ApellidoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A_ApellidoM.CustomButton.TabIndex = 1;
            this.A_ApellidoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A_ApellidoM.CustomButton.UseSelectable = true;
            this.A_ApellidoM.CustomButton.Visible = false;
            this.A_ApellidoM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.A_ApellidoM.Lines = new string[0];
            this.A_ApellidoM.Location = new System.Drawing.Point(264, 133);
            this.A_ApellidoM.MaxLength = 32767;
            this.A_ApellidoM.Name = "A_ApellidoM";
            this.A_ApellidoM.PasswordChar = '\0';
            this.A_ApellidoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.A_ApellidoM.SelectedText = "";
            this.A_ApellidoM.SelectionLength = 0;
            this.A_ApellidoM.SelectionStart = 0;
            this.A_ApellidoM.Size = new System.Drawing.Size(177, 23);
            this.A_ApellidoM.TabIndex = 8;
            this.A_ApellidoM.UseSelectable = true;
            this.A_ApellidoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A_ApellidoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.A_ApellidoM.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(26, 168);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Carrera";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(240, 168);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Semestre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(240, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nombre(s)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(17, 14);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 25);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "TIPO SERVICIO";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(16, 11);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(168, 25);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "PERIODO ALUMNO";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(28, 354);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(150, 25);
            this.metroLabel10.TabIndex = 4;
            this.metroLabel10.Text = "EDITAR ALUMNO";
            // 
            // Becario
            // 
            this.Becario.AutoSize = true;
            this.Becario.Checked = true;
            this.Becario.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Becario.Location = new System.Drawing.Point(37, 53);
            this.Becario.Name = "Becario";
            this.Becario.Size = new System.Drawing.Size(69, 19);
            this.Becario.TabIndex = 15;
            this.Becario.TabStop = true;
            this.Becario.Text = "Becario";
            this.Becario.UseSelectable = true;
            this.Becario.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // ServicioSocial
            // 
            this.ServicioSocial.AutoSize = true;
            this.ServicioSocial.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.ServicioSocial.Location = new System.Drawing.Point(36, 87);
            this.ServicioSocial.Name = "ServicioSocial";
            this.ServicioSocial.Size = new System.Drawing.Size(109, 19);
            this.ServicioSocial.TabIndex = 16;
            this.ServicioSocial.Text = "Servicio Social";
            this.ServicioSocial.UseSelectable = true;
            this.ServicioSocial.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // Verano
            // 
            this.Verano.AutoSize = true;
            this.Verano.Checked = true;
            this.Verano.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Verano.Location = new System.Drawing.Point(38, 50);
            this.Verano.Name = "Verano";
            this.Verano.Size = new System.Drawing.Size(106, 19);
            this.Verano.TabIndex = 17;
            this.Verano.TabStop = true;
            this.Verano.Text = "Enero - Junio";
            this.Verano.UseSelectable = true;
            this.Verano.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // Invierno
            // 
            this.Invierno.AutoSize = true;
            this.Invierno.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Invierno.Location = new System.Drawing.Point(38, 84);
            this.Invierno.Name = "Invierno";
            this.Invierno.Size = new System.Drawing.Size(144, 19);
            this.Invierno.TabIndex = 18;
            this.Invierno.Text = "Agosto - Diciembre";
            this.Invierno.UseSelectable = true;
            this.Invierno.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // Edit
            // 
            this.Edit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Edit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Edit.Location = new System.Drawing.Point(215, 389);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(124, 46);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Editar";
            this.Edit.UseSelectable = true;
            this.Edit.EnabledChanged += new System.EventHandler(this.Edit_EnabledChanged);
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DeleteStudent.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.DeleteStudent.Location = new System.Drawing.Point(37, 389);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(155, 46);
            this.DeleteStudent.TabIndex = 21;
            this.DeleteStudent.Text = "Eliminar";
            this.DeleteStudent.UseSelectable = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(28, 468);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(0, 0);
            this.metroLabel11.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Invierno);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.Verano);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(240, 225);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(201, 122);
            this.metroPanel1.TabIndex = 24;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.ServicioSocial);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.Becario);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(26, 225);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 122);
            this.metroPanel2.TabIndex = 25;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // mcMenu
            // 
            this.mcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horarioDelAlumnoToolStripMenuItem,
            this.reporteDelAlumnoToolStripMenuItem1,
            this.horasMensualesToolStripMenuItem,
            this.controlDeHorasToolStripMenuItem});
            this.mcMenu.Name = "metroContextMenu1";
            this.mcMenu.Size = new System.Drawing.Size(181, 92);
            this.mcMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mcMenu_ItemClicked);
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
            // pnlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroCarrera);
            this.Controls.Add(this.metroSemestre);
            this.Controls.Add(this.A_ApellidoM);
            this.Controls.Add(this.A_ApellidoP);
            this.Controls.Add(this.A_Matricula);
            this.Controls.Add(this.A_Nombre);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.AlumnosList);
            this.Name = "pnlData";
            this.Size = new System.Drawing.Size(775, 490);
            this.Shown += new System.EventHandler(this.pnlData_Shown);
            this.Load += new System.EventHandler(this.pnlData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosList)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.mcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid AlumnosList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private MetroFramework.Controls.MetroButton AddStudent;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroComboBox metroSemestre;
        private MetroFramework.Controls.MetroComboBox metroCarrera;
        private MetroFramework.Controls.MetroTextBox A_Nombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox A_Matricula;
        private MetroFramework.Controls.MetroTextBox A_ApellidoP;
        private MetroFramework.Controls.MetroTextBox A_ApellidoM;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroRadioButton Becario;
        private MetroFramework.Controls.MetroRadioButton ServicioSocial;
        private MetroFramework.Controls.MetroRadioButton Verano;
        private MetroFramework.Controls.MetroRadioButton Invierno;
        private MetroFramework.Controls.MetroButton Edit;
        private MetroFramework.Controls.MetroButton DeleteStudent;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroContextMenu mcMenu;
        private System.Windows.Forms.ToolStripMenuItem horarioDelAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDelAlumnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horasMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeHorasToolStripMenuItem;
    }
}
