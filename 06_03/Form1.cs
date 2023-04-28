using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            // 1 - Armo el diccionario con las palabras encontradas y sus repeticiones
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            // 2 Le pasamos el diccionario a ObtenerPodio el cual lo ordenara y devolvera como lista clave valor
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);

            // 3 - Muestro el podio de las palabras ma repetidas
            MostrarPodio(podio);    
        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            // Guardo el texto recibido en un string
            string texto = rtb_Entrada.Text;

            // Recibe un string y lo separa en funcion del caracter que le indique
            // Devuelve un array de string de cantidad de elementos cuyas separaciones haga.
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Creo el diccionario
            // La clave (string) va a ser la palabra
            // El valor sera la cantidad de repeticiones de cada palabra
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            // Mediante un foreach recorro las palabras y las incorporo al diccionario y aumento su repeticion
            foreach (string item in palabras)
            {
                // Si el diccionario contiene la clave
                if (contadorPalabras.ContainsKey(item))
                {
                    // Accedo al diccionario por el indice e incremento su valor
                    contadorPalabras[item]++;
                }
                // Si el diccionario NO contiene la clave
                else
                {
                    // Agrego la palabra al diccionario e inicializo si valor en 1
                    contadorPalabras.Add(item, 1);
                }
            }
            return contadorPalabras;
        }
        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            // 1 - Transformo el diccionario en lista de clave-valor
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();

            // 2 - Ordeno la lista de forma ascendente
            podio.Sort(CompararCantidadRepeticiones);
            // Para apasarle un metodo al sort, el mismo debe recibir 2 elementos de un mismo tipo y retornar un int

            return podio;
        }
        // Metodo para mostrar el podio
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            // Creo un sb para mostar el podio
            StringBuilder sb = new StringBuilder();

            // Si mi lista de palabras esta vacia
            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras.");
            }
            // Si tiene palabras
            else
            {
                // Si solo quiero los primero 3 uso un for ya que el foreach recorre todo
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
                //// Recorro la lista e imprimo clave y valor
                //foreach (KeyValuePair<string, int> item in podio)
                //{
                //    sb.AppendLine($"Palabra: {item.Key} - Cantidad: {item.Value}");
                //}
            }
            // Muestro el podio en un box
            MessageBox.Show(sb.ToString(), "Podio");
        }
        // Metodo para ordenamiento
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, 
                                                 KeyValuePair<string, int> segundoElemento)
        {
            if (primerElemento.Value < segundoElemento.Value)
            {
                return 1;
            }

            if (primerElemento.Value > segundoElemento.Value)
            {
                return -1;
            }
            // Es lo mismo que
            // return segundoElemento.Value - primerElemento.Value;
            return 0;
        }
    }
}
