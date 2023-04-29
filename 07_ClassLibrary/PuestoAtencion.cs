using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_ClassLibrary
{
    public class PuestoAtencion
    {
        // Propiedad enumerada
        // El atributo puesto del tipo EPuesto puede defirnirse solo entre Caja1 y Caja2
        public enum EPuesto
        {
            Caja1,
            Caja2,
        }
        private static int numeroActual;
        private EPuesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto inputPuesto)
        {
            this.puesto = inputPuesto;
        }

        public static int NumeroActual
        {
            get { return numeroActual + 1; }
        }

        public bool Atender(Cliente inputCliente)
        {
            if (inputCliente is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
