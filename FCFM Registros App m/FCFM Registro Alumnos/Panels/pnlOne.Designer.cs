namespace MetroPanelSlide.Panel
{
    partial class pnlOne
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
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(143, 111);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 0;
            this.metroToggle1.Text = "On";
            this.metroToggle1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(131, 68);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(195, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(108, 39);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(218, 23);
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Value = 50;
            // 
            // pnlOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroToggle1);
            this.Name = "pnlOne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;

    }
}
