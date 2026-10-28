using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmMantenimientos : Form
    {
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void toolBtnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimientoModal frmMod = new frmMantenimientoModal();
            frmMod.ShowDialog();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            frmEditarMantenimiento frmMant = new frmEditarMantenimiento();
            frmMant.ShowDialog();
        }
    }
}
