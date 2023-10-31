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
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public int Edad { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }
        public FormaEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = txtnombre.Text;
            Apellidos = txtapellidos.Text;

            if (int.TryParse(txtedad.Text, out int edad))
            {
                Edad = edad;
            }
            else
            {
                MessageBox.Show("La edad no es válida. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cargo = txtcargo.Text;

            if (decimal.TryParse(txtsalario.Text, out decimal salario))
            {
                Salario = salario;
            }
            else
            {
                MessageBox.Show("El salario no es válido. Por favor, verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}
