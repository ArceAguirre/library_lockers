namespace FCFM_Registro_Alumnos
{
    partial class AltaAlumno
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
            this.AddStudent = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A_Matricula = new System.Windows.Forms.TextBox();
            this.A_Nombre = new System.Windows.Forms.TextBox();
            this.A_ApellidoP = new System.Windows.Forms.TextBox();
            this.A_ApellidoM = new System.Windows.Forms.TextBox();
            this.Becario = new System.Windows.Forms.RadioButton();
            this.ServicioSocial = new System.Windows.Forms.RadioButton();
            this.Verano = new System.Windows.Forms.RadioButton();
            this.Invierno = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Carrera = new System.Windows.Forms.ComboBox();
            this.Semestre = new System.Windows.Forms.ComboBox();
            this.DatosPersonales = new System.Windows.Forms.GroupBox();
            this.Servicio = new System.Windows.Forms.GroupBox();
            this.PeriodoAlumno = new System.Windows.Forms.GroupBox();
            this.EditarDatos = new System.Windows.Forms.GroupBox();
            this.StateText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AlumnosList = new ListViewManager.ListViewManager();
            this.Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Carrera1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semestre1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Periodo1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo_Servicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatosPersonales.SuspendLayout();
            this.Servicio.SuspendLayout();
            this.PeriodoAlumno.SuspendLayout();
            this.EditarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddStudent.Location = new System.Drawing.Point(58, 304);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(104, 23);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.Text = "Agregar";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancel.Location = new System.Drawing.Point(174, 304);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.PeachPuff;
            this.DeleteStudent.Location = new System.Drawing.Point(17, 49);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(115, 23);
            this.DeleteStudent.TabIndex = 2;
            this.DeleteStudent.Text = "Eliminar";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Materno";
            // 
            // A_Matricula
            // 
            this.A_Matricula.Location = new System.Drawing.Point(103, 27);
            this.A_Matricula.Name = "A_Matricula";
            this.A_Matricula.Size = new System.Drawing.Size(134, 20);
            this.A_Matricula.TabIndex = 7;
            this.A_Matricula.TextChanged += new System.EventHandler(this.A_Matricula_TextChanged);
            this.A_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_Matricula_KeyPress);
            // 
            // A_Nombre
            // 
            this.A_Nombre.Location = new System.Drawing.Point(103, 57);
            this.A_Nombre.Name = "A_Nombre";
            this.A_Nombre.Size = new System.Drawing.Size(134, 20);
            this.A_Nombre.TabIndex = 8;
            this.A_Nombre.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // A_ApellidoP
            // 
            this.A_ApellidoP.Location = new System.Drawing.Point(103, 87);
            this.A_ApellidoP.Name = "A_ApellidoP";
            this.A_ApellidoP.Size = new System.Drawing.Size(134, 20);
            this.A_ApellidoP.TabIndex = 9;
            this.A_ApellidoP.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // A_ApellidoM
            // 
            this.A_ApellidoM.Location = new System.Drawing.Point(103, 117);
            this.A_ApellidoM.Name = "A_ApellidoM";
            this.A_ApellidoM.Size = new System.Drawing.Size(134, 20);
            this.A_ApellidoM.TabIndex = 10;
            this.A_ApellidoM.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // Becario
            // 
            this.Becario.AutoSize = true;
            this.Becario.Checked = true;
            this.Becario.Location = new System.Drawing.Point(17, 19);
            this.Becario.Name = "Becario";
            this.Becario.Size = new System.Drawing.Size(61, 17);
            this.Becario.TabIndex = 12;
            this.Becario.TabStop = true;
            this.Becario.Text = "Becario";
            this.Becario.UseVisualStyleBackColor = true;
            // 
            // ServicioSocial
            // 
            this.ServicioSocial.AutoSize = true;
            this.ServicioSocial.Location = new System.Drawing.Point(17, 42);
            this.ServicioSocial.Name = "ServicioSocial";
            this.ServicioSocial.Size = new System.Drawing.Size(98, 17);
            this.ServicioSocial.TabIndex = 13;
            this.ServicioSocial.TabStop = true;
            this.ServicioSocial.Text = " Servicio Social";
            this.ServicioSocial.UseVisualStyleBackColor = true;
            // 
            // Verano
            // 
            this.Verano.AutoSize = true;
            this.Verano.Checked = true;
            this.Verano.Location = new System.Drawing.Point(17, 21);
            this.Verano.Name = "Verano";
            this.Verano.Size = new System.Drawing.Size(81, 17);
            this.Verano.TabIndex = 15;
            this.Verano.TabStop = true;
            this.Verano.Text = "Enero-Junio";
            this.Verano.UseVisualStyleBackColor = true;
            // 
            // Invierno
            // 
            this.Invierno.AutoSize = true;
            this.Invierno.Location = new System.Drawing.Point(17, 44);
            this.Invierno.Name = "Invierno";
            this.Invierno.Size = new System.Drawing.Size(108, 17);
            this.Invierno.TabIndex = 16;
            this.Invierno.TabStop = true;
            this.Invierno.Text = "Agosto-Diciembre";
            this.Invierno.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Semestre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Carrera";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Edit.Location = new System.Drawing.Point(17, 20);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 23);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Editar";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.EnabledChanged += new System.EventHandler(this.Edit_EnabledChanged);
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Carrera
            // 
            this.Carrera.FormattingEnabled = true;
            this.Carrera.Items.AddRange(new object[] {
            "LA",
            "LF",
            "LM",
            "LMAD",
            "LCC",
            "LSTI",
            "POST",
            "TECNICA"});
            this.Carrera.Location = new System.Drawing.Point(103, 146);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(134, 21);
            this.Carrera.TabIndex = 28;
            this.Carrera.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // Semestre
            // 
            this.Semestre.FormattingEnabled = true;
            this.Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Semestre.Location = new System.Drawing.Point(103, 177);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(134, 21);
            this.Semestre.TabIndex = 29;
            this.Semestre.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Controls.Add(this.label1);
            this.DatosPersonales.Controls.Add(this.Semestre);
            this.DatosPersonales.Controls.Add(this.label2);
            this.DatosPersonales.Controls.Add(this.Carrera);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.A_Matricula);
            this.DatosPersonales.Controls.Add(this.A_Nombre);
            this.DatosPersonales.Controls.Add(this.A_ApellidoP);
            this.DatosPersonales.Controls.Add(this.A_ApellidoM);
            this.DatosPersonales.Controls.Add(this.label8);
            this.DatosPersonales.Controls.Add(this.label7);
            this.DatosPersonales.Location = new System.Drawing.Point(47, 77);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(243, 221);
            this.DatosPersonales.TabIndex = 30;
            this.DatosPersonales.TabStop = false;
            this.DatosPersonales.Text = "Datos Personales";
            // 
            // Servicio
            // 
            this.Servicio.Controls.Add(this.Becario);
            this.Servicio.Controls.Add(this.ServicioSocial);
            this.Servicio.Location = new System.Drawing.Point(296, 77);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(145, 70);
            this.Servicio.TabIndex = 31;
            this.Servicio.TabStop = false;
            this.Servicio.Text = "Tipo de Servicio";
            // 
            // PeriodoAlumno
            // 
            this.PeriodoAlumno.Controls.Add(this.Verano);
            this.PeriodoAlumno.Controls.Add(this.Invierno);
            this.PeriodoAlumno.Location = new System.Drawing.Point(296, 153);
            this.PeriodoAlumno.Name = "PeriodoAlumno";
            this.PeriodoAlumno.Size = new System.Drawing.Size(145, 70);
            this.PeriodoAlumno.TabIndex = 32;
            this.PeriodoAlumno.TabStop = false;
            this.PeriodoAlumno.Text = "Periodo Alumno";
            // 
            // EditarDatos
            // 
            this.EditarDatos.Controls.Add(this.Edit);
            this.EditarDatos.Controls.Add(this.DeleteStudent);
            this.EditarDatos.Location = new System.Drawing.Point(296, 229);
            this.EditarDatos.Name = "EditarDatos";
            this.EditarDatos.Size = new System.Drawing.Size(145, 81);
            this.EditarDatos.TabIndex = 33;
            this.EditarDatos.TabStop = false;
            this.EditarDatos.Text = "Editar Alumno";
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.ForeColor = System.Drawing.Color.Red;
            this.StateText.Location = new System.Drawing.Point(290, 316);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(0, 13);
            this.StateText.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlumnosList
            // 
            this.AlumnosList.AllowColumnReorder = true;
            this.AlumnosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricula,
            this.Nombre,
            this.Carrera1,
            this.Semestre1,
            this.Periodo1,
            this.Tipo_Servicio});
            this.AlumnosList.FullRowSelect = true;
            this.AlumnosList.HideSelection = false;
            this.AlumnosList.Location = new System.Drawing.Point(456, 77);
            this.AlumnosList.Name = "AlumnosList";
            this.AlumnosList.Size = new System.Drawing.Size(362, 249);
            this.AlumnosList.TabIndex = 35;
            this.AlumnosList.UseCompatibleStateImageBehavior = false;
            this.AlumnosList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.AlumnosList_ItemSelectionChanged);
            // 
            // Matricula
            // 
            this.Matricula.Text = "Matricula";
            this.Matricula.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 80;
            // 
            // Carrera1
            // 
            this.Carrera1.Text = "Carrera";
            // 
            // Semestre1
            // 
            this.Semestre1.Text = "Semestre";
            // 
            // Periodo1
            // 
            this.Periodo1.Text = "Periodo";
            // 
            // Tipo_Servicio
            // 
            this.Tipo_Servicio.Text = "Tipo Servicio";
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 403);
            this.ControlBox = false;
            this.Controls.Add(this.AlumnosList);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.EditarDatos);
            this.Controls.Add(this.PeriodoAlumno);
            this.Controls.Add(this.Servicio);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddStudent);
            this.Name = "AltaAlumno";
            this.Text = "Datos Generales";
            this.Load += new System.EventHandler(this.AltaAlumno_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.Servicio.ResumeLayout(false);
            this.Servicio.PerformLayout();
            this.PeriodoAlumno.ResumeLayout(false);
            this.PeriodoAlumno.PerformLayout();
            this.EditarDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A_Matricula;
        private System.Windows.Forms.TextBox A_Nombre;
        private System.Windows.Forms.TextBox A_ApellidoP;
        private System.Windows.Forms.TextBox A_ApellidoM;
        private System.Windows.Forms.RadioButton Becario;
        private System.Windows.Forms.RadioButton ServicioSocial;
        private System.Windows.Forms.RadioButton Verano;
        private System.Windows.Forms.RadioButton Invierno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox Carrera;
        private System.Windows.Forms.ComboBox Semestre;
        private System.Windows.Forms.GroupBox DatosPersonales;
        private System.Windows.Forms.GroupBox Servicio;
        private System.Windows.Forms.GroupBox PeriodoAlumno;
        private System.Windows.Forms.GroupBox EditarDatos;
        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.Timer timer1;
        private ListViewManager.ListViewManager AlumnosList;
        private System.Windows.Forms.ColumnHeader Matricula;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Carrera1;
        private System.Windows.Forms.ColumnHeader Semestre1;
        private System.Windows.Forms.ColumnHeader Periodo1;
        private System.Windows.Forms.ColumnHeader Tipo_Servicio;
    }
}