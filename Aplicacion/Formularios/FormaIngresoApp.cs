﻿using System;
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

            // Lógica de autenticación (debes ajustar esto según tus necesidades)
            if (usuario == "Bryan" && contraseña == "witrago")
            {
                // Credenciales correctas, procede con el código de inicio de sesión
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormaDatosCaps Inicio = new FormaDatosCaps();
                Inicio.Show();
                this.Hide();
            }
            else
            {
                // Credenciales incorrectas, muestra un mensaje de error
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Las credenciales son incorrectas, muestra un mensaje de error adecuado
            if (usuario != "Bryan" || contraseña != "witrago")
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Credenciales correctas, procede con la lógica de inicio de sesión
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Resto del código de inicio de sesión...
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
