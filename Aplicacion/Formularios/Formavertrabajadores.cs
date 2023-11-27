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
    public partial class Formavertrabajadores : Form
    {
        public Formavertrabajadores()
        {
            InitializeComponent();

            AddDataToDataGridView();
        }

        private void AddDataToDataGridView()
        {
            // Define the data to be added
            string[,] data = {
                { "Bryan Gael", "Witrago Vargas", "2022-08-11", "4200", "12:00 - 8:00", "21", "418", "123WvB7689ed", "1" },
                { "Fernando", "Vazquez Montaño", "2022-06-12", "3900", "12:00 - 8:00", "22", "418", "123VMF7689ed", "2" },
                { "Diego Alejandro", "Muñoz Mendez", "2022-05-15", "3800", "12:00 - 8:00", "20", "414", "123Wvj2i2323", "3" },
                { "Rene Alejandro", "Gonzalez Aviles", "2022-04-17", "3200", "12:00 - 8:00", "25", "412", "123Wjb2ui4ed", "4" },
                { "Paola dibanhi", "Castillo Aviles", "2022-10-11", "3700", "12:00 - 8:00", "19", "418", "123Wknkw12", "5" },
                { "omar enrique", "Cano gomez", "2022-10-11", "3700", "12:00 - 8:00", "22", "448", "123Wkiksnsww", "6" },
                { "Jose Luis", "Rosas Negrete", "2022-02-19", "3600", "12:00 - 8:00", "28", "418", "123Wkniknww", "7" },
                { "Cristian Fernando", "Cruz Ramirez", "2022-01-01", "3500", "12:00 - 8:00", "27", "418", "123Wkom1231", "8" },
                { "Jesus Alexis", "Salazar escalantee", "2022-04-03", "3200", "12:00 - 8:00", "27", "123", "123Wkom1212", "9" },
                { "Amneris", "Aguilar Zanella", "2022-04-05", "3100", "12:00 - 8:00", "27", "123", "123Wkolojq4", "10" },
                { "Jesus", "Paredes Rayas", "2022-07-05", "3150", "12:00 - 8:00", "28", "123", "loiaolojq4", "11" },
                { "Fernando Antonio", "Gonzalez Serna", "2022-07-05", "2900", "12:00 - 8:00", "32", "876", "123Wkolojq4", "12" },
                { "Fernanda ", "Gonzalez Lopez", "2022-07-05", "2700", "12:00 - 8:00", "34", "876", "jqud7qeqw", "13" },
                { "Ximena", "Piedra cruz", "2022-07-30", "2500", "12:00 - 8:00", "30", "876", "jqud7qev34qw", "14" },
                { "Kevin", "Rendon Raya", "2022-07-23", "2200", "12:00 - 8:00", "36", "898", "jqswetws4qw", "15" }
            };

            // Add data to the DataGridView
            for (int i = 0; i < data.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6], data[i, 7], data[i, 8]);
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
