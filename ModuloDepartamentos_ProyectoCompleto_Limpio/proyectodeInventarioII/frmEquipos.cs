using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEquipos : Form
    {
        public static Dictionary<string, (string Marca, string Modelo, string Serie, string TipoEquipo, string Estado, DateTime fechaCompra, int añoGarantia)> equipos = [];
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void dtgEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolBtnNuevoEquipo_Click(object sender, EventArgs e)
        {
            frmEquipoModal frmEq = new frmEquipoModal();

            if (frmEq.ShowDialog() == DialogResult.OK)
            {
                refrescarGrid();
            }

        }
        private void refrescarGrid()
        {
            dtgEquipos.DataSource = null;
            dtgEquipos.DataSource = equipos.Select(equipo => new
            {
                Codigo = equipo.Key,
                Marca = equipo.Value.Marca,
                Modelo = equipo.Value.Modelo,
                NumeroDeSerie = equipo.Value.Serie,
                TipoDeEquipo = equipo.Value.TipoEquipo,
                Estado = equipo.Value.Estado,
                FechaDeCompra = equipo.Value.fechaCompra.ToShortDateString(),
                añoDeGarantia = equipo.Value.añoGarantia
            }).ToList();
            dtgEquipos.Columns["Codigo"].HeaderText = "Código";
            dtgEquipos.Columns["Marca"].HeaderText = "Marca";
            dtgEquipos.Columns["Modelo"].HeaderText = "Modelo";
            dtgEquipos.Columns["NumeroDeSerie"].HeaderText = "Número de Serie";
            dtgEquipos.Columns["TipoDeEquipo"].HeaderText = "Tipo de Equipo";
            dtgEquipos.Columns["Estado"].HeaderText = "Estado";
            dtgEquipos.Columns["FechaDeCompra"].HeaderText = "Fecha de Compra";
            dtgEquipos.Columns["añoDeGarantia"].HeaderText = "Año de Garantía";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dtgEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigo = dtgEquipos.CurrentRow.Cells["Codigo"].Value.ToString();
            frmEditarEquipos frmEditEq = new frmEditarEquipos(codigo);
            frmEditEq.ShowDialog();

            refrescarGrid();
        }

        private void toolBtnEliminarEquipo_Click(object sender, EventArgs e)
        {

            if (dtgEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            string codigo = dtgEquipos.CurrentRow.Cells["Codigo"].Value.ToString();
            frmEditarEquipos frmEditEq = new frmEditarEquipos(codigo);
            if (MessageBox.Show($"¿Está seguro de que desea eliminar el equipo con código {codigo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                equipos.Remove(codigo);
                refrescarGrid();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotalEquipos.Text = equipos.Count.ToString();

        }
    }
}
