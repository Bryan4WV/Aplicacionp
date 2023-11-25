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

namespace Aplicacion.Formas
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string email = txtemail.Text;
            string contraseña = txtcontraseña.Text;
            string confirmarContraseña = txtconfirmarContraseña.Text;
            string telefono = txttelefono.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value; // Obtener la fecha seleccionada.
            string sexo = txtsexo.Text;

            // Crear una lista para almacenar los nombres de los campos faltantes.
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                camposFaltantes.Add("Nombre");
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                camposFaltantes.Add("Apellidos");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                camposFaltantes.Add("Email");
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                camposFaltantes.Add("Contraseña");
            }

            if (string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                camposFaltantes.Add("Confirmar Contraseña");
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                camposFaltantes.Add("Teléfono");
            }

            if (string.IsNullOrWhiteSpace(sexo))
            {
                camposFaltantes.Add("Sexo");
            }

            if (camposFaltantes.Count > 0)
            {
                string mensaje = "Por favor, complete los siguientes campos:";
                foreach (string campo in camposFaltantes)
                {
                    mensaje += "\n- " + campo;
                }
                MessageBox.Show(mensaje, "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!email.Contains("@") || !IsValidEmail(email))
            {
                MessageBox.Show("El correo electrónico no es válido. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsPhoneNumberValid(telefono))
            {
                MessageBox.Show("El número de teléfono contiene caracteres no válidos. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ContainsNumbersOrSpaces(nombre) || ContainsNumbersOrSpaces(apellidos))
            {
                MessageBox.Show("El nombre y apellidos no deben contener espacios ni números. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registro exitoso. Bienvenido, " + nombre + " " + apellidos + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return !phoneNumber.Any(char.IsLetter);
        }
        private bool ContainsNumbersOrSpaces(string text)
        {
            return text.Any(char.IsDigit) || text.Any(char.IsWhiteSpace);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Formingresoapp inicia = new Formingresoapp();
            inicia.Show();
            this.Hide();
        }
    }
}
