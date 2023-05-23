using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _10_ClassLibrary._10_02;

namespace _10_02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txb_Kilometros.Text == string.Empty ||this.txb_Litros.Text == string.Empty)
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio");
                }
                this.rtb_Mensaje.Text = $"km/hs: {Calculador.Calcular(int.Parse(this.txb_Kilometros.Text), int.Parse(this.txb_Litros.Text))}";

            }
            // Capturo la Exception que lance en caso de que alguno de los txb sea nulo
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Calturo la excepcion que lanza el int.Parse
            catch (FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            // Captulo la excepcion que lanza Calcular si el divisor es cero
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            // Capturo algun tipo de Exception inesperada
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
