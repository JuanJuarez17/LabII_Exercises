using System;
using System.Text;

namespace _06_ClassLibrary
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int inputDni, string inputNombre) : this()
        {
            this.dni = inputDni;
            this.nombre = inputNombre;
        }
        public Jugador(int inputDni, string inputNombre, int inputTotalGoles, int inputTotalPArtidos) : this(inputDni, inputNombre)
        {
            this.totalGoles = inputTotalGoles;
            this.partidosJugados = inputTotalPArtidos;
        }
        public float GetPromedioGoles()
        {
            if (this.partidosJugados == 0)
            {
                return 0;
            }
            float promedioGoles = (float)(this.totalGoles) / this.partidosJugados;
            this.promedioGoles = promedioGoles;
            return promedioGoles;
        }
        public string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total goles: {this.totalGoles}");
            sb.AppendLine($"Promedio goles: {this.promedioGoles}");
            return sb.ToString();
        }
        public static bool operator == (Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            {
                return j1.dni == j2.dni;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
