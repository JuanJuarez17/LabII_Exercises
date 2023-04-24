using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01
{
    public partial class Saludo : Form
    {
        private string titulo;
        private string mensaje;
        private Saludo()
        {
            InitializeComponent();
        }
        public Saludo(string titulo, string mensaje) : this()
        {
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void Saludo_Load(object sender, EventArgs e)
        {
            this.lbl_Titulo.Text = this.titulo;
            this.lbl_Mensaje.Text = this.mensaje;
        }

        private void Saludo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
