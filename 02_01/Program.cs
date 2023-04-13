using System;

namespace _02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int testNumber = 0;
            int maxNumber = 0;
            int minNumber = 0;
            float prom = 0;
            int accu = 0;
            bool isInt;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese e1 {0}º numero", i + 1);
                isInt = int.TryParse(Console.ReadLine(), out testNumber);
                while (!isInt || !Validador.Validar(testNumber, -100, 100))
                {
                    Console.WriteLine("Error! Ingrese e1 {0}º numero", i + 1);
                    isInt = int.TryParse(Console.ReadLine(), out testNumber);
                }

                number = testNumber;
                accu += number;

                if (i == 0 || number > maxNumber)
                {
                    maxNumber = number;
                }
                if (i == 0 || number < minNumber)
                {
                    minNumber = number;
                }
            }

            prom = (float)accu / 10;
            Console.WriteLine("El maximo numero ingresado es {0}\n" +
                              "El minimo numero ingresado es {1}\n" +
                              "El promedio de los numeros ingresados es {2:N2}\n",
                              maxNumber, minNumber, prom);
        }
    }
}
