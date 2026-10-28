using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmAsignarEquipos : Form
    {
        public frmAsignarEquipos()
        {
            InitializeComponent();

            cmbEquipoAsignar.DataSource = frmEquipos.equipos.Select(Equipo => Equipo.Key).ToList();
            cmbEmpleadoAsignar.DataSource = frmEmpleados.ListEmpleado.Select(empleado => $"{empleado[1]} {empleado[2]}").ToList();
        }
        public static Dictionary<string, (string Equipo, string Empleado, DateTime FechaAsignacion, DateTime FechaDevolucion, string EstadoEquipo, string Observaciones)> asignaciones = [];

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAsignarEquipos_Load(object sender, EventArgs e)
        {
            cmbEmpleadoAsignar.SelectedIndexChanged += Validar;
            cmbEquipoAsignar.SelectedIndexChanged += Validar;
            cmbEquipoAsignar.SelectedIndexChanged += cmbEquipoAsignar_SelectedIndexChanged;
            dtpFecha.ValueChanged += Validar;
            dtpFechaDevolucion.ValueChanged += Validar;
            txtObservaciones.TextChanged += Validar;
            btnAsignar.Enabled = false;

        }

        private void cmbEquipoAsignar_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbEquipoAsignar.SelectedIndex < 0)
            {
                cmbEstadoEquipo.DataSource = null;
                cmbEstadoEquipo.Enabled = true;
                return;
            }


            string codigoSerie = cmbEquipoAsignar.Text;


            if (frmEquipos.equipos.ContainsKey(codigoSerie))
            {

                string estadoDelEquipo = frmEquipos.equipos[codigoSerie].Estado;


                cmbEstadoEquipo.DataSource = new List<string> { estadoDelEquipo };
                cmbEstadoEquipo.SelectedIndex = 0;
                cmbEstadoEquipo.Enabled = false;


            }
        }

        private void Validar(object? sender, EventArgs e)
        {
            bool empleadoOk = cmbEmpleadoAsignar.SelectedIndex >= 0;
            bool equipoOk = cmbEquipoAsignar.SelectedIndex >= 0;
            bool fechaOk = dtpFecha.Value.Date >= DateTime.Now.Date;
            bool fechaDevolucionOk = dtpFechaDevolucion.Value.Date >= dtpFecha.Value.Date;
            bool estadoOk = cmbEstadoEquipo.SelectedIndex >= 0;
            bool observacionesOk = !string.IsNullOrWhiteSpace(txtObservaciones.Text);
            errorProvider1.SetError(cmbEmpleadoAsignar, empleadoOk ? "" : "Debe seleccionar un empleado.");
            errorProvider1.SetError(cmbEquipoAsignar, equipoOk ? "" : "Debe seleccionar un equipo.");
            errorProvider1.SetError(dtpFecha, fechaOk ? "" : "La fecha debe ser igual o posterior a la fecha actual.");
            errorProvider1.SetError(cmbEstadoEquipo, estadoOk ? "" : "Debe seleccionar un estado.");
            errorProvider1.SetError(dtpFechaDevolucion, fechaDevolucionOk ? "" : "La fecha de devolución debe ser igual o posterior a la fecha de asignación.");
            errorProvider1.SetError(txtObservaciones, observacionesOk ? "" : "El campo de observaciones es obligatorio.");
            btnAsignar.Enabled = empleadoOk && equipoOk && fechaOk && fechaDevolucionOk && estadoOk && observacionesOk;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string empleado = cmbEmpleadoAsignar.Text;
            string equipo = cmbEquipoAsignar.Text;
            DateTime fechaAsignacion = dtpFecha.Value;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value;
            string estado = cmbEstadoEquipo.Text;
            string observaciones = txtObservaciones.Text;


            if (asignaciones.ContainsKey(equipo))
            {
                MessageBox.Show($"El equipo {equipo} ya está asignado. " +
                                $"Debe devolverlo o cambiarlo primero.",
                                "Equipo ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            asignaciones.Add(equipo, (equipo, empleado, fechaAsignacion, fechaDevolucion, estado, observaciones));

            RefrescarTabla();

            LimpiarControles();

            MessageBox.Show("Equipo asignado correctamente.");
        }

        private void LimpiarControles()
        {
            cmbEmpleadoAsignar.SelectedIndex = -1;
            cmbEquipoAsignar.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
            cmbEstadoEquipo.SelectedIndex = -1;
            txtObservaciones.Clear();
            cmbEquipoAsignar.Focus();
        }

        private void RefrescarTabla()
        {
            dtgHistorialDeAsignaciones.DataSource = null;
            dtgHistorialDeAsignaciones.DataSource = asignaciones.Select(a => new
            {

                Equipo = a.Key,
                Empleado = a.Value.Empleado,
                FechaAsignacion = a.Value.FechaAsignacion.ToShortDateString(),
                FechaDevolucion = a.Value.FechaDevolucion.ToShortDateString(),
                EstadoEquipo = a.Value.EstadoEquipo,
                Observaciones = a.Value.Observaciones
            }).ToList();

        }

        private void btnDevolverEquipo_Click(object sender, EventArgs e)
        {
            string equipo = cmbEquipoAsignar.Text;

            if (asignaciones.ContainsKey(equipo))
            {
                asignaciones.Remove(equipo);
                RefrescarTabla();
                LimpiarControles();
                MessageBox.Show("Equipo devuelto correctamente.");
            }
            else
            {
                MessageBox.Show("Este equipo no tiene ninguna asignación activa.");
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }
    }

}
