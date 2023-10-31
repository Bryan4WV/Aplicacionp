using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.Formularios
{
    public partial class FormaDatosCaps : Form
    {
        public FormaDatosCaps()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaEmpleado empleadoForm = new FormaEmpleado();
            if (empleadoForm.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.SetValues(empleadoForm.Nombre, empleadoForm.Apellidos, empleadoForm.Edad, empleadoForm.Cargo, empleadoForm.Salario);
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaProducto productoForm = new FormaProducto();
            if (productoForm.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                row.SetValues(productoForm.Nombre, productoForm.Descripcion, productoForm.Cantidad, productoForm.Precio);
                dataGridView2.Rows.Add(row);
            }

        }
    }
}
