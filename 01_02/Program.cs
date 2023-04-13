using System;

namespace _01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio I02
            Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje:
            "ERROR. ¡Reingresar número!".
            */

            float number = 0;
            string buffer;
            bool isNumber;

            Console.WriteLine("Ingrese un numero: ");
            buffer = Console.ReadLine();
            isNumber = float.TryParse(buffer, out number);

            while (!isNumber || number <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                buffer = Console.ReadLine();
                isNumber = float.TryParse(buffer, out number);
            }

            Console.WriteLine("El cuadrado de {0} es {1}, y el cubo es {2}", number, (number * number), (number * number * number));
        }
    }
}
