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
    public partial class Registro : Form
    {
        private Ingresante auxIngresante;
        public Registro()
        {
            InitializeComponent();
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            ltb_Pais.Items.Add("Argentina");
            ltb_Pais.Items.Add("Chile");
            ltb_Pais.Items.Add("Uruguay");
            this.rdb_Nobinario.Checked = true; // Para validar el ingreso de algun genero
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_Nombre.Text) ||
                string.IsNullOrWhiteSpace(this.txb_Direccion.Text) ||
                string.IsNullOrWhiteSpace(ltb_Pais.Text) ||
                this.nud_Edad.Value == 0)
            {
                MessageBox.Show("Faltan ingresar parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = this.txb_Nombre.Text;
                string direccion = this.txb_Direccion.Text;
                string pais = ltb_Pais.Text;
                int edad = (int)this.nud_Edad.Value;
                string genero = "";
                if (this.rdb_Masculino.Checked)
                {
                    genero = this.rdb_Masculino.Text;
                }
                else if (this.rdb_Femenino.Checked)
                {
                    genero = this.rdb_Femenino.Text;
                }
                else if (this.rdb_Nobinario.Checked)
                {
                    genero = this.rdb_Nobinario.Text;
                }
                string[] curso = new string[3];
                if (chb_CSharp.Checked)
                {
                    curso[0] = chb_CSharp.Text;
                }
                if (chb_CPlus.Checked)
                {
                    curso[1] = chb_CPlus.Text;
                }
                if (chb_JavaScript.Checked)
                {
                    curso[2] = chb_JavaScript.Text;
                }
                auxIngresante = new Ingresante(nombre, direccion, genero, pais, curso, edad);
                Ingreso frmIngreso = new Ingreso(auxIngresante);
                frmIngreso.ShowDialog();
            }
        }
    }
}
