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
            double monto, cantida;

            m = txtCantidaconomica.Text;
            c = txtValorapagar.Text;

            cantida = double.Parse(txtValorapagar.Text);

            double[][] pago = {


                
        }

        private void txtValorapagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void LblValorapagar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadeconomica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
