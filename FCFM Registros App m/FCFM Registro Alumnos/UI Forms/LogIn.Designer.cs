namespace FCFM_Registro_Alumnos.UI_Forms
{
    partial class LogIn
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
            this.metroAceptar = new MetroFramework.Controls.MetroButton();
            this.metroCancelar = new MetroFramework.Controls.MetroButton();
            this.metroName = new MetroFramework.Controls.MetroTextBox();
            this.metroPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mttHelp = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroAceptar
            // 
            this.metroAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroAceptar.Location = new System.Drawing.Point(45, 184);
            this.metroAceptar.Name = "metroAceptar";
            this.metroAceptar.Size = new System.Drawing.Size(203, 47);
            this.metroAceptar.TabIndex = 4;
            this.metroAceptar.Text = "Aceptar";
            this.metroAceptar.UseSelectable = true;
            this.metroAceptar.Click += new System.EventHandler(this.metroAceptar_Click);
            // 
            // metroCancelar
            // 
            this.metroCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCancelar.Location = new System.Drawing.Point(280, 184);
            this.metroCancelar.Name = "metroCancelar";
            this.metroCancelar.Size = new System.Drawing.Size(203, 47);
            this.metroCancelar.TabIndex = 5;
            this.metroCancelar.Text = "Cancelar";
            this.metroCancelar.UseSelectable = true;
            this.metroCancelar.Click += new System.EventHandler(this.metroCancelar_Click);
            // 
            // metroName
            // 
            this.metroName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroName.CustomButton.Image = null;
            this.metroName.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.metroName.CustomButton.Name = "";
            this.metroName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroName.CustomButton.TabIndex = 1;
            this.metroName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroName.CustomButton.UseSelectable = true;
            this.metroName.CustomButton.Visible = false;
            this.metroName.Lines = new string[0];
            this.metroName.Location = new System.Drawing.Point(45, 83);
            this.metroName.MaxLength = 32767;
            this.metroName.Name = "metroName";
            this.metroName.PasswordChar = '\0';
            this.metroName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroName.SelectedText = "";
            this.metroName.SelectionLength = 0;
            this.metroName.SelectionStart = 0;
            this.metroName.Size = new System.Drawing.Size(438, 23);
            this.metroName.TabIndex = 1;
            this.metroName.UseSelectable = true;
            this.metroName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPass
            // 
            this.metroPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroPass.CustomButton.Image = null;
            this.metroPass.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.metroPass.CustomButton.Name = "";
            this.metroPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPass.CustomButton.TabIndex = 1;
            this.metroPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPass.CustomButton.UseSelectable = true;
            this.metroPass.CustomButton.Visible = false;
            this.metroPass.Lines = new string[0];
            this.metroPass.Location = new System.Drawing.Point(45, 139);
            this.metroPass.MaxLength = 32767;
            this.metroPass.Name = "metroPass";
            this.metroPass.PasswordChar = '*';
            this.metroPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroPass.SelectedText = "";
            this.metroPass.SelectionLength = 0;
            this.metroPass.SelectionStart = 0;
            this.metroPass.Size = new System.Drawing.Size(438, 23);
            this.metroPass.TabIndex = 3;
            this.metroPass.UseSelectable = true;
            this.metroPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre de Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Clave";
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // mttHelp
            // 
            this.mttHelp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttHelp.StyleManager = null;
            this.mttHelp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPass);
            this.Controls.Add(this.metroName);
            this.Controls.Add(this.metroCancelar);
            this.Controls.Add(this.metroAceptar);
            this.MaximumSize = new System.Drawing.Size(533, 273);
            this.MinimumSize = new System.Drawing.Size(533, 273);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroAceptar;
        private MetroFramework.Controls.MetroButton metroCancelar;
        private MetroFramework.Controls.MetroTextBox metroName;
        private MetroFramework.Controls.MetroTextBox metroPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Components.MetroToolTip mttHelp;

    }
}