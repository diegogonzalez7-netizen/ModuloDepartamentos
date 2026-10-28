using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEditarEquipos : Form
    {
        public frmEditarEquipos(string codigo)
        {
            InitializeComponent();
            codigoEquipo = codigo;
            btnGuardarcambios.Click += btnGuardarcambios_Click;
            btnSalir.Click += btnSalir_Click;


        }
        private static readonly Regex RegexNumeroSerie = new Regex(@"^[A-Z0-9]{5,10}$");
        private string codigoEquipo;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarEquipos_Load(object sender, EventArgs e)
        {
            cmbTipoEquipo.DataSource = Enum.GetValues<frmEquipoModal.TipoEquipos>();
            cmbEstado.DataSource = Enum.GetValues<frmEquipoModal.EstadoEquipos>();
            txtBuscar.Text = codigoEquipo;
            BuscarEquipo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            codigoEquipo = txtBuscar.Text.Trim();
            BuscarEquipo();

        }
        private void BuscarEquipo()
        {
            if (string.IsNullOrWhiteSpace(codigoEquipo))
            {
                MessageBox.Show("Por favor, ingrese un código de equipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            (string Marca,
            string Modelo,
            string Serie,
            string TipoEquipo,
            string Estado,
            DateTime fechaCompra,
            int añoGarantia) equipo;
            if (frmEquipos.equipos.TryGetValue(codigoEquipo, out equipo))
            {
                txtMarca.Text = equipo.Marca;
                txtModelo.Text = equipo.Modelo;
                txtNumeroSerie.Text = equipo.Serie;
                cmbTipoEquipo.SelectedItem = equipo.TipoEquipo;
                cmbEstado.SelectedItem = equipo.Estado;
            }
            else
            {
                MessageBox.Show("El código de equipo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoEquipo))
            {
                MessageBox.Show("Por favor, ingrese un código de equipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!frmEquipos.equipos.ContainsKey(codigoEquipo))
            {
                MessageBox.Show("El código de equipo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string numeroSerie = txtNumeroSerie.Text.Trim();
            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(numeroSerie))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!RegexNumeroSerie.IsMatch(numeroSerie))
            {
                MessageBox.Show("El número de serie debe contener entre 5 y 10 caracteres alfanuméricos en mayúsculas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            (string Marca,
            string Modelo,
            string Serie,
            string TipoEquipo,
            string Estado,
            DateTime fechaCompra,
            int añoGarantia) equipoActual;
            equipoActual = frmEquipos.equipos[codigoEquipo];
            frmEquipos.equipos[codigoEquipo] = (marca, modelo, numeroSerie, cmbTipoEquipo.SelectedItem.ToString(), cmbEstado.SelectedItem.ToString(), equipoActual.fechaCompra, equipoActual.añoGarantia);

            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
