using _02_01;
using System;

namespace _02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char response;
            bool isChar;
            int number;
            bool isInt;
            int accu = 0;
            do
            {
                Console.WriteLine("Ingrese un numero entero!");
                isInt = int.TryParse(Console.ReadLine(), out number);
                while (!isInt)
                {
                    Console.WriteLine("Error! Ingrese un numero entero!");
                    isInt = int.TryParse(Console.ReadLine(), out number);
                }

                accu += number;

                Console.WriteLine("¿Desea continuar? (S/N)");
                isChar = char.TryParse(Console.ReadLine(), out response);
                response = char.ToUpper(response);
                while (!isChar) // || (response != 'S' && response != 'N') ---> Agregar al while si se quiere restringir que la respuesta sea solo S o N
                {
                    Console.WriteLine("¿Error! Desea continuar? (S/N)");
                    isChar = char.TryParse(Console.ReadLine(), out response);
                    response = char.ToUpper(response);
                }
            } while (Validador.ValidarRespuesta(response));

            Console.WriteLine("La suma de los numeros ingresados es {0}", accu);
        }
    }
}
