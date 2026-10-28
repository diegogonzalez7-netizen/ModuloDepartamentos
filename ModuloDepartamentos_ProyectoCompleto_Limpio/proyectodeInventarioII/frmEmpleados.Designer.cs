namespace proyectodeInventarioII
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoEmpleado = new ToolStripButton();
            toolBtnEditarEmpleados = new ToolStripButton();
            toolBtnEliminarEmpleado = new ToolStripButton();
            toolBtnBuscarEmpleado = new ToolStripButton();
            txtBuscarEmpleado = new ToolStripTextBox();
            dgvEmpleados = new DataGridView();
            DUI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnOrdenar = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoEmpleado, toolBtnEditarEmpleados, toolBtnEliminarEmpleado, toolBtnBuscarEmpleado, txtBuscarEmpleado });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(957, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolBtnNuevoEmpleado.Image = (Image)resources.GetObject("toolBtnNuevoEmpleado.Image");
            toolBtnNuevoEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoEmpleado.Name = "toolBtnNuevoEmpleado";
            toolBtnNuevoEmpleado.Size = new Size(76, 24);
            toolBtnNuevoEmpleado.Text = "Nuevo";
            toolBtnNuevoEmpleado.Click += toolBtnNuevoEmpleado_Click;
            toolBtnEditarEmpleados.Image = (Image)resources.GetObject("toolBtnEditarEmpleados.Image");
            toolBtnEditarEmpleados.ImageTransparentColor = Color.Magenta;
            toolBtnEditarEmpleados.Name = "toolBtnEditarEmpleados";
            toolBtnEditarEmpleados.Size = new Size(72, 24);
            toolBtnEditarEmpleados.Text = "Editar";
            toolBtnEditarEmpleados.Click += toolBtnEditarEmpleados_Click;
            toolBtnEliminarEmpleado.Image = (Image)resources.GetObject("toolBtnEliminarEmpleado.Image");
            toolBtnEliminarEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarEmpleado.Name = "toolBtnEliminarEmpleado";
            toolBtnEliminarEmpleado.Size = new Size(87, 24);
            toolBtnEliminarEmpleado.Text = "Eliminar";
            toolBtnEliminarEmpleado.Click += toolBtnEliminarEmpleado_Click;
            toolBtnBuscarEmpleado.Image = (Image)resources.GetObject("toolBtnBuscarEmpleado.Image");
            toolBtnBuscarEmpleado.ImageTransparentColor = Color.Magenta;
            toolBtnBuscarEmpleado.Name = "toolBtnBuscarEmpleado";
            toolBtnBuscarEmpleado.Size = new Size(76, 24);
            toolBtnBuscarEmpleado.Text = "Buscar";
            toolBtnBuscarEmpleado.Click += toolBtnBuscarEmpleado_Click;
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(139, 27);
            txtBuscarEmpleado.ToolTipText = "Código de empleado a buscar";
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { DUI, Nombre, Apellido, Correo, Cargo, Departamento });
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(12, 40);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvEmpleados.Size = new Size(926, 160);
            dgvEmpleados.TabIndex = 1;
            DUI.HeaderText = "DUI";
            DUI.MinimumWidth = 6;
            DUI.Name = "DUI";
            DUI.ReadOnly = true;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            btnSalir.Location = new Point(787, 206);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(151, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            btnOrdenar.Location = new Point(12, 206);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(181, 29);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar por apellido";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(957, 288);
            Controls.Add(btnOrdenar);
            Controls.Add(btnSalir);
            Controls.Add(dgvEmpleados);
            Controls.Add(toolStrip1);
            Name = "frmEmpleados";
            Text = "Empleados";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoEmpleado;
        private ToolStripButton toolBtnEditarEmpleados;
        private ToolStripButton toolBtnEliminarEmpleado;
        private DataGridView dgvEmpleados;
        private Button btnSalir;
        private ToolStripTextBox txtBuscarEmpleado;
        private DataGridViewTextBoxColumn DUI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Departamento;
        private ToolStripButton toolBtnBuscarEmpleado;
        private Button btnOrdenar;
    }
}