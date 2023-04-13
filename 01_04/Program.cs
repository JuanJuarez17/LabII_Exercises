using System;

namespace _01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio I04
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            */

            int maxInt = int.MaxValue;
            int accu;
            int count = 0;
            int half;
            int module;

            Console.WriteLine("A continuacion se mostraran los primeros cuatro numeros perfectos.\n" +
                              "Presione una tecla para continuar.\n");
            Console.ReadKey();

            for (int testNumber = 1; testNumber <= maxInt / 100000; testNumber++)
            // Se divide por 100000 ya que teoricamente deberiamos probar "todos" los enteros
            // Para reducir el campo de prueba y acortar tiempo de procesamiento se divide el maximo entero
            {
                accu = 0;
                half = testNumber / 2; // Todo entero es divisible como maximo por su mitad

                for (int dividers = 1; dividers <= half; dividers++)
                {
                    module = testNumber % dividers; // Para verificar si es divisor del numero de prueba

                    if (module == 0)
                    {
                        accu = accu + dividers;
                    }
                }
                if (accu == testNumber)
                {
                    Console.WriteLine("El numero {0} es perfecto", testNumber);
                    count = count + 1;
                }

                if (count == 4) // Salir cuando se encuentren x numeros perfectos, en este caso 4
                {
                    Console.WriteLine("\nSe han encontrado {0} numeros perfectos.", count);
                    System.Environment.Exit(1); // Funcion para salir del codigo
                }
            }
        }
    }
}
