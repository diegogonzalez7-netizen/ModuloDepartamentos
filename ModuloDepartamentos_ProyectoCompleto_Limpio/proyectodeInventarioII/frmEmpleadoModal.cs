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
    public partial class frmEmpleadoModal : Form
    {
        public frmEmpleadoModal()
        {
            InitializeComponent();
        }

        public List<string> empleado = [];

        private void frmEmpleadoModal_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;

            txtCorreo.TextChanged += ValidarFormulario;
            txtNombre.TextChanged += ValidarFormulario;
            txtApellido.TextChanged += ValidarFormulario;
            txtCargo.TextChanged += ValidarFormulario;
            mtxDUI.TextChanged += ValidarFormulario;
            cmbDepartamentos.SelectedIndexChanged += ValidarFormulario;

        }

        private static readonly Regex RegexCorreo = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        private void ValidarFormulario(object? sender, EventArgs e)
        {
            bool duiOK = mtxDUI.MaskCompleted;
            bool nombreOK = !string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            bool apellidOK = !string.IsNullOrWhiteSpace(txtApellido.Text) && txtApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            bool correoOK = !string.IsNullOrWhiteSpace(txtCorreo.Text) && RegexCorreo.IsMatch(txtCorreo.Text);
            bool cargoOK = !string.IsNullOrWhiteSpace(txtCargo.Text) && txtCargo.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            bool DepartamentoOK = cmbDepartamentos.SelectedIndex != -1;

            errorProvider1.SetError(txtNombre, nombreOK ? string.Empty : "Ingrese un nombre válido (solo letras y espacios).");
            errorProvider1.SetError(txtApellido, apellidOK ? string.Empty : "Ingrese un apellido válido (solo letras y espacios).");
            errorProvider1.SetError(txtCorreo, correoOK ? string.Empty : "Ingrese un correo electrónico válido.");
            errorProvider1.SetError(txtCargo, cargoOK ? string.Empty : "Ingrese un cargo válido (solo letras y espacios).");
            errorProvider1.SetError(mtxDUI, duiOK ? string.Empty : "Ingrese un DUI válido (formato: 00000000-0).");
            errorProvider1.SetError(cmbDepartamentos, DepartamentoOK ? string.Empty : "Seleccione un departamento.");

            btnGuardar.Enabled = duiOK && nombreOK && apellidOK && correoOK && cargoOK && DepartamentoOK;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            openFileDialog1.Title = "Abrir Imagen";
            openFileDialog1.FileName = null;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = openFileDialog1.FileName;
                    pictureBox1.Load(filepath);
                }
                catch
                {
                    MessageBox.Show("Error al cargar la imagen. Asegúrese de que el archivo sea una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public string nombre = string.Empty;
        public string apellido = string.Empty;
        public string correo = string.Empty;
        public string cargo = string.Empty;
        public string dui = string.Empty;
        public string departamento = string.Empty;


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            correo = txtCorreo.Text;
            cargo = txtCargo.Text;
            dui = mtxDUI.Text;
            departamento = cmbDepartamentos.SelectedItem?.ToString() ?? string.Empty;

            empleado.Add(nombre);
            empleado.Add(apellido);
            empleado.Add(correo);
            empleado.Add(cargo);
            empleado.Add(dui);
            empleado.Add(departamento);

            MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
