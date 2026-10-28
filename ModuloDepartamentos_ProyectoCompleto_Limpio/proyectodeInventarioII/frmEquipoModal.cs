using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEquipoModal : Form
    {
        private static readonly Regex RegexCodigo = new Regex(@"^[A-Z]{2}-\d{3}$");
        private static readonly Regex RegexNumeroSerie = new Regex(@"^[A-Z0-9]{5,10}$");
        public frmEquipoModal()
        {
            InitializeComponent();
        }
        public enum TipoEquipos
        {
            Computadora = 1,
            Impresora = 2,
            Monitor = 3,
            Teclado = 4,
            Mouse = 5,
            Otro = 6
        }
        public enum EstadoEquipos
        {
            Disponible = 1,
            Asignado = 2,
            Mantenimiento = 3,
            Dañado = 4
        }
        private void frmEquipoModal_Load(object sender, EventArgs e)
        {
            cmbTipoEquipo.DataSource = Enum.GetValues<TipoEquipos>();
            cmbEstado.DataSource = Enum.GetValues<EstadoEquipos>();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCodigo, "El código es obligatorio.");
            }
            else if (!RegexCodigo.IsMatch(txtCodigo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCodigo, "El código debe tener el formato de 3 dígitos (Ejemplo: AB-123).");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCodigo, "");
            }
        }

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMarca, "La marca es obligatoria.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMarca, "");
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtModelo, "El modelo es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtModelo, "");
            }
        }

        private void txtNumeroSerie_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNumeroSerie, "El número de serie es obligatorio.");
            }
            else if (!RegexNumeroSerie.IsMatch(txtNumeroSerie.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNumeroSerie, "El número de serie debe tener el formato de 5 a 10 caracteres(ejemplo: ABC123).");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNumeroSerie, "");
            }
        }

        private void txtNumeroSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpFechaCompra_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaCompra.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaCompra, "La fecha de compra no puede ser mayor a la fecha actual.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpFechaCompra, "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string codigo = txtCodigo.Text.Trim();
                if (frmEquipos.equipos.ContainsKey(codigo))
                {
                    MessageBox.Show("El código del equipo ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string marca = txtMarca.Text.Trim();
                string modelo = txtModelo.Text.Trim();
                string numeroSerie = txtNumeroSerie.Text.Trim();
                string tipoEquipo = cmbTipoEquipo.SelectedItem.ToString();
                string estado = cmbEstado.SelectedItem.ToString();
                DateTime fechaCompra = dtpFechaCompra.Value;
                int añoGarantia = (int)nudAnioGarantia.Value;
                frmEquipos.equipos.Add(codigo, (marca, modelo, numeroSerie, tipoEquipo, estado, fechaCompra, añoGarantia));
                MessageBox.Show("Equipo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("Por favor, corrija los errores antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
