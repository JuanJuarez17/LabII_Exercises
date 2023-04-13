using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace _03_03_ClassLibrary_01
{
    public class Estudiante
    {
        //ATTRIBUTES
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //CONSTRUCTOR
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        static Estudiante()
        {
            random = new Random();
        }

        //SETTER

        // La funcion del setter es que solamente reciba un dato y lo guarde en el atributo de un objeto.
        public bool SetNotaPrimerParcial(int buffer)
        {
            this.notaPrimerParcial = buffer;
            return true;
        }
        public bool SetNotaSegundoParcial(int buffer)
        {
            this.notaSegundoParcial = buffer;
            return true;
        }

        // METHOD

        float CalcularPromedio()
        {
            int nota1 = this.notaPrimerParcial;
            int nota2 = this.notaSegundoParcial;
            float promedio = (float) (nota1 + nota2) / 2;
            return promedio;
        }

        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if(CalcularNotaFinal() == -1)
            {
                sb.AppendLine("Nota final: Alumno desaprobado");
            }
            else
            {
                sb.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            return sb.ToString();
        }
    }
}

