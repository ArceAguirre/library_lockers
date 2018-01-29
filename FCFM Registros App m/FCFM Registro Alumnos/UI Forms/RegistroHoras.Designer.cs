namespace FCFM_Registro_Alumnos
{
    partial class RegistroHoras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroHoras));
            this.label1 = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckInOut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Hora_E = new System.Windows.Forms.DateTimePicker();
            this.Fecha_E = new System.Windows.Forms.DateTimePicker();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.Modo_Manual = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.Label();
            this.AlumnoName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Alumno.SuspendLayout();
            this.Modo_Manual.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(74, 22);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(239, 20);
            this.Matricula.TabIndex = 1;
            this.Matricula.TextChanged += new System.EventHandler(this.Matricula_TextChanged);
            this.Matricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Matricula_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // CheckInOut
            // 
            this.CheckInOut.BackColor = System.Drawing.Color.SpringGreen;
            this.CheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckInOut.Location = new System.Drawing.Point(189, 198);
            this.CheckInOut.Name = "CheckInOut";
            this.CheckInOut.Size = new System.Drawing.Size(162, 23);
            this.CheckInOut.TabIndex = 7;
            this.CheckInOut.Text = "Entrada";
            this.CheckInOut.UseVisualStyleBackColor = false;
            this.CheckInOut.Click += new System.EventHandler(this.CheckInOut_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.NavajoWhite;
            this.button3.Location = new System.Drawing.Point(360, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-44, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha:";
            // 
            // Hora_E
            // 
            this.Hora_E.CustomFormat = "HH:mm";
            this.Hora_E.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hora_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Hora_E.Location = new System.Drawing.Point(60, 23);
            this.Hora_E.Name = "Hora_E";
            this.Hora_E.ShowUpDown = true;
            this.Hora_E.Size = new System.Drawing.Size(253, 20);
            this.Hora_E.TabIndex = 28;
            this.Hora_E.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // Fecha_E
            // 
            this.Fecha_E.CustomFormat = "HH:mm";
            this.Fecha_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Fecha_E.Location = new System.Drawing.Point(60, 49);
            this.Fecha_E.Name = "Fecha_E";
            this.Fecha_E.Size = new System.Drawing.Size(253, 20);
            this.Fecha_E.TabIndex = 29;
            this.Fecha_E.Value = new System.DateTime(2015, 9, 30, 0, 0, 0, 0);
            // 
            // Alumno
            // 
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.Controls.Add(this.Matricula);
            this.Alumno.Location = new System.Drawing.Point(189, 27);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(333, 57);
            this.Alumno.TabIndex = 30;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Alumno";
            // 
            // Modo_Manual
            // 
            this.Modo_Manual.Controls.Add(this.label3);
            this.Modo_Manual.Controls.Add(this.label5);
            this.Modo_Manual.Controls.Add(this.Hora_E);
            this.Modo_Manual.Controls.Add(this.Fecha_E);
            this.Modo_Manual.Location = new System.Drawing.Point(189, 90);
            this.Modo_Manual.Name = "Modo_Manual";
            this.Modo_Manual.Size = new System.Drawing.Size(333, 84);
            this.Modo_Manual.TabIndex = 31;
            this.Modo_Manual.TabStop = false;
            this.Modo_Manual.Text = "Modo Manual";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Enabled = false;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(12, 188);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(98, 37);
            this.Time.TabIndex = 5;
            this.Time.Text = "00:00";
            this.Time.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Location = new System.Drawing.Point(195, 181);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 0;
            // 
            // AlumnoName
            // 
            this.AlumnoName.AutoSize = true;
            this.AlumnoName.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlumnoName.ForeColor = System.Drawing.Color.Orange;
            this.AlumnoName.Location = new System.Drawing.Point(195, 9);
            this.AlumnoName.Name = "AlumnoName";
            this.AlumnoName.Size = new System.Drawing.Size(0, 15);
            this.AlumnoName.TabIndex = 32;
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(536, 234);
            this.ControlBox = false;
            this.Controls.Add(this.AlumnoName);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Modo_Manual);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CheckInOut);
            this.MaximizeBox = false;
            this.Name = "RegistroHoras";
            this.Text = "BIBLIOTECA FCFM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            this.Modo_Manual.ResumeLayout(false);
            this.Modo_Manual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckInOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Hora_E;
        private System.Windows.Forms.DateTimePicker Fecha_E;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.GroupBox Modo_Manual;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label AlumnoName;
    }
}

