using _05_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_02
{
    public partial class Ingreso : Form
    {
        private Ingresante auxIngresante;
        private Ingreso()
        {
            InitializeComponent();
        }
        public Ingreso(Ingresante bufferIngresante) : this()
        {
            this.auxIngresante = bufferIngresante;
        }
        private void Ingreso_Load(object sender, EventArgs e)
        {
            this.lbl_DetalleAl.Text = this.auxIngresante.MostrarAlumno();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
