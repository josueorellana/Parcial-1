using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adeleparcialejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtimpuestos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal cantidad = decimal.Parse(txtcantidad.Text);

            decimal impuesto = calcularImpuesto(cantidad);
            string impuestoStr = impuesto.ToString("0.00");

            txtimpuestos.Text = impuesto.ToString();
        }

        private decimal calcularImpuesto(decimal cantidad)
        {

            int rango = encontrarRango(cantidad);

            decimal precio = tablaPrecios[rango];
            decimal adicional = tablaAdicional[rango];
            decimal impuesto = (cantidad - tablaDesde[rango]) * adicional / 1000 + precio;

            return impuesto;
        }

        private int encontrarRango(decimal cantidad)
        {
            for (int i = 0; i < tablaDesde.Length; i++)
            {
                if (cantidad >= tablaDesde[i] && cantidad <= tablaHasta[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private static readonly decimal[] tablaPrecios = new decimal[] { 1.5m, 1.5m, 3m, 6m, 9m, 15m, 39m, 63m, 93m, 125m, 195m, 255m, 300m, 340m, 490m };
        private static readonly decimal[] tablaAdicional = new decimal[] { 0m, 3m, 3m, 3m, 2m, 2m, 2m, 1m, 0.8m, 0.7m, 0.6m, 0.45m, 0.4m, 0.30m, 0.18m };
        private static readonly decimal[] tablaDesde = new decimal[] { 0.01m, 500m, 1000.01m, 2000.01m, 3000.01m, 8000.01m, 18000.01m, 30000.01m, 60000.01m, 100000.01m, 200000.01m, 300000.01m, 400000.01m, 500000.01m, 1000000.01m };
        private static readonly decimal[] tablaHasta = new decimal[] { 500m, 1000m, 2000m, 3000m, 6000m, 18000m, 30000m, 60000m, 100000m, 200000m, 300000m, 400000m, 500000m, 1000000m, 99999999m };
    }
}