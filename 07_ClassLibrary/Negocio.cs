using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassLibrary
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string inputNombre) : this()
        {
            this.nombre = inputNombre;
        }

        // Propiedades
        // Permite devolver un objeto cliente de un indice de la lista cliente del objeto negocio
        public Cliente Cliente
        {
            get { return clientes.Dequeue(); } // Elimina una instancia de la lista clientes del objeto negocio
            set { _ = this + value; }
        }

        // Devuelve la cantidad de indices de la lista cliente de un objeto negocio
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

        public static bool operator == (Negocio inputNegocio, Cliente inputCliente)
        {
            foreach (Cliente item in inputNegocio.clientes)
            {
                if (item == inputCliente)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio inputNegocio, Cliente inputCliente)
        {
            return !(inputNegocio == inputCliente);
        }
        public static bool operator +(Negocio inputNegocio, Cliente inputCliente)
        {
            if (inputNegocio != inputCliente)
            {
                inputNegocio.clientes.Enqueue(inputCliente);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio inputNegocio)
        {
            if (inputNegocio.clientes.Count > 0)
            {
                return inputNegocio.caja.Atender(inputNegocio.Cliente);
            }
            return false;
        }
    }
}
