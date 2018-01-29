namespace FCFM_Registro_Alumnos
{
    partial class RptHorasTotales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptHorasTotales));
            this.alumnos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FCFM_Registro_Alumnos.DataSet1();
            this.Registro_horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Registro_horasTableAdapter = new FCFM_Registro_Alumnos.DataSet1TableAdapters.Registro_horasTableAdapter();
            this.alumnos1TableAdapter = new FCFM_Registro_Alumnos.DataSet1TableAdapters.alumnos1TableAdapter();
            this.mbFiltrar = new MetroFramework.Controls.MetroButton();
            this.mdtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.mdtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alumnos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnos1BindingSource
            // 
            this.alumnos1BindingSource.DataMember = "alumnos1";
            this.alumnos1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.EnforceConstraints = false;
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registro_horasBindingSource
            // 
            this.Registro_horasBindingSource.DataMember = "Registro_horas";
            this.Registro_horasBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alumnos1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FCFM_Registro_Alumnos.Reports.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // Registro_horasTableAdapter
            // 
            this.Registro_horasTableAdapter.ClearBeforeFill = true;
            // 
            // alumnos1TableAdapter
            // 
            this.alumnos1TableAdapter.ClearBeforeFill = true;
            // 
            // mbFiltrar
            // 
            this.mbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbFiltrar.Location = new System.Drawing.Point(947, 53);
            this.mbFiltrar.Name = "mbFiltrar";
            this.mbFiltrar.Size = new System.Drawing.Size(127, 45);
            this.mbFiltrar.TabIndex = 22;
            this.mbFiltrar.Text = "Filtrar";
            this.mbFiltrar.UseSelectable = true;
            this.mbFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdtEndDate
            // 
            this.mdtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mdtEndDate.Location = new System.Drawing.Point(720, 69);
            this.mdtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtEndDate.Name = "mdtEndDate";
            this.mdtEndDate.Size = new System.Drawing.Size(200, 29);
            this.mdtEndDate.TabIndex = 23;
            // 
            // mdtStartDate
            // 
            this.mdtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mdtStartDate.Location = new System.Drawing.Point(491, 70);
            this.mdtStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtStartDate.Name = "mdtStartDate";
            this.mdtStartDate.Size = new System.Drawing.Size(200, 29);
            this.mdtStartDate.TabIndex = 23;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(469, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Fecha Inicio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(703, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 25);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Fecha Fin";
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // RptHorasTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 541);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mdtStartDate);
            this.Controls.Add(this.mdtEndDate);
            this.Controls.Add(this.mbFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptHorasTotales";
            this.Text = "Bibllioteca FCFM";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Registro_horasBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Registro_horasTableAdapter Registro_horasTableAdapter;
        private System.Windows.Forms.BindingSource alumnos1BindingSource;
        private DataSet1TableAdapters.alumnos1TableAdapter alumnos1TableAdapter;
        private MetroFramework.Controls.MetroButton mbFiltrar;
        private MetroFramework.Controls.MetroDateTime mdtEndDate;
        private MetroFramework.Controls.MetroDateTime mdtStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager msManager;
    }
}