namespace proyectodeInventarioII
{
    partial class frmEditarEmpleado
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(336, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el codigo del empleado que desea editar";
            label2.AutoSize = true;
            label2.Location = new Point(33, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            textBox1.Location = new Point(100, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 2;
            label3.AutoSize = true;
            label3.Location = new Point(33, 168);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Aspectos a editar:";
            btnBuscar.Location = new Point(33, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            textBox2.Location = new Point(117, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 5;
            label4.AutoSize = true;
            label4.Location = new Point(44, 202);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre:";
            label5.AutoSize = true;
            label5.Location = new Point(42, 249);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 7;
            label5.Text = "Apellido:";
            textBox3.Location = new Point(119, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 8;
            label6.AutoSize = true;
            label6.Location = new Point(44, 292);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 9;
            label6.Text = "Cargo:";
            label7.AutoSize = true;
            label7.Location = new Point(33, 336);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 10;
            label7.Text = "Departamento:";
            textBox4.Location = new Point(119, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 27);
            textBox4.TabIndex = 11;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 12;
            btnGuardar.Location = new Point(88, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnSalir.Location = new Point(288, 450);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(394, 491);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarEmpleado";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button btnBuscar;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button btnGuardar;
        private Button btnSalir;
    }
}