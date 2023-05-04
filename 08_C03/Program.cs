using System;
using _08_ClassLibrary._08_C03;

namespace _08_C03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Provincial l2 = new Provincial(21, "Morón", "Bernal", Provincial.Franja.Franja_1);
            Local l3 = new Local(45, "Lanús", "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_3 );

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
            Console.Clear();

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
