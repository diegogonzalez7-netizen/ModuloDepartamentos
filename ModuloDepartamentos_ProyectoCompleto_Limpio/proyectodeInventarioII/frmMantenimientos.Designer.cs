namespace proyectodeInventarioII
{
    partial class frmMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoMantenimiento = new ToolStripButton();
            toolBtnEditarMantenimiento = new ToolStripButton();
            toolBtnEliminarMantenimiento = new ToolStripButton();
            dtgMantenimientos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            TipoDeMantenimiento = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Tecnico = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).BeginInit();
            SuspendLayout();
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoMantenimiento, toolBtnEditarMantenimiento, toolBtnEliminarMantenimiento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolBtnNuevoMantenimiento.Image = Properties.Resources.plus;
            toolBtnNuevoMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoMantenimiento.Name = "toolBtnNuevoMantenimiento";
            toolBtnNuevoMantenimiento.Size = new Size(76, 24);
            toolBtnNuevoMantenimiento.Text = "Nuevo";
            toolBtnNuevoMantenimiento.Click += toolBtnNuevoMantenimiento_Click;
            toolBtnEditarMantenimiento.Image = Properties.Resources.boton_editar;
            toolBtnEditarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarMantenimiento.Name = "toolBtnEditarMantenimiento";
            toolBtnEditarMantenimiento.Size = new Size(72, 24);
            toolBtnEditarMantenimiento.Text = "Editar";
            toolBtnEditarMantenimiento.Click += toolBtnEditarMantenimiento_Click;
            toolBtnEliminarMantenimiento.Image = (Image)resources.GetObject("toolBtnEliminarMantenimiento.Image");
            toolBtnEliminarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarMantenimiento.Name = "toolBtnEliminarMantenimiento";
            toolBtnEliminarMantenimiento.Size = new Size(87, 24);
            toolBtnEliminarMantenimiento.Text = "Eliminar";
            dtgMantenimientos.AllowUserToAddRows = false;
            dtgMantenimientos.AllowUserToDeleteRows = false;
            dtgMantenimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMantenimientos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMantenimientos.Columns.AddRange(new DataGridViewColumn[] { Equipo, TipoDeMantenimiento, Fecha, Descripcion, Tecnico, Costo });
            dtgMantenimientos.EnableHeadersVisualStyles = false;
            dtgMantenimientos.Location = new Point(0, 39);
            dtgMantenimientos.Name = "dtgMantenimientos";
            dtgMantenimientos.ReadOnly = true;
            dtgMantenimientos.RowHeadersWidth = 51;
            dtgMantenimientos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgMantenimientos.Size = new Size(800, 188);
            dtgMantenimientos.TabIndex = 1;
            Equipo.HeaderText = "Equipo";
            Equipo.MinimumWidth = 6;
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            TipoDeMantenimiento.HeaderText = "Tipo de mantenimiento";
            TipoDeMantenimiento.MinimumWidth = 6;
            TipoDeMantenimiento.Name = "TipoDeMantenimiento";
            TipoDeMantenimiento.ReadOnly = true;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Tecnico.HeaderText = "Tecnico Responsable";
            Tecnico.MinimumWidth = 6;
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            btnSalir.Location = new Point(685, 242);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 283);
            Controls.Add(btnSalir);
            Controls.Add(dtgMantenimientos);
            Controls.Add(toolStrip1);
            Name = "frmMantenimientos";
            Text = "Mantenimientos";
            Load += frmMantenimientos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoMantenimiento;
        private ToolStripButton toolBtnEditarMantenimiento;
        private ToolStripButton toolBtnEliminarMantenimiento;
        private DataGridView dtgMantenimientos;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn TipoDeMantenimiento;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Tecnico;
        private DataGridViewTextBoxColumn Costo;
        private Button btnSalir;
    }
}