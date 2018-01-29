namespace FCFM_Registro_Alumnos
{
    partial class RptHoras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Registro_horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FCFM_Registro_Alumnos.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Registro_horasTableAdapter = new FCFM_Registro_Alumnos.DataSet1TableAdapters.Registro_horasTableAdapter();
            this.mbFiltrar = new MetroFramework.Controls.MetroButton();
            this.mtbMatricula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Registro_horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro_horasBindingSource
            // 
            this.Registro_horasBindingSource.DataMember = "Registro_horas";
            this.Registro_horasBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.EnforceConstraints = false;
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Registro_horasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FCFM_Registro_Alumnos.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1112, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // Registro_horasTableAdapter
            // 
            this.Registro_horasTableAdapter.ClearBeforeFill = true;
            // 
            // mbFiltrar
            // 
            this.mbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbFiltrar.Location = new System.Drawing.Point(1013, 47);
            this.mbFiltrar.Name = "mbFiltrar";
            this.mbFiltrar.Size = new System.Drawing.Size(113, 47);
            this.mbFiltrar.TabIndex = 4;
            this.mbFiltrar.Text = "Filtrar";
            this.mbFiltrar.UseSelectable = true;
            this.mbFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbMatricula
            // 
            this.mtbMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbMatricula.CustomButton.Image = null;
            this.mtbMatricula.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.mtbMatricula.CustomButton.Name = "";
            this.mtbMatricula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbMatricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbMatricula.CustomButton.TabIndex = 1;
            this.mtbMatricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbMatricula.CustomButton.UseSelectable = true;
            this.mtbMatricula.CustomButton.Visible = false;
            this.mtbMatricula.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtbMatricula.Lines = new string[0];
            this.mtbMatricula.Location = new System.Drawing.Point(807, 59);
            this.mtbMatricula.MaxLength = 32767;
            this.mtbMatricula.Name = "mtbMatricula";
            this.mtbMatricula.PasswordChar = '\0';
            this.mtbMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbMatricula.SelectedText = "";
            this.mtbMatricula.SelectionLength = 0;
            this.mtbMatricula.SelectionStart = 0;
            this.mtbMatricula.Size = new System.Drawing.Size(189, 23);
            this.mtbMatricula.TabIndex = 5;
            this.mtbMatricula.UseSelectable = true;
            this.mtbMatricula.WaterMark = "1234567";
            this.mtbMatricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbMatricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.mtbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(717, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Matricula";
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // RptHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 542);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbMatricula);
            this.Controls.Add(this.mbFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptHoras";
            this.Text = "Reporte de Horas";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registro_horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Registro_horasBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Registro_horasTableAdapter Registro_horasTableAdapter;
        private MetroFramework.Controls.MetroButton mbFiltrar;
        private MetroFramework.Controls.MetroTextBox mtbMatricula;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager msManager;
    }
}