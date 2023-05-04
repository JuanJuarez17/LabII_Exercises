using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary._08_C03
{
    public class Local : Llamada
    {
        #region ATTRIBUTES
        protected float costo; 
        #endregion

        #region CONSTRUCTOR
        public Local(float duracion, string nroDestino, string nroOrigen, float costo)
              : base(duracion, nroDestino, nroOrigen)
        {
            this.costo=costo;
        }

        public Local(Llamada llamada, float costo)
              : this (llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {
        }
        #endregion

        #region PROPERTIES
        public float CostoLLamada
        {
            get { return this.CalcularCosto(); }
        } 
        #endregion

        #region METHOD
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }
        public new string Mostrar() // Para no pisar el metodo Mostrar de la clase padre Llamada
                                    // Cuando usemos un obejto Local va a llamar al metodo Mostrar de local
                                    // Cuando usemos un obejto Llamada va a llamar al metodo Mostrar de llamada
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Local");
            sb.AppendLine(base.Mostrar()); // LLamo al metodo Mostrar de la clase padre
            sb.AppendLine($"Costo por minuto: {this.costo}");
            sb.AppendLine($"Costo total: {this.CostoLLamada}");
            return sb.ToString();
        }
        #endregion
    }
}
