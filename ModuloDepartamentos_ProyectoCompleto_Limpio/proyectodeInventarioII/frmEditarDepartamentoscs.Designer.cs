namespace proyectodeInventarioII
{
    partial class frmEditarDepartamentos
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
            cbxCodigo = new ComboBox();
            txtDepartamento = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(251, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccióne el código de departamento a editar";
            label2.AutoSize = true;
            label2.Location = new Point(35, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Departamento:";
            cbxCodigo.FormattingEnabled = true;
            cbxCodigo.Location = new Point(101, 51);
            cbxCodigo.Margin = new Padding(3, 2, 3, 2);
            cbxCodigo.Name = "cbxCodigo";
            cbxCodigo.Size = new Size(133, 23);
            cbxCodigo.TabIndex = 2;
            cbxCodigo.SelectedIndexChanged += cbxCodigo_SelectedIndexChanged;
            txtDepartamento.Location = new Point(163, 123);
            txtDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(110, 23);
            txtDepartamento.TabIndex = 3;
            btnEditar.Location = new Point(35, 196);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            btnCancelar.Location = new Point(190, 189);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(354, 254);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(txtDepartamento);
            Controls.Add(cbxCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEditarDepartamentos";
            Text = "frmEditarDepartamentoscs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxCodigo;
        private TextBox txtDepartamento;
        private Button btnEditar;
        private Button btnCancelar;
    }
}