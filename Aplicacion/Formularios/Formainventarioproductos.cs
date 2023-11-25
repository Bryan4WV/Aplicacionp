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
    public partial class Formainventarioproductos : Form
    {
        public Formainventarioproductos()
        {
            InitializeComponent();

            AgregarDatosAlDataGridView();
        }
        private void AgregarDatosAlDataGridView()
        {
            // Agrega 15 filas con los datos proporcionados
            dataGridView1.Rows.Add("1", "Sabritas Originales", "2024-10-08", "42g", "18", "Sabritas", "2.3g", "3g", "2g", "16g", "14g", "4g", "6g", "Original");
            dataGridView1.Rows.Add("2", "M&M Caramel Cold Brew", "2028-11-07", "22g", "35", "M&M´S", "54g", "68g", "35g", "27g", "29g", "19g", "14g", "Caramel Cold Brew");
            dataGridView1.Rows.Add("3", "M&M SnowBalls", "2026-11-06", "17g", "45", "M&M´S", "64g", "48g", "45g", "57g", "39g", "69g", "44g", "SnowBall");
            dataGridView1.Rows.Add("4", "Agua Ciel", "2024-11-24", "1L", "19", "Ciel", "0g", "1g", "13g", "0.1g", "0.2g", "0g", "0.3g", "Natural");
            dataGridView1.Rows.Add("5", "Agua Ciel", "2024-12-24", "1L", "23", "Ciel", "6g", "4g", "16g", "1.3g", "1.8g", "4g", "3g", "Jamaica");
            dataGridView1.Rows.Add("6", "Agua Ciel", "2024-12-24", "1L", "22", "Ciel", "6g", "4g", "16g", "1.3g", "1.8g", "4g", "3g", "Guayaba");
            dataGridView1.Rows.Add("7", "Agua Ciel", "2024-10-04", "1L", "21", "Ciel", "13g", "4g", "16g", "1.3g", "1.8g", "4g", "3g", "Limon");
            dataGridView1.Rows.Add("8", "Sabritas Adobadas", "2025-09-04", "34g", "16", "Sabritas", "2.6g", "3.3g", "2.2g", "17g", "15g", "4.3g", "6.1g", "Adobado");
            dataGridView1.Rows.Add("9", "Sabritas Habanero", "2024-06-07", "40g", "19", "Sabritas", "2.9g", "3.8g", "2.6g", "19g", "17g", "4.4g", "6.7g", "Habanero");
            dataGridView1.Rows.Add("10", "Sabritas Sal & Limon", "2026-07-26", "68g", "14", "Sabritas", "3.7g", "4.3g", "3.8g", "21g", "23g", "5.6g", "8.2g", "Sal & Limon");
            dataGridView1.Rows.Add("11", "Coca Cola Original", "2024-09-25", "600ml", "21", "Coca Cola", "6.2g", "62g", "7g", "24g", "34g", "23g", "1g", "Original");
            dataGridView1.Rows.Add("12", "Coca Cola Light", "2024-08-15", "600ml", "19", "Coca Cola", "24g", "31g", "3.1g", "12g", "17g", "11g", "2g", "Light");
            dataGridView1.Rows.Add("13", "Coca Cola Zero", "2024-04-05", "600ml", "22", "Coca Cola", "11g", "13g", "1.5g", "6g", "7g", "6g", "1g", "Zero");
            dataGridView1.Rows.Add("14", "Coca Cola Coffee", "2024-08-15", "600ml", "26", "Coca Cola", "48g", "67g", "8.9g", "31g", "26g", "45g", "21g", "Coffee");
            dataGridView1.Rows.Add("15", "M&M Original", "2027-02-18", "32g", "32", "M&M´S", "72g", "86g", "33g", "65g", "67g", "31g", "54g", "Original");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
