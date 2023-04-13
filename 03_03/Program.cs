using _03_03_ClassLibrary_01;
using System;


namespace _03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] grupo = new Estudiante[3];

            grupo[0] = new Estudiante("Juan", "Perez", "45298");
            grupo[1] = new Estudiante("Malena", "Quiroz", "56310");
            grupo[2] = new Estudiante("Roberto", "Gimenez", "53265");

            //Console.WriteLine("DATOS DE ESTUDIANTES");
            //for (int i = 0; i < grupo.Length; i++)
            //{
            //    Console.WriteLine(grupo[i].Mostrar());
            //}

            grupo[0].SetNotaPrimerParcial(6);
            grupo[1].SetNotaPrimerParcial(8);
            grupo[2].SetNotaPrimerParcial(2);

            grupo[0].SetNotaSegundoParcial(7);
            grupo[1].SetNotaSegundoParcial(8);
            grupo[2].SetNotaSegundoParcial(4);

            Console.WriteLine("DATOS DE ESTUDIANTES");
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine(grupo[i].Mostrar());
            }
        }
    }
}
