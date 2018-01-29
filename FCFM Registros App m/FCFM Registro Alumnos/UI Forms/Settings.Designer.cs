namespace FCFM_Registro_Alumnos.UI_Forms
{
    partial class Settings
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
            this.AutoCorte = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HoraCorte = new System.Windows.Forms.DateTimePicker();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.Automatico = new System.Windows.Forms.RadioButton();
            this.HolyDays = new System.Windows.Forms.CheckBox();
            this.Vacations = new System.Windows.Forms.CheckBox();
            this.Actividad = new System.Windows.Forms.CheckBox();
            this.Scanner = new System.Windows.Forms.CheckBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Notificaciones = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoCorte
            // 
            this.AutoCorte.AutoSize = true;
            this.AutoCorte.Location = new System.Drawing.Point(15, 39);
            this.AutoCorte.Name = "AutoCorte";
            this.AutoCorte.Size = new System.Drawing.Size(107, 17);
            this.AutoCorte.TabIndex = 11;
            this.AutoCorte.Text = "Corte Automatico";
            this.AutoCorte.UseVisualStyleBackColor = true;
            this.AutoCorte.CheckedChanged += new System.EventHandler(this.AutoCorte_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HoraCorte);
            this.groupBox2.Controls.Add(this.Manual);
            this.groupBox2.Controls.Add(this.Automatico);
            this.groupBox2.Controls.Add(this.HolyDays);
            this.groupBox2.Controls.Add(this.Vacations);
            this.groupBox2.Controls.Add(this.AutoCorte);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de Horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hora de Corte";
            // 
            // HoraCorte
            // 
            this.HoraCorte.CustomFormat = "HH:mm";
            this.HoraCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraCorte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HoraCorte.Location = new System.Drawing.Point(125, 39);
            this.HoraCorte.Name = "HoraCorte";
            this.HoraCorte.ShowUpDown = true;
            this.HoraCorte.Size = new System.Drawing.Size(89, 20);
            this.HoraCorte.TabIndex = 29;
            this.HoraCorte.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Location = new System.Drawing.Point(15, 97);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(60, 17);
            this.Manual.TabIndex = 3;
            this.Manual.TabStop = true;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.CheckedChanged += new System.EventHandler(this.Manual_CheckedChanged);
            // 
            // Automatico
            // 
            this.Automatico.AutoSize = true;
            this.Automatico.Checked = true;
            this.Automatico.Location = new System.Drawing.Point(125, 97);
            this.Automatico.Name = "Automatico";
            this.Automatico.Size = new System.Drawing.Size(78, 17);
            this.Automatico.TabIndex = 4;
            this.Automatico.TabStop = true;
            this.Automatico.Text = "Automático";
            this.Automatico.UseVisualStyleBackColor = true;
            this.Automatico.CheckedChanged += new System.EventHandler(this.Automatico_CheckedChanged);
            // 
            // HolyDays
            // 
            this.HolyDays.AutoSize = true;
            this.HolyDays.Location = new System.Drawing.Point(125, 65);
            this.HolyDays.Name = "HolyDays";
            this.HolyDays.Size = new System.Drawing.Size(79, 17);
            this.HolyDays.TabIndex = 5;
            this.HolyDays.Text = "Dia Festivo";
            this.HolyDays.UseVisualStyleBackColor = true;
            this.HolyDays.CheckedChanged += new System.EventHandler(this.HolyDays_CheckedChanged);
            // 
            // Vacations
            // 
            this.Vacations.AutoSize = true;
            this.Vacations.Location = new System.Drawing.Point(15, 67);
            this.Vacations.Name = "Vacations";
            this.Vacations.Size = new System.Drawing.Size(82, 17);
            this.Vacations.TabIndex = 5;
            this.Vacations.Text = "Vacaciones";
            this.Vacations.UseVisualStyleBackColor = true;
            this.Vacations.CheckedChanged += new System.EventHandler(this.Vacations_CheckedChanged);
            // 
            // Actividad
            // 
            this.Actividad.AutoSize = true;
            this.Actividad.Location = new System.Drawing.Point(6, 19);
            this.Actividad.Name = "Actividad";
            this.Actividad.Size = new System.Drawing.Size(100, 17);
            this.Actividad.TabIndex = 5;
            this.Actividad.Text = "Ver Informacion";
            this.Actividad.UseVisualStyleBackColor = true;
            this.Actividad.CheckedChanged += new System.EventHandler(this.Actividad_CheckedChanged);
            // 
            // Scanner
            // 
            this.Scanner.AutoSize = true;
            this.Scanner.Location = new System.Drawing.Point(6, 67);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(65, 17);
            this.Scanner.TabIndex = 5;
            this.Scanner.Text = "Escaner";
            this.Scanner.UseVisualStyleBackColor = true;
            this.Scanner.CheckedChanged += new System.EventHandler(this.Scanner_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.NavajoWhite;
            this.Cancel.Location = new System.Drawing.Point(262, 151);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 24);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.SpringGreen;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save.Location = new System.Drawing.Point(141, 151);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(115, 24);
            this.Save.TabIndex = 13;
            this.Save.Text = "Guardar";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Notificaciones);
            this.groupBox1.Controls.Add(this.Actividad);
            this.groupBox1.Controls.Add(this.Scanner);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Generales";
            // 
            // Notificaciones
            // 
            this.Notificaciones.AutoSize = true;
            this.Notificaciones.Location = new System.Drawing.Point(6, 44);
            this.Notificaciones.Name = "Notificaciones";
            this.Notificaciones.Size = new System.Drawing.Size(112, 17);
            this.Notificaciones.TabIndex = 5;
            this.Notificaciones.Text = "Ver Notificaciones";
            this.Notificaciones.UseVisualStyleBackColor = true;
            this.Notificaciones.CheckedChanged += new System.EventHandler(this.Notificaciones_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 183);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox2);
            this.Name = "Settings";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoCorte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.RadioButton Automatico;
        private System.Windows.Forms.CheckBox HolyDays;
        private System.Windows.Forms.CheckBox Vacations;
        private System.Windows.Forms.CheckBox Actividad;
        private System.Windows.Forms.CheckBox Scanner;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HoraCorte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Notificaciones;
    }
}