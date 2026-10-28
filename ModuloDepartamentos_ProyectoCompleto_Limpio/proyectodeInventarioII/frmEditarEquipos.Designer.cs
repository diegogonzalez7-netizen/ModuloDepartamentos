namespace proyectodeInventarioII
{
    partial class frmEditarEquipos
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtNumeroSerie = new TextBox();
            cmbTipoEquipo = new ComboBox();
            cmbEstado = new ComboBox();
            btnGuardarcambios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el codigo del equipo:";
            txtBuscar.Location = new Point(82, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(203, 27);
            txtBuscar.TabIndex = 1;
            btnBuscar.Location = new Point(82, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(203, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            label2.AutoSize = true;
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 3;
            label2.Text = "Datos a editar del equipo:";
            label3.AutoSize = true;
            label3.Location = new Point(20, 143);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            label4.AutoSize = true;
            label4.Location = new Point(20, 176);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Modelo:";
            label5.AutoSize = true;
            label5.Location = new Point(20, 209);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 6;
            label5.Text = "Numero de serie:";
            label6.AutoSize = true;
            label6.Location = new Point(20, 245);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 7;
            label6.Text = "Tipo de equipo:";
            label7.AutoSize = true;
            label7.Location = new Point(23, 279);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 8;
            label7.Text = "Estado:";
            txtMarca.Location = new Point(148, 143);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(157, 27);
            txtMarca.TabIndex = 9;
            txtModelo.Location = new Point(148, 176);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(157, 27);
            txtModelo.TabIndex = 10;
            txtNumeroSerie.Location = new Point(148, 209);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(157, 27);
            txtNumeroSerie.TabIndex = 11;
            cmbTipoEquipo.FormattingEnabled = true;
            cmbTipoEquipo.Location = new Point(148, 245);
            cmbTipoEquipo.Name = "cmbTipoEquipo";
            cmbTipoEquipo.Size = new Size(157, 28);
            cmbTipoEquipo.TabIndex = 12;
            cmbTipoEquipo.SelectedIndexChanged += cmbTipoEquipo_SelectedIndexChanged;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(148, 279);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(157, 28);
            cmbEstado.TabIndex = 13;
            btnGuardarcambios.Location = new Point(93, 334);
            btnGuardarcambios.Name = "btnGuardarcambios";
            btnGuardarcambios.Size = new Size(153, 29);
            btnGuardarcambios.TabIndex = 14;
            btnGuardarcambios.Text = "Guardar cambios";
            btnGuardarcambios.UseVisualStyleBackColor = true;
            btnGuardarcambios.Click += btnGuardarcambios_Click;
            btnSalir.Location = new Point(255, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(382, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardarcambios);
            Controls.Add(cmbEstado);
            Controls.Add(cmbTipoEquipo);
            Controls.Add(txtNumeroSerie);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Name = "frmEditarEquipos";
            Text = "Editar";
            Load += frmEditarEquipos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtNumeroSerie;
        private ComboBox cmbTipoEquipo;
        private ComboBox cmbEstado;
        private Button btnGuardarcambios;
        private Button btnSalir;
    }
}