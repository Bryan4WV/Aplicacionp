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
    public partial class FormaEmpleado : Form
    {
        private List<string> errores = new List<string>();

        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public int Edad { get; private set; }
        public string Horario { get; private set; }
        public decimal Salario { get; private set; }
        public string FechaIngreso { get; private set; }
        public string Telefono { get; private set; }
        public string Curp { get; private set; }



   

        public FormaEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = txtnombre.Text;
            Apellidos = txtapellidos.Text;

            // Lista para almacenar los campos no válidos
            List<string> camposNoValidos = new List<string>();

            // Validar el nombre
            if (string.IsNullOrEmpty(Nombre))
            {
                camposNoValidos.Add("Nombre(s)");
            }

            // Validar los apellidos
            if (string.IsNullOrEmpty(Apellidos))
            {
                camposNoValidos.Add("Apellidos");
            }

            // Validar la edad
            if (int.TryParse(txtedad.Text, out int edad))
            {
                Edad = edad;
            }
            else
            {
                camposNoValidos.Add("Edad");
            }

            // Validar el horario
            Horario = txthorario.Text;
            if (string.IsNullOrEmpty(Horario))
            {
                camposNoValidos.Add("Horario");
            }

            // Validar el salario
            if (decimal.TryParse(txtsalario.Text, out decimal salario))
            {
                Salario = salario;
            }
            else
            {
                camposNoValidos.Add("Salario");
            }

            // Validar la fecha de ingreso
            FechaIngreso = txtfechaingreso.Text;
            if (string.IsNullOrEmpty(FechaIngreso))
            {
                camposNoValidos.Add("Fecha de Ingreso");
            }

            // Validar el número de teléfono
            Telefono = txttelefono.Text;
            if (string.IsNullOrEmpty(Telefono))
            {
                camposNoValidos.Add("Número de Teléfono");
            }

            // Validar el CURP
            Curp = txtcurp.Text;
            if (string.IsNullOrEmpty(Curp))
            {
                camposNoValidos.Add("CURP");
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

        private void FormaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txthorario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
