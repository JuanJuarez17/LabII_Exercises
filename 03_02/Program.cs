using System;
using _03_02_ClassLibrary_01;

namespace _03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] grupo = new Persona[5];

            grupo[0] = new Persona("Juan", new DateTime(2019, 08, 17), 38427607);
            grupo[1] = new Persona("Maria", new DateTime(1, 1, 1), 30734187);
            grupo[2] = new Persona("Luis", new DateTime(1979, 04, 28), 31965273);
            grupo[3] = new Persona("Pedro", new DateTime(2015, 02, 05), 42870365);
            grupo[4] = new Persona("Rocio", new DateTime(1999, 10, 14), 41675921);

            Console.WriteLine("1 - Se instancian 5 objetos Persona y se muestran sus datos\n");
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine(grupo[i].ShowPerson());
            }

            Console.WriteLine("2 - Se muestra quienes son mayores o menores de edad\n");
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine($"{grupo[i].GetName()} {grupo[i].EsMayordeEdad()}");
            }
        }
    }
}
