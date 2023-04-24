using _04_ClassLibrary;
using System;

namespace _04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumaInt = new Sumador();
            Sumador sumaStr = new Sumador();

            Console.WriteLine(sumaInt.GetCantSumas());

            Console.WriteLine(sumaInt.Sumar(3, 5));
            Console.WriteLine(sumaInt.Sumar(3, 90));

            Console.WriteLine(sumaInt.GetCantSumas());

            Console.WriteLine(sumaStr.Sumar("Hola", "Mundo"));
            Console.WriteLine(sumaStr.Sumar("a", "D"));

            Console.WriteLine(sumaStr.GetCantSumas());

            Console.WriteLine((long)sumaInt);

            Console.WriteLine(sumaInt + sumaStr);

            Console.WriteLine(sumaInt | sumaStr);
        }
    }
}
