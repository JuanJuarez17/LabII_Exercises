using System;

namespace _02_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isInt;
            double accu = 1;

            Console.WriteLine("Ingrese un numero entero:");
            isInt = int.TryParse(Console.ReadLine(), out number);
            while (!isInt)
            {
                Console.WriteLine("Error! Ingrese un numero entero:");
                isInt = int.TryParse(Console.ReadLine(), out number);
            }

            Console.WriteLine("El factorial de {0} es {1}", number, Calculador.CalculadoraFactorial(number));
        }
    }
}
