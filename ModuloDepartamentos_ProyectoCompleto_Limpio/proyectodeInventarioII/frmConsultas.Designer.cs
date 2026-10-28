namespace proyectodeInventarioII
{
    partial class frmConsultas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            cmbEstado = new ComboBox();
            label3 = new Label();
            cmbDepartamento = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            TipoEquipo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(114, 75);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar por codigo de serie:";
            txtCodigo.Location = new Point(309, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(213, 27);
            txtCodigo.TabIndex = 1;
            label2.AutoSize = true;
            label2.Location = new Point(114, 125);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Buscar por estado:";
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(309, 117);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(213, 28);
            cmbEstado.TabIndex = 3;
            label3.AutoSize = true;
            label3.Location = new Point(114, 175);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 4;
            label3.Text = "Buscar por departamento:";
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(309, 172);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(213, 28);
            cmbDepartamento.TabIndex = 5;
            label4.AutoSize = true;
            label4.Location = new Point(292, 19);
            label4.Name = "label4";
            label4.Size = new Size(230, 20);
            label4.TabIndex = 6;
            label4.Text = "Busqueda de equipos registrados";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Marca, Modelo, TipoEquipo, Estado, Fecha });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(830, 188);
            dataGridView1.TabIndex = 7;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            TipoEquipo.HeaderText = "Tipo de Equipo";
            TipoEquipo.MinimumWidth = 6;
            TipoEquipo.Name = "TipoEquipo";
            TipoEquipo.ReadOnly = true;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            btnBuscar.Location = new Point(606, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(148, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnSalir.Location = new Point(761, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(873, 484);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(cmbDepartamento);
            Controls.Add(label3);
            Controls.Add(cmbEstado);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "frmConsultas";
            Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private ComboBox cmbEstado;
        private Label label3;
        private ComboBox cmbDepartamento;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn TipoEquipo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnBuscar;
        private Button btnSalir;
    }
}