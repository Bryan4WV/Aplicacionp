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
    public partial class FormaBienvenido : Form
    {
        public FormaBienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formingresoapp IngresoApp = new Formingresoapp();
            IngresoApp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario2 registro2 = new Formulario2();
            registro2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormaEmpleado empleadoform = new FormaEmpleado();
            empleadoform.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormaProducto productoform = new FormaProducto();
            productoform.Show();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaDatosCaps capturardatos = new FormaDatosCaps();
            capturardatos.Show();
        }

        private void FormaBienvenido_Load(object sender, EventArgs e)
        {

        }
    }
}
