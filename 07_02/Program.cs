using System;
using _07_ClassLibrary;

namespace _07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro harryPotter = new Libro();

            harryPotter[0] = "Prologo";
            harryPotter[1] = "Primer capitulo";
            harryPotter[2] = "Segundo Capitulo";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(harryPotter[i]);
            }

            harryPotter[1] = "Resumen. Primer capitulo";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(harryPotter[i]);
            }
        }
    }
}
