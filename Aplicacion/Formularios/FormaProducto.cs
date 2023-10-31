using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Formularios;
using Aplicacion.Formas;

namespace Aplicacion.Formularios
{
    public partial class FormaProducto : Form
    {

        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public int Cantidad { get; private set; }
        public decimal Precio { get; private set; }
        public FormaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Nombre = txtNombreDelProducto.Text;
            Descripcion = txtDescripciónDelProducto.Text;

            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                Cantidad = cantidad;
            }
            else
            {
                MessageBox.Show("La cantidad no es válida. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                Precio = precio;
            }
            else
            {
                MessageBox.Show("El precio no es válido. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
    }


