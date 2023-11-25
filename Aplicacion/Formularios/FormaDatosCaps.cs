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
                row.SetValues(empleadoForm.Nombre, empleadoForm.Apellidos, empleadoForm.Edad, empleadoForm.Horario, empleadoForm.Salario, empleadoForm.FechaIngreso, empleadoForm.Telefono, empleadoForm.Curp);
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
                row.SetValues(productoForm.Nombre, productoForm.Descripcion, productoForm.Cantidad, productoForm.Precio, productoForm.Material, productoForm.Peso, productoForm.ClaveProducto, productoForm.Origen);
                dataGridView2.Rows.Add(row);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas seleccionadas en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Mostrar un mensaje de confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta fila?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila del DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Aquí puedes agregar la lógica para eliminar los datos de tu origen de datos (base de datos, lista, etc.)
                    // Por ejemplo, si tus datos están en una lista, puedes hacer algo como:
                    // TuListaDeDatos.RemoveAt(selectedRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Mostrar un mensaje de confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta fila?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila del DataGridView
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.Remove(row);
                    }

                    // Aquí puedes agregar la lógica para eliminar los datos de tu origen de datos (base de datos, lista, etc.)
                    // Por ejemplo, si tus datos están en una lista, puedes hacer algo como:
                    // TuListaDeDatos.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Selecciona al menos una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formainventarioproductos verproductos = new Formainventarioproductos();
            verproductos.Show();

        }
    }
}
