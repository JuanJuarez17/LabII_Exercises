using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(Colores color, short cantidadPuertas, short cantidadRuedas, short cantidadMarchas, int pesoCarga)
               : base(color, cantidadPuertas, cantidadRuedas)
        {
            this.cantidadMarchas=cantidadMarchas;
            this.pesoCarga=pesoCarga;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Camion");
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Peso de la carga: {this.pesoCarga}");
            sb.AppendLine(this.MostrarVehiculo());
            return sb.ToString();
        }
    }
}
