using System;
using System.Text;

namespace _05_ClassLibrary
{
    public class Ingresante
    {
        #region ATTRIBUTES
        private string nombre;
        private string direccion;
        private string genero;
        private string pais;
        private string[] cursos;
        private int edad;
        #endregion

        #region CONSTRUCTOR
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        #endregion

        #region METHODS
        public string MostrarAlumno()
        {
            int flagCursos = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Dirección: {this.direccion}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine($"Curso/s:");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                if (this.cursos[i] != null)
                {
                    sb.AppendLine($"{this.cursos[i]}");
                    flagCursos = 1;
                }
            }
            if (flagCursos == 0)
            {
                sb.AppendLine($"No se seleccionaron cursos.");
            }
            return sb.ToString();
        }
        #endregion
    }
}
