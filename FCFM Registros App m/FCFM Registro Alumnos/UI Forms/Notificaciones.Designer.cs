namespace FCFM_Registro_Alumnos.UI_Forms
{
    partial class Notificaciones
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
            this.EliminaTodos = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.EliminarNotificacion = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.NotificationsList = new ListViewManager.ListViewManager();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Entrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Hora_S = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliminaTodos
            // 
            this.EliminaTodos.BackColor = System.Drawing.Color.PeachPuff;
            this.EliminaTodos.Location = new System.Drawing.Point(8, 55);
            this.EliminaTodos.Name = "EliminaTodos";
            this.EliminaTodos.Size = new System.Drawing.Size(192, 30);
            this.EliminaTodos.TabIndex = 36;
            this.EliminaTodos.Text = "Eliminar Todos";
            this.EliminaTodos.UseVisualStyleBackColor = false;
            this.EliminaTodos.Click += new System.EventHandler(this.EliminaHorario_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Editar.Enabled = false;
            this.Editar.Location = new System.Drawing.Point(12, 63);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(192, 30);
            this.Editar.TabIndex = 35;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // EliminarNotificacion
            // 
            this.EliminarNotificacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EliminarNotificacion.Enabled = false;
            this.EliminarNotificacion.Location = new System.Drawing.Point(8, 19);
            this.EliminarNotificacion.Name = "EliminarNotificacion";
            this.EliminarNotificacion.Size = new System.Drawing.Size(192, 30);
            this.EliminarNotificacion.TabIndex = 35;
            this.EliminarNotificacion.Text = "Eliminar";
            this.EliminarNotificacion.UseVisualStyleBackColor = false;
            this.EliminarNotificacion.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancelar.Location = new System.Drawing.Point(8, 91);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(192, 30);
            this.Cancelar.TabIndex = 35;
            this.Cancelar.Text = "Cerrar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // NotificationsList
            // 
            this.NotificationsList.AllowColumnReorder = true;
            this.NotificationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Matricula,
            this.Entrada,
            this.Salida});
            this.NotificationsList.FullRowSelect = true;
            this.NotificationsList.HideSelection = false;
            this.NotificationsList.Location = new System.Drawing.Point(12, 12);
            this.NotificationsList.Name = "NotificationsList";
            this.NotificationsList.Size = new System.Drawing.Size(341, 322);
            this.NotificationsList.TabIndex = 34;
            this.NotificationsList.UseCompatibleStateImageBehavior = false;
            this.NotificationsList.SelectedIndexChanged += new System.EventHandler(this.NotificationsList_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 80;
            // 
            // Matricula
            // 
            this.Matricula.Text = "Matricula";
            // 
            // Entrada
            // 
            this.Entrada.Text = "Entrada";
            this.Entrada.Width = 80;
            // 
            // Salida
            // 
            this.Salida.Text = "Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Salida";
            // 
            // Hora_S
            // 
            this.Hora_S.CustomFormat = "HH:mm";
            this.Hora_S.Enabled = false;
            this.Hora_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hora_S.Location = new System.Drawing.Point(12, 37);
            this.Hora_S.Name = "Hora_S";
            this.Hora_S.ShowUpDown = true;
            this.Hora_S.Size = new System.Drawing.Size(192, 20);
            this.Hora_S.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Hora_S);
            this.groupBox1.Controls.Add(this.Editar);
            this.groupBox1.Location = new System.Drawing.Point(359, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 187);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edicion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EliminarNotificacion);
            this.groupBox2.Controls.Add(this.Cancelar);
            this.groupBox2.Controls.Add(this.EliminaTodos);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 129);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(578, 349);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NotificationsList);
            //this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.Notificaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListViewManager.ListViewManager NotificationsList;
        //private ListViewEmbeddedControls.ListViewEx NotificationsList;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Entrada;
        private System.Windows.Forms.Button EliminaTodos;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button EliminarNotificacion;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ColumnHeader Matricula;
        private System.Windows.Forms.ColumnHeader Salida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Hora_S;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}