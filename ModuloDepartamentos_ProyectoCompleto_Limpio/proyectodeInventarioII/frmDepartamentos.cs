using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmDepartamentos : Form
    {
        public static List<DepartamentoTemp> ListaDepartamentos =
    new List<DepartamentoTemp>();
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void toolBtnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            frmDepartamentoModal frmDep = new frmDepartamentoModal();

            if (frmDep.ShowDialog() == DialogResult.OK)
            {
                ListaDepartamentos.Add(new DepartamentoTemp
                {
                    Codigo = frmDep.Codigo,
                    Nombre = frmDep.Nombre,
                    Ubicacion = frmDep.Ubicacion,
                    Encargado = frmDep.Encargado
                });

                RefrescarGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarDepartamento_Click(object sender, EventArgs e)
        {
            if (dtgDepartamentos.SelectedRows.Count == null)
            {
                MessageBox.Show(
                    "Seleccione un departamento para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string codigo = dtgDepartamentos.CurrentRow
                .Cells[0]
                .Value?
                .ToString();

            frmEditarDepartamentos frmDep =
    new frmEditarDepartamentos(codigo);

            if (frmDep.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }
        private void RefrescarGrid()
        {
            dtgDepartamentos.Rows.Clear();

            foreach (DepartamentoTemp departamento in ListaDepartamentos)
            {
                dtgDepartamentos.Rows.Add(
                    departamento.Codigo,
                    departamento.Nombre,
                    departamento.Ubicacion,
                    departamento.Encargado);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDepartamentos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un departamento para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string codigo = dtgDepartamentos.CurrentRow
                .Cells[0]
                .Value?
                .ToString();

            DepartamentoTemp departamento = ListaDepartamentos
                .Find(d => d.Codigo == codigo);

            if (departamento == null)
            {
                MessageBox.Show(
                    "No se encontró el departamento.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar el departamento " + departamento.Nombre + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ListaDepartamentos.Remove(departamento);
                RefrescarGrid();

                MessageBox.Show(
                    "Departamento eliminado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

public class DepartamentoTemp
{
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Ubicacion { get; set; } = string.Empty;
    public string Encargado { get; set; } = string.Empty;
}