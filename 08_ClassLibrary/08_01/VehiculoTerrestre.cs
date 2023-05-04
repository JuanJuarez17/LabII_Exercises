using System;
using System.Text;

namespace _08_ClassLibrary
{
    public class VehiculoTerrestre
    {
        protected Colores color;
        protected short cantidadPuertas;
        protected short cantidadRuedas;

        public VehiculoTerrestre(Colores color, short cantidadPuertas, short cantidadRuedas)
        {
            this.color=color;
            this.cantidadPuertas=cantidadPuertas;
            this.cantidadRuedas=cantidadRuedas;
        }

        public string MostrarVehiculo()
        {
            StringBuilder sb = new StringBuilder();
            //if (this is Automovil)
            //{
            //    sb.AppendLine("Tipo: Auto");

            //}
            //else if (this is Moto)
            //{
            //    sb.AppendLine("Tipo: Moto");
            //}
            //else if (this is Camion)
            //{
            //    sb.AppendLine("Tipo: Camion");
            //}
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Cantidad ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad puertas: {this.cantidadPuertas}");
            return sb.ToString();
        }
    }
}
