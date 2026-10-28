using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEditarDepartamentos : Form
    {
        private string codigoSeleccionado = string.Empty;

        public frmEditarDepartamentos(string codigo)
        {
            InitializeComponent();
            codigoSeleccionado = codigo;
            CargarCodigos();
        }
        private void CargarCodigos()
        {
            cbxCodigo.Items.Clear();

            foreach (DepartamentoTemp departamento in frmDepartamentos.ListaDepartamentos)
            {
                cbxCodigo.Items.Add(departamento.Codigo);
            }

            if (!string.IsNullOrEmpty(codigoSeleccionado))
            {
                cbxCodigo.SelectedItem = codigoSeleccionado;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un código.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            string codigo = cbxCodigo.SelectedItem.ToString();

            foreach (DepartamentoTemp departamento in frmDepartamentos.ListaDepartamentos)
            {
                if (departamento.Codigo == codigo)
                {
                    departamento.Nombre = txtDepartamento.Text.Trim();
                    break;
                }
            }

            MessageBox.Show("Departamento actualizado correctamente.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem == null)
                return;

            string codigo = cbxCodigo.SelectedItem.ToString();

            foreach (DepartamentoTemp departamento in frmDepartamentos.ListaDepartamentos)
            {
                if (departamento.Codigo == codigo)
                {
                    txtDepartamento.Text = departamento.Nombre;
                    break;
                }
            }
        }
    }
}
