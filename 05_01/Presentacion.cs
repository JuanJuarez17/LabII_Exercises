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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }
        private void Presentacion_Load(object sender, EventArgs e)
        {
            cbb_Materias.Items.Add("Programacion I");
            cbb_Materias.Items.Add("Sistemas de procesamiento de datos");
            cbb_Materias.Items.Add("Matematica");
            cbb_Materias.Items.Add("Ingles I");
            cbb_Materias.Items.Add("Laboratorio de computacion I");
            cbb_Materias.Items.Add("Programacion II");
            cbb_Materias.Items.Add("Arquitectura y sistemas operativos");
            cbb_Materias.Items.Add("Estadistica");
            cbb_Materias.Items.Add("Ingles II");
            cbb_Materias.Items.Add("Laboratorio de computacion II");
            cbb_Materias.Items.Add("Metodologia de la investigacion");
            cbb_Materias.SelectedIndex = 0;
        }
        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_Nombre.Text) || string.IsNullOrWhiteSpace(this.txb_Apellido.Text))
            {
                string msbTitulo = "Error";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se deben completar los siguientes campos:");
                if (string.IsNullOrWhiteSpace(this.txb_Nombre.Text))
                {
                    sb.AppendLine("Nombre");
                }
                if (string.IsNullOrWhiteSpace(this.txb_Apellido.Text))
                {
                    sb.AppendLine("Apellido");
                }
                string msbMensaje = sb.ToString();
                MessageBox.Show(msbMensaje, msbTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string titulo = "¡Hola, Windows Forms!";
                string mensaje = "Soy " + this.txb_Nombre.Text + " " + this.txb_Apellido.Text
                               + " y mi materia favorita es " + cbb_Materias.SelectedItem + ".";
                Saludo frmSaludo = new Saludo(titulo, mensaje);
                frmSaludo.Show();
                this.Hide();
            }
        }
    }
}
