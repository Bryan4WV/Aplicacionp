using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Formas;
using Aplicacion.Formularios;

namespace Aplicacion
{
    public partial class Formingresoapp : Form
    {


        public Formingresoapp()
        {
            InitializeComponent();


        }
   

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ValidarCredenciales();


        }

        private void buttonSigForm_Click(object sender, EventArgs e)
        {
            {
            
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Formulario2 registroo = new Formulario2();
            registroo.Show();
            this.Hide();
            
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }
        private void ValidarCredenciales()
        {
            string usuario = textUsuario.Text;
            string contraseña = textContraseña.Text;

            // Verificar si el usuario y la contraseña no están vacíos
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Modificar la lógica de autenticación para permitir diferentes usuarios y contraseñas
                if ((usuario == "Bryan_WV" && contraseña == "witrago") ||
                    (usuario == "Diego_MM" && contraseña == "mendez") ||
                    (usuario == "Jose_RN" && contraseña == "negrete") ||
                    (usuario == "Cristian_CR" && contraseña == "cruz") ||
                    (usuario == "Fernando_VM" && contraseña == "montaño"))
                {
                    // Credenciales correctas, procede con la lógica de inicio de sesión
                    MessageBox.Show("Inicio de sesión exitoso", "Bienvenido a la base de datos de oxxo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resto del código de inicio de sesión...

                    // Ejemplo: Abrir una nueva forma después del inicio de sesión
                    FormaDatosCaps Inicio = new FormaDatosCaps();
                    Inicio.Show();
                    this.Hide();
                }
                else
                {
                    // Credenciales incorrectas, muestra un mensaje de error adecuado
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
