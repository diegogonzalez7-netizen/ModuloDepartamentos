using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectodeInventarioII
{
    public partial class frmEditarAsignacion : Form
    {
        public frmEditarAsignacion()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }
        private void frmEditarAsignacion_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = frmAsignarEquipos.asignaciones.Select(asignacion => asignacion.Key).ToList();
            comboBox2.DataSource = frmEmpleados.ListEmpleado.Select(empleado => $"{empleado[1]} {empleado[2]}").ToList();
        }
    }
}

  
    
