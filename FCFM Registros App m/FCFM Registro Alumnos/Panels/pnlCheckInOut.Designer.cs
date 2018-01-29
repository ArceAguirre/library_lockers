namespace MetroPanelSlide.Panel
{
    partial class pnlCheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlCheckInOut));
            this.Hora_E = new System.Windows.Forms.DateTimePicker();
            this.Fecha_E = new MetroFramework.Controls.MetroDateTime();
            this.CheckInOut = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.Matricula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hora_E
            // 
            this.Hora_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hora_E.CustomFormat = "HH:mm";
            this.Hora_E.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_E.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hora_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Hora_E.Location = new System.Drawing.Point(260, 140);
            this.Hora_E.Name = "Hora_E";
            this.Hora_E.ShowUpDown = true;
            this.Hora_E.Size = new System.Drawing.Size(213, 33);
            this.Hora_E.TabIndex = 31;
            this.Hora_E.Value = new System.DateTime(2015, 9, 1, 0, 0, 0, 0);
            // 
            // Fecha_E
            // 
            this.Fecha_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha_E.Location = new System.Drawing.Point(260, 179);
            this.Fecha_E.MinimumSize = new System.Drawing.Size(0, 29);
            this.Fecha_E.Name = "Fecha_E";
            this.Fecha_E.Size = new System.Drawing.Size(213, 29);
            this.Fecha_E.TabIndex = 32;
            // 
            // CheckInOut
            // 
            this.CheckInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckInOut.Location = new System.Drawing.Point(304, 237);
            this.CheckInOut.Name = "CheckInOut";
            this.CheckInOut.Size = new System.Drawing.Size(136, 42);
            this.CheckInOut.TabIndex = 33;
            this.CheckInOut.Text = "Entrada";
            this.CheckInOut.UseSelectable = true;
            this.CheckInOut.Click += new System.EventHandler(this.CheckInOut_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(457, 237);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(136, 42);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseSelectable = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Matricula
            // 
            this.Matricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Matricula.CustomButton.Image = null;
            this.Matricula.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.Matricula.CustomButton.Name = "";
            this.Matricula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Matricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Matricula.CustomButton.TabIndex = 1;
            this.Matricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Matricula.CustomButton.UseSelectable = true;
            this.Matricula.CustomButton.Visible = false;
            this.Matricula.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Matricula.Lines = new string[0];
            this.Matricula.Location = new System.Drawing.Point(260, 64);
            this.Matricula.MaxLength = 32767;
            this.Matricula.Name = "Matricula";
            this.Matricula.PasswordChar = '\0';
            this.Matricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Matricula.SelectedText = "";
            this.Matricula.SelectionLength = 0;
            this.Matricula.SelectionStart = 0;
            this.Matricula.Size = new System.Drawing.Size(213, 23);
            this.Matricula.TabIndex = 34;
            this.Matricula.UseSelectable = true;
            this.Matricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Matricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Matricula.TextChanged += new System.EventHandler(this.Matricula_TextChanged);
            this.Matricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Matricula_KeyDown);
            this.Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Matricula_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(132, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Matricula";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(132, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 25);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Hora Entrada";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(132, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 25);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Fecha Entrada";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(50, 104);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 25);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "MANUAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(50, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 25);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "AUTOMATICO";
            // 
            // SName
            // 
            this.SName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SName.AutoSize = true;
            this.SName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SName.Location = new System.Drawing.Point(180, 22);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(0, 0);
            this.SName.TabIndex = 37;
            // 
            // pnlCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CheckInOut);
            this.Controls.Add(this.Fecha_E);
            this.Controls.Add(this.Hora_E);
            this.Name = "pnlCheckInOut";
            this.Size = new System.Drawing.Size(605, 290);
            this.Load += new System.EventHandler(this.pnlCheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Hora_E;
        private MetroFramework.Controls.MetroDateTime Fecha_E;
        private MetroFramework.Controls.MetroButton CheckInOut;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroTextBox Matricula;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel SName;
    }
}
