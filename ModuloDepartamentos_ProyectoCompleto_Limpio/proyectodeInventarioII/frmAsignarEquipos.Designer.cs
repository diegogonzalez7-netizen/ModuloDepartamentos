namespace proyectodeInventarioII
{
    partial class frmAsignarEquipos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbEquipoAsignar = new ComboBox();
            label2 = new Label();
            cmbEmpleadoAsignar = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtObservaciones = new TextBox();
            btnAsignar = new Button();
            btnCambiar = new Button();
            btnDevolverEquipo = new Button();
            dtgHistorialDeAsignaciones = new DataGridView();
            btnSalir = new Button();
            label5 = new Label();
            dtpFechaDevolucion = new DateTimePicker();
            label6 = new Label();
            cmbEstadoEquipo = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtgHistorialDeAsignaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Equipo";
            cmbEquipoAsignar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoAsignar.FormattingEnabled = true;
            cmbEquipoAsignar.Location = new Point(169, 9);
            cmbEquipoAsignar.Name = "cmbEquipoAsignar";
            cmbEquipoAsignar.Size = new Size(151, 28);
            cmbEquipoAsignar.TabIndex = 1;
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleado";
            cmbEmpleadoAsignar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleadoAsignar.FormattingEnabled = true;
            cmbEmpleadoAsignar.Location = new Point(169, 47);
            cmbEmpleadoAsignar.Name = "cmbEmpleadoAsignar";
            cmbEmpleadoAsignar.Size = new Size(151, 28);
            cmbEmpleadoAsignar.TabIndex = 3;
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha de asignacion";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(169, 93);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 5;
            label4.AutoSize = true;
            label4.Location = new Point(12, 254);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Observaciones";
            txtObservaciones.Location = new Point(169, 240);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(125, 34);
            txtObservaciones.TabIndex = 7;
            btnAsignar.Location = new Point(11, 290);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(94, 29);
            btnAsignar.TabIndex = 8;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            btnCambiar.Location = new Point(122, 290);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(94, 29);
            btnCambiar.TabIndex = 9;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            btnDevolverEquipo.Location = new Point(247, 290);
            btnDevolverEquipo.Name = "btnDevolverEquipo";
            btnDevolverEquipo.Size = new Size(134, 29);
            btnDevolverEquipo.TabIndex = 10;
            btnDevolverEquipo.Text = "Devolver Equipo";
            btnDevolverEquipo.UseVisualStyleBackColor = true;
            btnDevolverEquipo.Click += btnDevolverEquipo_Click;
            dtgHistorialDeAsignaciones.AllowUserToAddRows = false;
            dtgHistorialDeAsignaciones.AllowUserToDeleteRows = false;
            dtgHistorialDeAsignaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgHistorialDeAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistorialDeAsignaciones.Location = new Point(2, 325);
            dtgHistorialDeAsignaciones.Name = "dtgHistorialDeAsignaciones";
            dtgHistorialDeAsignaciones.ReadOnly = true;
            dtgHistorialDeAsignaciones.RowHeadersWidth = 51;
            dtgHistorialDeAsignaciones.Size = new Size(803, 186);
            dtgHistorialDeAsignaciones.TabIndex = 11;
            btnSalir.Location = new Point(702, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            label5.AutoSize = true;
            label5.Location = new Point(18, 150);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 13;
            label5.Text = "Fecha de devolucion";
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(169, 150);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 27);
            dtpFechaDevolucion.TabIndex = 14;
            label6.AutoSize = true;
            label6.Location = new Point(18, 204);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 15;
            label6.Text = "Estado";
            cmbEstadoEquipo.FormattingEnabled = true;
            cmbEstadoEquipo.Location = new Point(169, 196);
            cmbEstadoEquipo.Name = "cmbEstadoEquipo";
            cmbEstadoEquipo.Size = new Size(151, 28);
            cmbEstadoEquipo.TabIndex = 16;
            errorProvider1.ContainerControl = this;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(808, 523);
            Controls.Add(cmbEstadoEquipo);
            Controls.Add(label6);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(dtgHistorialDeAsignaciones);
            Controls.Add(btnDevolverEquipo);
            Controls.Add(btnCambiar);
            Controls.Add(btnAsignar);
            Controls.Add(txtObservaciones);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cmbEmpleadoAsignar);
            Controls.Add(label2);
            Controls.Add(cmbEquipoAsignar);
            Controls.Add(label1);
            Name = "frmAsignarEquipos";
            Text = "Asignación de Equipos";
            Load += frmAsignarEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgHistorialDeAsignaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEquipoAsignar;
        private Label label2;
        private ComboBox cmbEmpleadoAsignar;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private TextBox txtObservaciones;
        private Button btnAsignar;
        private Button btnCambiar;
        private Button btnDevolverEquipo;
        private DataGridView dtgHistorialDeAsignaciones;
        private Button btnSalir;
        private Label label5;
        private DateTimePicker dtpFechaDevolucion;
        private Label label6;
        private ComboBox cmbEstadoEquipo;
        private ErrorProvider errorProvider1;
    }
}