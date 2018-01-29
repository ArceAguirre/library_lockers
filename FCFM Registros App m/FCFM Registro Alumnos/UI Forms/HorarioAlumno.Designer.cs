using ListViewEmbeddedControls;
namespace FCFM_Registro_Alumnos
{
    partial class HorarioAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mbEliminaHorario = new MetroFramework.Controls.MetroButton();
            this.mbAgregarHorario = new MetroFramework.Controls.MetroButton();
            this.mbCancelar = new MetroFramework.Controls.MetroButton();
            this.dtpHora_E = new System.Windows.Forms.DateTimePicker();
            this.dtpHora_S = new System.Windows.Forms.DateTimePicker();
            this.mcbDia = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mgHorarios = new MetroFramework.Controls.MetroGrid();
            this.mgDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Horas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mgHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mbEliminaHorario
            // 
            this.mbEliminaHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbEliminaHorario.Location = new System.Drawing.Point(572, 248);
            this.mbEliminaHorario.Name = "mbEliminaHorario";
            this.mbEliminaHorario.Size = new System.Drawing.Size(149, 49);
            this.mbEliminaHorario.TabIndex = 34;
            this.mbEliminaHorario.Text = "Eliminar";
            this.mbEliminaHorario.UseSelectable = true;
            this.mbEliminaHorario.Click += new System.EventHandler(this.EliminaHorario_Click);
            // 
            // mbAgregarHorario
            // 
            this.mbAgregarHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbAgregarHorario.Location = new System.Drawing.Point(399, 248);
            this.mbAgregarHorario.Name = "mbAgregarHorario";
            this.mbAgregarHorario.Size = new System.Drawing.Size(149, 49);
            this.mbAgregarHorario.TabIndex = 34;
            this.mbAgregarHorario.Text = "Agregar";
            this.mbAgregarHorario.UseSelectable = true;
            this.mbAgregarHorario.Click += new System.EventHandler(this.AgregaHorario_Click);
            // 
            // mbCancelar
            // 
            this.mbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCancelar.Location = new System.Drawing.Point(573, 318);
            this.mbCancelar.Name = "mbCancelar";
            this.mbCancelar.Size = new System.Drawing.Size(149, 49);
            this.mbCancelar.TabIndex = 34;
            this.mbCancelar.Text = "Cerrar";
            this.mbCancelar.UseSelectable = true;
            this.mbCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dtpHora_E
            // 
            this.dtpHora_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHora_E.CustomFormat = "HH:mm";
            this.dtpHora_E.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_E.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_E.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora_E.Location = new System.Drawing.Point(399, 124);
            this.dtpHora_E.Name = "dtpHora_E";
            this.dtpHora_E.ShowUpDown = true;
            this.dtpHora_E.Size = new System.Drawing.Size(323, 33);
            this.dtpHora_E.TabIndex = 43;
            this.dtpHora_E.Value = new System.DateTime(2016, 1, 21, 15, 44, 26, 0);
            this.dtpHora_E.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // dtpHora_S
            // 
            this.dtpHora_S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHora_S.CustomFormat = "HH:mm";
            this.dtpHora_S.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_S.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora_S.Location = new System.Drawing.Point(399, 198);
            this.dtpHora_S.Name = "dtpHora_S";
            this.dtpHora_S.ShowUpDown = true;
            this.dtpHora_S.Size = new System.Drawing.Size(323, 33);
            this.dtpHora_S.TabIndex = 44;
            this.dtpHora_S.Value = new System.DateTime(2016, 1, 21, 15, 44, 30, 0);
            this.dtpHora_S.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // mcbDia
            // 
            this.mcbDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcbDia.FormattingEnabled = true;
            this.mcbDia.ItemHeight = 23;
            this.mcbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.mcbDia.Location = new System.Drawing.Point(399, 53);
            this.mcbDia.Name = "mcbDia";
            this.mcbDia.Size = new System.Drawing.Size(322, 29);
            this.mcbDia.TabIndex = 45;
            this.mcbDia.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(389, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 25);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Dia";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(389, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 25);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Entrada";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(389, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 25);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Salida";
            // 
            // mgHorarios
            // 
            this.mgHorarios.AllowUserToAddRows = false;
            this.mgHorarios.AllowUserToDeleteRows = false;
            this.mgHorarios.AllowUserToResizeRows = false;
            this.mgHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mgDia,
            this.mgEntrada,
            this.mgSalida});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgHorarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgHorarios.EnableHeadersVisualStyles = false;
            this.mgHorarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgHorarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgHorarios.Location = new System.Drawing.Point(21, 63);
            this.mgHorarios.Name = "mgHorarios";
            this.mgHorarios.ReadOnly = true;
            this.mgHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgHorarios.Size = new System.Drawing.Size(352, 305);
            this.mgHorarios.TabIndex = 47;
            this.mgHorarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseDown);
            // 
            // mgDia
            // 
            this.mgDia.HeaderText = "Dia";
            this.mgDia.Name = "mgDia";
            this.mgDia.ReadOnly = true;
            // 
            // mgEntrada
            // 
            this.mgEntrada.HeaderText = "Entrada";
            this.mgEntrada.Name = "mgEntrada";
            this.mgEntrada.ReadOnly = true;
            // 
            // mgSalida
            // 
            this.mgSalida.HeaderText = "Salida";
            this.mgSalida.Name = "mgSalida";
            this.mgSalida.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.Text = "Name";
            this.Horario.Width = 80;
            // 
            // Horas
            // 
            this.Horas.Text = "Horas";
            this.Horas.Width = 80;
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            // 
            // HorarioAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 393);
            this.ControlBox = false;
            this.Controls.Add(this.mgHorarios);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbDia);
            this.Controls.Add(this.dtpHora_S);
            this.Controls.Add(this.dtpHora_E);
            this.Controls.Add(this.mbCancelar);
            this.Controls.Add(this.mbAgregarHorario);
            this.Controls.Add(this.mbEliminaHorario);
            this.Name = "HorarioAlumno";
            this.Text = "Registro de Horario";
            this.Load += new System.EventHandler(this.HorarioAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Horario;
        private System.Windows.Forms.ColumnHeader Horas;
        private MetroFramework.Controls.MetroButton mbEliminaHorario;
        private MetroFramework.Controls.MetroButton mbAgregarHorario;
        private MetroFramework.Controls.MetroButton mbCancelar;
        private System.Windows.Forms.DateTimePicker dtpHora_E;
        private System.Windows.Forms.DateTimePicker dtpHora_S;
        private MetroFramework.Controls.MetroComboBox mcbDia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid mgHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgSalida;
        private MetroFramework.Components.MetroStyleManager msManager;
    }
}