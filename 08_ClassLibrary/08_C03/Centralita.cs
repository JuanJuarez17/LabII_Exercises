using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassLibrary._08_C03
{
    public class Centralita
    {
        #region ATTRIBUTES
        protected string razonSocial;
        private List<Llamada> listaDeLlamadas;
        #endregion

        #region CONSTRUCTOR
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial=razonSocial;
        }
        #endregion

        #region PROPERTIES
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        } 
        public float GananciaPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }
        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }
        public float GananciaPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }
        #endregion

        #region METHODS
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;

            if (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Local llamadaLocal)
                    {
                        ganancia+=llamadaLocal.CostoLLamada;
                    }

                }
            }
            if (tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Provincial)
                    {
                        Provincial llamdaProvincial = (Provincial)item;
                        ganancia+=llamdaProvincial.CostoLlamada;
                    }

                }
            }
            return ganancia;
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdeanarPorDuracion);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Centralita: {this.razonSocial}");
            sb.AppendLine("Lista de llamadas");

            foreach (Llamada item in listaDeLlamadas)
            {
                if (item is Local llamadaLocal) // Se hace el casteo para poder utilizar el metodo Mostrar de cada herencia
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if (item is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }
            return sb.ToString();
        } 
        #endregion
    }
}
