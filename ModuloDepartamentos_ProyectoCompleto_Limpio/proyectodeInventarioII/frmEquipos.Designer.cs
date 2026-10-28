namespace proyectodeInventarioII
{
    partial class frmEquipos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipos));
            dtgEquipos = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoEquipo = new ToolStripButton();
            toolBtnEditarEquipo = new ToolStripButton();
            toolBtnEliminarEquipo = new ToolStripButton();
            btnSalir = new Button();
            label1 = new Label();
            txtTotalEquipos = new TextBox();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            dtgEquipos.AllowUserToAddRows = false;
            dtgEquipos.AllowUserToDeleteRows = false;
            dtgEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEquipos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgEquipos.EnableHeadersVisualStyles = false;
            dtgEquipos.Location = new Point(0, 30);
            dtgEquipos.Name = "dtgEquipos";
            dtgEquipos.ReadOnly = true;
            dtgEquipos.RowHeadersWidth = 51;
            dtgEquipos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgEquipos.Size = new Size(1051, 197);
            dtgEquipos.TabIndex = 0;
            dtgEquipos.CellContentClick += dtgEquipos_CellContentClick;
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoEquipo, toolBtnEditarEquipo, toolBtnEliminarEquipo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1066, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            toolBtnNuevoEquipo.Image = Properties.Resources.plus;
            toolBtnNuevoEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoEquipo.Name = "toolBtnNuevoEquipo";
            toolBtnNuevoEquipo.Size = new Size(80, 24);
            toolBtnNuevoEquipo.Text = "Nuevo ";
            toolBtnNuevoEquipo.Click += toolBtnNuevoEquipo_Click;
            toolBtnEditarEquipo.Image = Properties.Resources.boton_editar;
            toolBtnEditarEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnEditarEquipo.Name = "toolBtnEditarEquipo";
            toolBtnEditarEquipo.Size = new Size(72, 24);
            toolBtnEditarEquipo.Text = "Editar";
            toolBtnEditarEquipo.Click += toolBtnEditarEquipo_Click;
            toolBtnEliminarEquipo.Image = (Image)resources.GetObject("toolBtnEliminarEquipo.Image");
            toolBtnEliminarEquipo.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarEquipo.Name = "toolBtnEliminarEquipo";
            toolBtnEliminarEquipo.Size = new Size(87, 24);
            toolBtnEliminarEquipo.Text = "Eliminar";
            toolBtnEliminarEquipo.Click += toolBtnEliminarEquipo_Click;
            btnSalir.Location = new Point(930, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            label1.AutoSize = true;
            label1.Location = new Point(12, 255);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Total de equipos";
            txtTotalEquipos.Location = new Point(138, 252);
            txtTotalEquipos.Name = "txtTotalEquipos";
            txtTotalEquipos.Size = new Size(125, 27);
            txtTotalEquipos.TabIndex = 4;
            btnCalcular.Location = new Point(291, 255);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1066, 304);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotalEquipos);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(toolStrip1);
            Controls.Add(dtgEquipos);
            Name = "frmEquipos";
            Text = "Equipos";
            Load += frmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEquipos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgEquipos;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoEquipo;
        private ToolStripButton toolBtnEditarEquipo;
        private ToolStripButton toolBtnEliminarEquipo;
       
        private Button btnSalir;
        private Label label1;
        private TextBox txtTotalEquipos;
        private Button btnCalcular;
    }
}