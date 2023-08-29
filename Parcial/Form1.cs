using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LblCantidadeconomica_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string m, c;
            double monto, total;

            m = txtCantidaconomica.Text;
            c = lblResultado.Text;

            monto = double.Parse(txtCantidaconomica.Text);

            double[][] cantidades = {
                new double[] { 0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 3000000.01 }, // Desde
                new double[] { 500, 1000, 2000, 3000, 6000, 18000, 30000, 60000, 100000, 200000, 300000, 400000 },
                new double[] { 1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255 },
                new double[] { 0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45 },
            };

            total = cantidades
            





             
        




        private void txtCantidaconomica_TextChanged(object sender, EventArgs e)
            {

            }

        private void LblImpuestos_Click_1(object sender, EventArgs e)
        {

        }

    }
    }