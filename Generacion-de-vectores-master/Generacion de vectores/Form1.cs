using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generacion_de_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[5];

            numeros[0] = 23455;
            numeros[1] = 6567;
            numeros[2] = 2568;
            numeros[3] = 4454;
            numeros[4] = 4444;
            listavectores.Items.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {

                listavectores.Items.Add(numeros[i]);
            }
        }
    }
}
