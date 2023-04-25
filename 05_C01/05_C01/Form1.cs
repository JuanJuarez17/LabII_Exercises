using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace _05_C01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cotzEuro = string.Format("{0:0.00}", Euro.GetCotizacion());
            string cotzDolar = string.Format("{0:0.00}", Dolar.GetCotizacion());
            string cotzPeso = string.Format("{0:0.00}", Peso.GetCotizacion());
            txb_CotizacionEuro.Text = cotzEuro;
            txb_CotizacionDolar.Text = cotzDolar;
            txb_CotizacionPeso.Text = cotzPeso;
            btn_AtcCotz.ImageIndex = 0;
            txb_Euro.Enabled = false;
            txb_Dolar.Enabled = false;
            txb_Peso.Enabled = false;
            txb_EuroAEuro.ReadOnly = true;
            txb_EuroAEuro.BackColor = System.Drawing.SystemColors.Window;
            txb_EuroADolar.ReadOnly = true;
            txb_EuroADolar.BackColor = System.Drawing.SystemColors.Window;

            txb_EuroAPeso.ReadOnly = true;
            txb_EuroAPeso.BackColor = System.Drawing.SystemColors.Window;

            txb_DolarAEuro.ReadOnly = true;
            txb_DolarAEuro.BackColor = System.Drawing.SystemColors.Window;

            txb_DolarADolar.ReadOnly = true;
            txb_DolarADolar.BackColor = System.Drawing.SystemColors.Window;

            txb_DolarAPeso.ReadOnly = true;
            txb_DolarAPeso.BackColor = System.Drawing.SystemColors.Window;

            txb_PesoAEuro.ReadOnly = true;
            txb_PesoAEuro.BackColor = System.Drawing.SystemColors.Window;

            txb_PesoADolar.ReadOnly = true;
            txb_PesoADolar.BackColor = System.Drawing.SystemColors.Window;

            txb_PesoAPeso.ReadOnly = true;
            txb_PesoAPeso.BackColor = System.Drawing.SystemColors.Window;

        }
        private void btn_AtcCotz_Click(object sender, EventArgs e)
        {
            if (btn_AtcCotz.ImageIndex == 0)
            {
                btn_AtcCotz.ImageIndex = 1;
                txb_CotizacionEuro.Enabled = false;
                txb_CotizacionDolar.Enabled = false;
                txb_CotizacionPeso.Enabled = false;
                txb_Euro.Enabled = true;
                txb_Dolar.Enabled = true;
                txb_Peso.Enabled = true;
            }
            else
            {
                btn_AtcCotz.ImageIndex = 0;
                txb_CotizacionEuro.Enabled = true;
                txb_CotizacionDolar.Enabled = true;
                txb_CotizacionPeso.Enabled = true;
                txb_Euro.Enabled = false;
                txb_Dolar.Enabled = false;
                txb_Peso.Enabled = false;
            }
        }

        private void txb_CotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotzEuro;

            if (!double.TryParse(txb_CotizacionEuro.Text, out cotzEuro))
            {
                txb_CotizacionEuro.Focus();
                btn_AtcCotz.Enabled = false;
            }
            else
            {
                Euro.SetCotizacionEuro(cotzEuro);
                btn_AtcCotz.Enabled = true;
            }
        }
        private void txb_CotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotzPeso;

            if (!double.TryParse(txb_CotizacionPeso.Text, out cotzPeso))
            {
                txb_CotizacionPeso.Focus();
                btn_AtcCotz.Enabled = false;
            }
            else
            {
                Peso.SetCotizacionPeso(cotzPeso);
                btn_AtcCotz.Enabled = true;
            }
        }
        private void btn_ConvertEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txb_Euro.Text, out double value))
            {
                Euro euroAEuro = value;
                txb_EuroAEuro.Text = string.Format("{0:0.00}", euroAEuro.GetCantidad());

                Dolar euroADolar = (Dolar)euroAEuro;
                txb_EuroADolar.Text = string.Format("{0:0.00}", euroADolar.GetCantidad());

                Peso euroAPeso = (Peso)euroAEuro;
                txb_EuroAPeso.Text = string.Format("{0:0.00}", euroAPeso.GetCantidad());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void btn_ConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txb_Dolar.Text, out double value))
            {
                Dolar dolarADolar = value;
                txb_DolarADolar.Text = string.Format("{0:0.00}", dolarADolar.GetCantidad());

                Euro dolarAEuro = (Euro)dolarADolar;
                txb_DolarAEuro.Text = string.Format("{0:0.00}", dolarAEuro.GetCantidad());

                Peso dolarAPeso = (Peso)dolarADolar;
                txb_DolarAPeso.Text = string.Format("{0:0.00}", dolarAPeso.GetCantidad());

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_ConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txb_Peso.Text, out double value))
            {
                Peso pesoAPeso = value;
                txb_PesoAPeso.Text = string.Format("{0:0.00}", pesoAPeso.GetCantidad());

                Euro pesoAEuro = (Euro)pesoAPeso;
                txb_PesoAEuro.Text = string.Format("{0:0.00}", pesoAEuro.GetCantidad());

                Dolar dolarAPeso = (Dolar)pesoAPeso;
                txb_PesoADolar.Text = string.Format("{0:0.00}", dolarAPeso.GetCantidad());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void txb_CotizacionDolar_LostFocus(object sender, EventArgs e)
        {
            txb_CotizacionDolar.Text = string.Format("{0:0.00}", 1);
        }
    }
}
