using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(248, 249, 250);
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(248, 249, 250);
                }
            }
        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form formulario in MdiChildren)
            {
                if (formulario is T)
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.Activate();
                    return;
                }
            }
            T formularioHijo = new T();
            formularioHijo.MdiParent = this;
            formularioHijo.Show();
        }
        private void cacadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEquipos>();
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleados>();
        }

        private void mnuDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDepartamentos>();
        }

        private void mnuMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMantenimientos>();
        }

        private void toolBtnEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEquipos>();
        }

        private void toolBtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleados>();
        }

        private void toolBtnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDepartamentos>();
        }

        private void toolBtnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMantenimientos>();
        }

        private void mnuAsignarEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAsignarEquipos>();
        }

        private void MnuConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConsultas>();
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in MdiChildren)
            {
                formulario.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConsultas>();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            pictureBox1.Visible = this.ActiveMdiChild == null;
        }
    }
}
