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

        public string Material { get; private set; }
        public decimal Peso { get; private set; }
        public string ClaveProducto { get; private set; }
        public string Origen { get; private set; }
        public FormaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Nombre = txtNombreDelProducto.Text;
            Descripcion = txtDescripciónDelProducto.Text;

            // Lista para almacenar los campos no válidos
            List<string> camposNoValidos = new List<string>();

            // Validar el nombre
            if (string.IsNullOrEmpty(Nombre))
            {
                camposNoValidos.Add("Nombre");
            }

            // Validar la descripción
            if (string.IsNullOrEmpty(Descripcion))
            {
                camposNoValidos.Add("Descripción");
            }

            // Validar la cantidad
            if (int.TryParse(txtCantidadproducto.Text, out int cantidad))
            {
                Cantidad = cantidad;
            }
            else
            {
                camposNoValidos.Add("Cantidad");
            }

            // Validar el precio
            if (decimal.TryParse(txtPrecioproducto.Text, out decimal precio))
            {
                Precio = precio;
            }
            else
            {
                camposNoValidos.Add("Precio");
            }

            // Validar el material
            Material = txtmaterialproducto.Text;
            if (string.IsNullOrEmpty(Material))
            {
                camposNoValidos.Add("Material");
            }

            // Validar el peso
            if (decimal.TryParse(txtpesoproducto.Text, out decimal peso))
            {
                Peso = peso;
            }
            else
            {
                camposNoValidos.Add("Peso");
            }

            // Validar la clave del producto
            ClaveProducto = txtclaveproducto.Text;
            if (string.IsNullOrEmpty(ClaveProducto))
            {
                camposNoValidos.Add("Clave del Producto");
            }

            // Validar el origen
            Origen = txtorigen.Text;
            if (string.IsNullOrEmpty(Origen))
            {
                camposNoValidos.Add("Origen");
            }

            // Si hay campos no válidos, mostrar mensaje de error
            if (camposNoValidos.Count > 0)
            {
                string mensajeError = "Los siguientes campos son necesarios o contienen datos no válidos:\n\n";
                mensajeError += string.Join("\n", camposNoValidos);

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones son exitosas, cerrar el formulario
            DialogResult = DialogResult.OK;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


