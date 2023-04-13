using System;

namespace _02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double triangleBase;
            double triangleLength;
            bool isDouble;

            Console.WriteLine("Ingrese el lado del cuadrado");
            isDouble = double.TryParse(Console.ReadLine(), out number);
            while (!isDouble || number <= 0)
            {
                Console.WriteLine("Error! Ingrese el lado del cuadrado");
                isDouble = double.TryParse(Console.ReadLine(), out number);
            }

            Console.WriteLine("El area del cuadrado es {0}", CalculadoraDeArea.CalcularAreaCuadrado(number));

            Console.WriteLine("\nIngrese el radio del circulo");
            isDouble = double.TryParse(Console.ReadLine(), out number);
            while (!isDouble || number <= 0)
            {
                Console.WriteLine("Error! Ingrese el radio del circulo");
                isDouble = double.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("El area del circulo es {0}", CalculadoraDeArea.CalcularAreaCirculo(number));

            Console.WriteLine("\nIngrese la base del triangulo");
            isDouble = double.TryParse(Console.ReadLine(), out triangleBase);
            while (!isDouble || triangleBase <= 0)
            {
                Console.WriteLine("Error! Ingrese la base del triangulo");
                isDouble = double.TryParse(Console.ReadLine(), out triangleBase);
            }

            Console.WriteLine("Ingrese el lado del triangulo");
            isDouble = double.TryParse(Console.ReadLine(), out triangleLength);
            while (!isDouble || triangleLength <= 0)
            {
                Console.WriteLine("Error! Ingrese el lado del triangulo");
                isDouble = double.TryParse(Console.ReadLine(), out triangleLength);
            }
            Console.WriteLine("El area del triangulo es {0}", CalculadoraDeArea.CalcularAreaTriangulo(triangleBase, triangleBase));
        }
    }
}
