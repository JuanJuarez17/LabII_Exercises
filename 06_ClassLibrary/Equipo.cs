using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ClassLibrary
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores=cantidadJugadores;
            this.nombre=nombre;
        }
        public string GetNombreEquipo()
        {
            return this.nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (!e.jugadores.Contains(j) && e.jugadores.Count < e.cantidadJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
        public string MostrarEquipo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Cantidad maxima jugadores: {this.cantidadJugadores}");
            sb.AppendLine($"Cantidad jugadores: {this.jugadores.Count}");
            if (this.jugadores.Count != 0)
            {
                foreach (Jugador item in this.jugadores)
                {
                    sb.AppendLine(item.MostrarJugador());
                }
            }
            else
            {
                sb.AppendLine("No se agregaron jugadores");
            }
            return sb.ToString();
        }
    }
}
