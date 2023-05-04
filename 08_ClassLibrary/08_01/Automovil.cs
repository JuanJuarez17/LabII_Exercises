using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(Colores color, short cantidadPuertas, short cantidadRuedas, short cantidadMarchas, int cantidadPasajeros) 
                  : base(color, cantidadPuertas, cantidadRuedas)
        {
            this.cantidadMarchas=cantidadMarchas;
            this.cantidadPasajeros=cantidadPasajeros;
        }
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Auto");
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Cantidad de pasajeros: {this.cantidadPasajeros}");
            sb.AppendLine(this.MostrarVehiculo());
            return sb.ToString();
        }
    }
}
