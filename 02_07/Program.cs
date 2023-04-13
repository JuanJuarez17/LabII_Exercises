using System;

namespace _02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangleBase;
            double triangleHeight;
            bool isDouble;
            double hypotenuse;

            Console.WriteLine("Ingrese la base del triangulo");
            isDouble = double.TryParse(Console.ReadLine(), out triangleBase);
            while (!isDouble || triangleBase <= 0)
            {
                Console.WriteLine("Error! Ingrese la base del triangulo");
                isDouble = double.TryParse(Console.ReadLine(), out triangleBase);
            }

            Console.WriteLine("Ingrese el lado del triangulo");
            isDouble = double.TryParse(Console.ReadLine(), out triangleHeight);
            while (!isDouble || triangleHeight <= 0)
            {
                Console.WriteLine("Error! Ingrese el lado del triangulo");
                isDouble = double.TryParse(Console.ReadLine(), out triangleHeight);
            }

            hypotenuse = Math.Sqrt(Math.Pow(triangleBase, 2) + Math.Pow(triangleHeight, 2));

            Console.WriteLine("La hipotenusa de su triangulo mide {0:N3}", hypotenuse);
        }
    }
}
