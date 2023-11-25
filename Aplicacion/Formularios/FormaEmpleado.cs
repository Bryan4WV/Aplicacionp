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

        private bool ValidarCampo(TextBox textBox, string nombreCampo, string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errores.Add($"{nombreCampo}: {mensajeError}");
                return false;
            }

            return true;
        }

        private bool ValidarCampoNumerico(TextBox textBox, string nombreCampo, string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out _))
            {
                errores.Add($"{nombreCampo}: {mensajeError}");
                return false;
            }

            return true;
        }

        private bool ValidarCampoDecimal(TextBox textBox, string nombreCampo, string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !decimal.TryParse(textBox.Text, out _))
            {
                errores.Add($"{nombreCampo}: {mensajeError}");
                return false;
            }

            return true;
        }
        private string ObtenerCamposFaltantesMensaje()
        {
            return string.Join("\n", errores);
        }
        private void RealizarValidaciones()
        {
            errores.Clear();

            if (ValidarCampo(txtnombre, "Nombre", "El nombre es obligatorio"))
            {
                Nombre = txtnombre.Text;
            }

            if (ValidarCampo(txtapellidos, "Apellidos", "Los apellidos son obligatorios"))
            {
                Apellidos = txtapellidos.Text;
            }

            if (ValidarCampoNumerico(txtedad, "Edad", "La edad debe ser un valor numérico válido"))
            {
                Edad = int.Parse(txtedad.Text);
            }

            if (ValidarCampo(txthorario, "Horario", "El horario es obligatorio"))
            {
                Horario = txthorario.Text;
            }

            if (ValidarCampoDecimal(txtsalario, "Salario", "El salario debe ser un valor numérico válido"))
            {
                Salario = decimal.Parse(txtsalario.Text);
            }

            if (ValidarCampo(txtfechaingreso, "Fecha de Ingreso", "La fecha de ingreso es obligatoria"))
            {
                FechaIngreso = txtfechaingreso.Text;
            }

            if (ValidarCampo(txttelefono, "Teléfono", "El teléfono es obligatorio"))
            {
                Telefono = txttelefono.Text;
            }

            if (ValidarCampo(txtcurp, "CURP", "El CURP es obligatorio"))
            {
                Curp = txtcurp.Text;
            }

            if (errores.Count > 0)
            {
                string mensajeError = "Los siguientes campos son necesarios o contienen datos no válidos:\n\n";
                mensajeError += string.Join("\n", errores);

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Resto del código...

            DialogResult = DialogResult.OK;
            Close();
        
    }

        public FormaEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                Nombre = txtnombre.Text;
                Apellidos = txtapellidos.Text;
                Edad = Convert.ToInt32(txtedad.Text);
                Horario = txthorario.Text;
                Salario = Convert.ToDecimal(txtsalario.Text);
                FechaIngreso = txtfechaingreso.Text;
                Telefono = txttelefono.Text;
                Curp = txtcurp.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ValidarDatos())
            {
                Nombre = txtnombre.Text;
                Apellidos = txtapellidos.Text;
                Edad = Convert.ToInt32(txtedad.Text);
                Horario = txthorario.Text;
                Salario = Convert.ToDecimal(txtsalario.Text);
                FechaIngreso = txtfechaingreso.Text;
                Telefono = txttelefono.Text;
                Curp = txtcurp.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string mensajeError = "Por favor, ingrese datos válidos en los siguientes campos:\n";
                mensajeError += ObtenerCamposFaltantesMensaje();
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarDatos()
        {
            errores.Clear();

            if (!ValidarCampo(txtnombre, "Nombre", "El nombre es obligatorio"))
            {
                return false;
            }

            if (!ValidarCampo(txtapellidos, "Apellidos", "Los apellidos son obligatorios"))
            {
                return false;
            }

            if (!ValidarCampoNumerico(txtedad, "Edad", "La edad debe ser un valor numérico válido"))
            {
                return false;
            }

            if (!ValidarCampo(txthorario, "Horario", "El horario es obligatorio"))
            {
                return false;
            }

            if (!ValidarCampoDecimal(txtsalario, "Salario", "El salario debe ser un valor numérico válido"))
            {
                return false;
            }

            if (!ValidarCampo(txtfechaingreso, "Fecha de Ingreso", "La fecha de ingreso es obligatoria"))
            {
                return false;
            }

            if (!ValidarCampo(txttelefono, "Teléfono", "El teléfono es obligatorio"))
            {
                return false;
            }

            if (!ValidarCampo(txtcurp, "CURP", "El CURP es obligatorio"))
            {
                return false;
            }

            return true;
        


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
