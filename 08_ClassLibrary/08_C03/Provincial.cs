using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary._08_C03
{
    public class Provincial : Llamada
    {
        #region ATTRIBUTES
        protected Franja franjaHoraria;
        #endregion

        #region CONSTRUCTOR
        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja franjaHoraria)
           : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria=franjaHoraria;
        }
        public Provincial(Llamada llamada, Franja franjaHoraria)
                   : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, franjaHoraria)
        {
        }
        #endregion

        #region PROPERTIES
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        } 
        #endregion

        #region METHODS
        public float CalcularCosto()
        {
            float valor;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    valor = 0.99f;
                    break;
                case Franja.Franja_2:
                    valor = 1.25f;
                    break;
                case Franja.Franja_3:
                    valor = 0.66f;
                    break;
                default:
                    valor = 0;
                    break;
            }
            return this.Duracion * valor;
        }
        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        } 
        #endregion
    }
}
