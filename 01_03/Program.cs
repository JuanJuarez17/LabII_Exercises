using System;

namespace _01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio I03
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
            */

            string buffer;
            bool isNumber;
            int number = 0;
            int retries = 0;
            bool isChar;
            char response = 's';

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                isNumber = int.TryParse(Console.ReadLine(), out number);
                int iterations = 2;

                while ((!isNumber || number <= 1))
                {
                    Console.WriteLine("ERROR! Ingrese un numero mayor que 1!");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                    retries++;

                    if (retries == 3)
                    {
                        Console.WriteLine("Desea continuar? (S/N): ");
                        isChar = char.TryParse(Console.ReadLine(), out response);

                        while (!isChar || !(response == 's' || response == 'n'))
                        {
                            Console.WriteLine("Error! Desea continuar? (S/N): ");
                            isChar = char.TryParse(Console.ReadLine(), out response);
                        }

                        if (response == 's')
                        {
                            retries = 0;
                            Console.Clear();
                            Console.WriteLine("Ingrese un numero: ");
                            isNumber = int.TryParse(Console.ReadLine(), out number);
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                    }
                }

                Console.WriteLine("\nLos numeros primos hasta el {0} son: ", number);

                while (iterations <= number)
                {
                    bool isPrime = true;

                    for (int i = 2; i < iterations; i++)
                    {
                        if ((iterations % i) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(iterations);
                    }
                    iterations++;
                }

                Console.WriteLine("Desea continuar? (S/N): ");
                isChar = char.TryParse(Console.ReadLine(), out response);
                while (!isChar || !(response == 's' || response == 'n'))
                {
                    Console.WriteLine("Error! Desea continuar? (S/N): ");
                    isChar = char.TryParse(Console.ReadLine(), out response);
                }

                if (response == 's') Console.Clear();

            } while (response == 's');
        }
    }
}
