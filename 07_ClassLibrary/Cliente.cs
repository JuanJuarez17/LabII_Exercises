using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassLibrary
{
    public class Cliente
    {
        private string nombre;
        private int numero;
        public Cliente(int inputnumero)
        {
            this.numero = inputnumero;
            this.nombre = "Sin nombre";
        }
        public Cliente(string inputNombre, int inputnumero) : this(inputnumero)
        {
            this.nombre = inputNombre;
        }

        // Propiedades comunes
        // retorna el atributo numero de un objeto Cliente
        public int Numero
        {
            get { return this.numero; }
        }
        //Retorna el atributo nombre de un objeto Cliente
        //Setea el atributo nombre de un objeto Cliente
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return c1.Numero == c2.Numero;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
