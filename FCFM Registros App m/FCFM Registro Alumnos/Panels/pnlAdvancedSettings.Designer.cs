namespace MetroPanelSlide.Panel
{
    partial class pnlAdvancedSettings
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
            this.CreateDB = new MetroFramework.Controls.MetroButton();
            this.CreateTables = new MetroFramework.Controls.MetroButton();
            this.DeleteRows = new MetroFramework.Controls.MetroButton();
            this.DeleteDB = new MetroFramework.Controls.MetroButton();
            this.Agregar = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.mtbName = new MetroFramework.Controls.MetroTextBox();
            this.mtbPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mpAddManager = new MetroFramework.Controls.MetroPanel();
            this.mpDelete = new MetroFramework.Controls.MetroPanel();
            this.mpCreate = new MetroFramework.Controls.MetroPanel();
            this.mpAddManager.SuspendLayout();
            this.mpDelete.SuspendLayout();
            this.mpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDB
            // 
            this.CreateDB.Location = new System.Drawing.Point(27, 11);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(165, 43);
            this.CreateDB.TabIndex = 0;
            this.CreateDB.Text = "Crear Base de Datos";
            this.CreateDB.UseSelectable = true;
            this.CreateDB.EnabledChanged += new System.EventHandler(this.CreateDB_EnabledChanged);
            this.CreateDB.Click += new System.EventHandler(this.CreateDB_Click);
            // 
            // CreateTables
            // 
            this.CreateTables.Location = new System.Drawing.Point(211, 11);
            this.CreateTables.Name = "CreateTables";
            this.CreateTables.Size = new System.Drawing.Size(165, 43);
            this.CreateTables.TabIndex = 0;
            this.CreateTables.Text = "Crear Tablas";
            this.CreateTables.UseSelectable = true;
            this.CreateTables.EnabledChanged += new System.EventHandler(this.CreateTables_EnabledChanged);
            this.CreateTables.Click += new System.EventHandler(this.CreateTables_Click);
            // 
            // DeleteRows
            // 
            this.DeleteRows.Location = new System.Drawing.Point(27, 10);
            this.DeleteRows.Name = "DeleteRows";
            this.DeleteRows.Size = new System.Drawing.Size(165, 43);
            this.DeleteRows.TabIndex = 0;
            this.DeleteRows.Text = "Eliminar Registros";
            this.DeleteRows.UseSelectable = true;
            this.DeleteRows.Click += new System.EventHandler(this.DeleteRows_Click);
            // 
            // DeleteDB
            // 
            this.DeleteDB.Location = new System.Drawing.Point(211, 10);
            this.DeleteDB.Name = "DeleteDB";
            this.DeleteDB.Size = new System.Drawing.Size(165, 43);
            this.DeleteDB.TabIndex = 0;
            this.DeleteDB.Text = "Eliminar Base de Datos";
            this.DeleteDB.UseSelectable = true;
            this.DeleteDB.Click += new System.EventHandler(this.DeleteDB_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(61, 163);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(165, 43);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseSelectable = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(485, 262);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(165, 43);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseSelectable = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // mtbName
            // 
            this.mtbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbName.CustomButton.Image = null;
            this.mtbName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.mtbName.CustomButton.Name = "";
            this.mtbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbName.CustomButton.TabIndex = 1;
            this.mtbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbName.CustomButton.UseSelectable = true;
            this.mtbName.CustomButton.Visible = false;
            this.mtbName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbName.Lines = new string[0];
            this.mtbName.Location = new System.Drawing.Point(60, 42);
            this.mtbName.MaxLength = 32767;
            this.mtbName.Name = "mtbName";
            this.mtbName.PasswordChar = '\0';
            this.mtbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbName.SelectedText = "";
            this.mtbName.SelectionLength = 0;
            this.mtbName.SelectionStart = 0;
            this.mtbName.Size = new System.Drawing.Size(170, 23);
            this.mtbName.TabIndex = 1;
            this.mtbName.UseSelectable = true;
            this.mtbName.WaterMark = "Agrega Nombre";
            this.mtbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbPass
            // 
            this.mtbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbPass.CustomButton.Image = null;
            this.mtbPass.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.mtbPass.CustomButton.Name = "";
            this.mtbPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPass.CustomButton.TabIndex = 1;
            this.mtbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPass.CustomButton.UseSelectable = true;
            this.mtbPass.CustomButton.Visible = false;
            this.mtbPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbPass.Lines = new string[0];
            this.mtbPass.Location = new System.Drawing.Point(60, 105);
            this.mtbPass.MaxLength = 32767;
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '\0';
            this.mtbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPass.SelectedText = "";
            this.mtbPass.SelectionLength = 0;
            this.mtbPass.SelectionStart = 0;
            this.mtbPass.Size = new System.Drawing.Size(170, 23);
            this.mtbPass.TabIndex = 1;
            this.mtbPass.UseSelectable = true;
            this.mtbPass.WaterMark = "Clave";
            this.mtbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Clave";
            // 
            // mpAddManager
            // 
            this.mpAddManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpAddManager.BackColor = System.Drawing.Color.Transparent;
            this.mpAddManager.Controls.Add(this.metroLabel2);
            this.mpAddManager.Controls.Add(this.metroLabel1);
            this.mpAddManager.Controls.Add(this.mtbPass);
            this.mpAddManager.Controls.Add(this.Agregar);
            this.mpAddManager.Controls.Add(this.mtbName);
            this.mpAddManager.HorizontalScrollbarBarColor = true;
            this.mpAddManager.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAddManager.HorizontalScrollbarSize = 10;
            this.mpAddManager.Location = new System.Drawing.Point(3, 3);
            this.mpAddManager.Name = "mpAddManager";
            this.mpAddManager.Size = new System.Drawing.Size(247, 239);
            this.mpAddManager.TabIndex = 3;
            this.mpAddManager.VerticalScrollbarBarColor = true;
            this.mpAddManager.VerticalScrollbarHighlightOnWheel = false;
            this.mpAddManager.VerticalScrollbarSize = 10;
            // 
            // mpDelete
            // 
            this.mpDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mpDelete.BackColor = System.Drawing.Color.Transparent;
            this.mpDelete.Controls.Add(this.DeleteRows);
            this.mpDelete.Controls.Add(this.DeleteDB);
            this.mpDelete.HorizontalScrollbarBarColor = true;
            this.mpDelete.HorizontalScrollbarHighlightOnWheel = false;
            this.mpDelete.HorizontalScrollbarSize = 10;
            this.mpDelete.Location = new System.Drawing.Point(274, 82);
            this.mpDelete.Name = "mpDelete";
            this.mpDelete.Size = new System.Drawing.Size(397, 67);
            this.mpDelete.TabIndex = 4;
            this.mpDelete.VerticalScrollbarBarColor = true;
            this.mpDelete.VerticalScrollbarHighlightOnWheel = false;
            this.mpDelete.VerticalScrollbarSize = 10;
            // 
            // mpCreate
            // 
            this.mpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mpCreate.Controls.Add(this.CreateDB);
            this.mpCreate.Controls.Add(this.CreateTables);
            this.mpCreate.HorizontalScrollbarBarColor = true;
            this.mpCreate.HorizontalScrollbarHighlightOnWheel = false;
            this.mpCreate.HorizontalScrollbarSize = 10;
            this.mpCreate.Location = new System.Drawing.Point(274, 9);
            this.mpCreate.Name = "mpCreate";
            this.mpCreate.Size = new System.Drawing.Size(397, 67);
            this.mpCreate.TabIndex = 5;
            this.mpCreate.VerticalScrollbarBarColor = true;
            this.mpCreate.VerticalScrollbarHighlightOnWheel = false;
            this.mpCreate.VerticalScrollbarSize = 10;
            // 
            // pnlAdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpCreate);
            this.Controls.Add(this.mpDelete);
            this.Controls.Add(this.mpAddManager);
            this.Controls.Add(this.Cancel);
            this.Name = "pnlAdvancedSettings";
            this.Size = new System.Drawing.Size(674, 324);
            this.Load += new System.EventHandler(this.pnlAdvancedSettings_Load);
            this.mpAddManager.ResumeLayout(false);
            this.mpAddManager.PerformLayout();
            this.mpDelete.ResumeLayout(false);
            this.mpCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton CreateDB;
        private MetroFramework.Controls.MetroButton CreateTables;
        private MetroFramework.Controls.MetroButton DeleteRows;
        private MetroFramework.Controls.MetroButton DeleteDB;
        private MetroFramework.Controls.MetroButton Agregar;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroTextBox mtbName;
        private MetroFramework.Controls.MetroTextBox mtbPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel mpAddManager;
        private MetroFramework.Controls.MetroPanel mpDelete;
        private MetroFramework.Controls.MetroPanel mpCreate;
    }
}
