using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double serieUno (Int16 numRepeticiones)
        {
            double suma = 0;
            if (numRepeticiones == 0)
                return suma;
            else
            {
                for (int posicion = 1; posicion <= numRepeticiones; posicion++)
                {
                    if (posicion % 2 == 1)
                        suma += 4.0 / (posicion + (posicion - 1)); //double
                    else
                        suma -= 4.0 / (posicion + (posicion - 1));
                }
                return suma;
            }
        }

        private int factorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
                factorial *= i;
            return factorial;
        }

        private int serieDos(Int16 numRepeticiones)
        {
            int suma = 0;
            for (int posición = 1; posición <= numRepeticiones; posición++)
                suma += factorial(posición);
            return suma;
        }

        private void btnSerie1_Click(object sender, EventArgs e)
        {
            Int16 numRepeticiones = Convert.ToInt16(txtNoRepetticiones.Text);
            txtResultados.Text = Convert.ToString(serieUno(numRepeticiones));
        }

        private void btnSerie2_Click(object sender, EventArgs e)
        {
            Int16 numRepeticiones = Convert.ToInt16(txtNoRepetticiones.Text);
            txtResultados.Text = Convert.ToString(serieDos(numRepeticiones));
        }
    }
}
