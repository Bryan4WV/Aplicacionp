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
            

            string usuario = textUsuario.Text;
            string contraseña = textContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Aquí puedes agregar código para guardar el usuario y la contraseña en una base de datos o en otro sistema de almacenamiento.
                MessageBox.Show("Registro exitoso. Usuario: " + usuario, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            FormaBienvenido otraVentana = new FormaBienvenido();
            otraVentana.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
