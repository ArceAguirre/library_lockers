namespace FCFM_Registro_Alumnos.UI_Forms
{
    partial class Manager
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mcbServidor = new MetroFramework.Controls.MetroComboBox();
            this.mcbDB = new MetroFramework.Controls.MetroComboBox();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mctSettings = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mlRestoreName = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.mbRestore = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mbCancel = new MetroFramework.Controls.MetroButton();
            this.mbControlHoras = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.mctSettings.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(577, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 202);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(49, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Seleccione Servidor";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(49, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Seleccione Base de Datos";
            // 
            // mcbServidor
            // 
            this.mcbServidor.FormattingEnabled = true;
            this.mcbServidor.ItemHeight = 23;
            this.mcbServidor.Location = new System.Drawing.Point(270, 20);
            this.mcbServidor.Name = "mcbServidor";
            this.mcbServidor.Size = new System.Drawing.Size(190, 29);
            this.mcbServidor.TabIndex = 13;
            this.mcbServidor.UseSelectable = true;
            this.mcbServidor.SelectedIndexChanged += new System.EventHandler(this.Servidor_SelectedIndexChanged);
            // 
            // mcbDB
            // 
            this.mcbDB.FormattingEnabled = true;
            this.mcbDB.ItemHeight = 23;
            this.mcbDB.Location = new System.Drawing.Point(270, 57);
            this.mcbDB.Name = "mcbDB";
            this.mcbDB.Size = new System.Drawing.Size(190, 29);
            this.mcbDB.TabIndex = 13;
            this.mcbDB.UseSelectable = true;
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // mctSettings
            // 
            this.mctSettings.Controls.Add(this.metroTabPage1);
            this.mctSettings.Controls.Add(this.metroTabPage2);
            this.mctSettings.Location = new System.Drawing.Point(24, 64);
            this.mctSettings.Name = "mctSettings";
            this.mctSettings.SelectedIndex = 0;
            this.mctSettings.Size = new System.Drawing.Size(531, 217);
            this.mctSettings.TabIndex = 14;
            this.mctSettings.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mbSave);
            this.metroTabPage1.Controls.Add(this.mcbDB);
            this.metroTabPage1.Controls.Add(this.mcbServidor);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(523, 175);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Crear Respaldo de Base de Datos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(295, 114);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(165, 43);
            this.mbSave.TabIndex = 14;
            this.mbSave.Text = "Respaldar Base de Datos";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mlRestoreName);
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.mbRestore);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(523, 175);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Restaurar Base de Datos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mlRestoreName
            // 
            this.mlRestoreName.AutoSize = true;
            this.mlRestoreName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlRestoreName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlRestoreName.Location = new System.Drawing.Point(19, 80);
            this.mlRestoreName.Name = "mlRestoreName";
            this.mlRestoreName.Size = new System.Drawing.Size(0, 0);
            this.mlRestoreName.TabIndex = 17;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(19, 20);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(165, 43);
            this.metroButton3.TabIndex = 16;
            this.metroButton3.Text = "Seleccionar Respaldo";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // mbRestore
            // 
            this.mbRestore.Location = new System.Drawing.Point(197, 20);
            this.mbRestore.Name = "mbRestore";
            this.mbRestore.Size = new System.Drawing.Size(165, 43);
            this.mbRestore.TabIndex = 15;
            this.mbRestore.Text = "Restaurar";
            this.mbRestore.UseSelectable = true;
            this.mbRestore.Click += new System.EventHandler(this.mbRestore_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(22, 311);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(181, 29);
            this.metroLink1.TabIndex = 18;
            this.metroLink1.Text = "&Opciones de Administracion";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Location = new System.Drawing.Point(612, 297);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(165, 43);
            this.mbCancel.TabIndex = 15;
            this.mbCancel.Text = "Cancelar";
            this.mbCancel.UseSelectable = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // mbControlHoras
            // 
            this.mbControlHoras.Location = new System.Drawing.Point(430, 297);
            this.mbControlHoras.Name = "mbControlHoras";
            this.mbControlHoras.Size = new System.Drawing.Size(165, 43);
            this.mbControlHoras.TabIndex = 16;
            this.mbControlHoras.Text = "Control de Horas";
            this.mbControlHoras.UseSelectable = true;
            this.mbControlHoras.Click += new System.EventHandler(this.mbControlHoras_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.ControlBox = false;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.mctSettings);
            this.Controls.Add(this.mbControlHoras);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.richTextBox1);
            this.MinimumSize = new System.Drawing.Size(690, 265);
            this.Name = "Manager";
            this.Text = "Opciones Avanzadas";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.mctSettings.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mcbServidor;
        private MetroFramework.Controls.MetroComboBox mcbDB;
        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Controls.MetroTabControl mctSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroLabel mlRestoreName;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton mbRestore;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton mbControlHoras;
        private MetroFramework.Controls.MetroButton mbCancel;
    }
}