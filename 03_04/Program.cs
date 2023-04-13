using _03_04_ClassLibrary_01;
using System;

namespace _03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 10);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 15);

            string inscripcionAzul;
            string inscripcionRojo;

            Console.WriteLine("Imprimimos 5 unidades de boligrafo azul");
            boligrafoAzul.Pintar(5, out inscripcionAzul);
            Console.WriteLine(inscripcionAzul);

            Console.WriteLine("Imprimimos 3 unidades de boligrafo azul");
            boligrafoAzul.Pintar(3, out inscripcionAzul);
            Console.WriteLine(inscripcionAzul);

            Console.WriteLine("Imprimimos 10 unidades de boligrafo azul pero solo se imprime lo que resta de tinta " +
                              "antes de acabarse");
            boligrafoAzul.Pintar(10, out inscripcionAzul);
            Console.WriteLine(inscripcionAzul);

            Console.WriteLine("Se acabo la tinta azul");
            boligrafoAzul.Pintar(10, out inscripcionAzul);
            Console.WriteLine(inscripcionAzul);

            Console.WriteLine("Imprimimos 10 unidades de boligrafo rojo");
            boligrafoRojo.Pintar(10, out inscripcionRojo);
            Console.WriteLine(inscripcionRojo);

            Console.WriteLine("Imprimimos 15 unidades de boligrafo rojo pero solo se imprime lo que resta de tinta " +
                              "antes de acabarse");
            boligrafoRojo.Pintar(15, out inscripcionRojo);
            Console.WriteLine(inscripcionRojo);

            boligrafoAzul.Recargar();

            Console.WriteLine("Recargamos el boligrafo azul e imprimimos 13 unidades");
            boligrafoAzul.Pintar(13, out inscripcionAzul);
            Console.WriteLine(inscripcionAzul);


        }
    }
}
