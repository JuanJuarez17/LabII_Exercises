using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary._08_C03
{
    #region ENUM PROPERTY
    public enum TipoLlamada // Lo declaro fuera de la clase para en centralita poder usarlo sin tener que llamar
                            // Llamada.TipoLlamada
    {
        Local,
        Provincial,
        Todas,
    }
    #endregion
    public class Llamada
    {
        #region ATTRIBUTTES
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region CONSTRUCTOR
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion=duracion;
            this.nroDestino=nroDestino;
            this.nroOrigen=nroOrigen;
        } 
        #endregion

        #region PROPERTIES
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion

        #region METHODS
        public static int OrdeanarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.Duracion - llamada2.Duracion);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Nro. Origen: {this.NroOrigen}");
            sb.AppendLine($"Nro. Destino: {this.NroDestino}");
            return sb.ToString();
        } 
        #endregion

    }
}
