using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(Colores color, short cantidadPuertas, short cantidadRuedas, short cilindrada) : base(color, cantidadPuertas, cantidadRuedas)
        {
            this.cilindrada=cilindrada;
        }
        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Moto");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine(this.MostrarVehiculo());
            return sb.ToString();
        }
    }
}
