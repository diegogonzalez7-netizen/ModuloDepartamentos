using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public static List<List<string>> ListEmpleado = new List<List<string>>();


        private void toolBtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleadoModal frmEmp = new frmEmpleadoModal();
            frmEmp.MdiParent = this.MdiParent;
            this.Enabled = false;

            frmEmp.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                if (frmEmp.DialogResult == DialogResult.OK)
                {
                    dgvEmpleados.Rows.Add(frmEmp.dui, frmEmp.nombre, frmEmp.apellido, frmEmp.correo, frmEmp.cargo, frmEmp.departamento);

                    List<string> nuevoEmpleado = new List<string>
                    {
                        frmEmp.dui,
                        frmEmp.nombre,
                        frmEmp.apellido,
                        frmEmp.correo,
                        frmEmp.cargo,
                        frmEmp.departamento
                    };
                    ListEmpleado.Add(nuevoEmpleado);

                }
            };
            frmEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolBtnEditarEmpleados_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado frmEdit = new frmEditarEmpleado();
            frmEdit.ShowDialog();
        }

        private void toolBtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarEmpleado.Text.Trim().ToLower();

            var resultado = ListEmpleado.Where(emp => emp[1].Contains(filtro) || emp[2].Contains(filtro)).ToList();
            dgvEmpleados.Rows.Clear();
            foreach (var item in resultado)
            {
                dgvEmpleados.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            var ordenar = ListEmpleado.OrderBy(emp => emp[2]).ToList();
            dgvEmpleados.Rows.Clear();
            foreach (var item in ordenar)
            {
                dgvEmpleados.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
            }
        }

        private void toolBtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if(dgvEmpleados.SelectedRows.Count > 0) 
            {
                ListEmpleado.RemoveAt(dgvEmpleados.SelectedRows[0].Index);
                dgvEmpleados.Rows.RemoveAt(dgvEmpleados.SelectedRows[0].Index);
                MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
