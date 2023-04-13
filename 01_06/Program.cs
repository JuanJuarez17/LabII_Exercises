using System;

namespace _01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstYear = 0;
            int secondYear = 0;
            bool isInt;
            int divisibleByFour = 0;
            int divisibleByHundred = 0;
            int divisibleByFourHundred = 0;

            Console.WriteLine("A continuacion se le mostraran los años bisiestos entre un periodo ingresado.\t");

            do
            {
                Console.WriteLine("Ingrese el primer año: ");
                isInt = int.TryParse(Console.ReadLine(), out firstYear);

                while (!isInt || firstYear <= 0)
                {
                    Console.WriteLine("Error! Ingrese el primer año: ");
                    isInt = int.TryParse(Console.ReadLine(), out firstYear);
                }

                Console.WriteLine("Ingrese el segundo año: ");
                isInt = int.TryParse(Console.ReadLine(), out secondYear);

                while (!isInt || secondYear <= 0)
                {
                    Console.WriteLine("Error! Ingrese el segundo año: ");
                    isInt = int.TryParse(Console.ReadLine(), out secondYear);
                }

            } while (firstYear >= secondYear);

            for (int i = firstYear; i <= secondYear; i++)
            {
                divisibleByFour = i % 4;
                divisibleByHundred = i % 100;
                divisibleByFourHundred = i % 400;

                if (divisibleByFour == 0 && divisibleByHundred != 0)
                {
                    Console.WriteLine("El año {0} es bisiesto.", i);
                }
                else if (divisibleByHundred == 0 && divisibleByFourHundred == 0)
                {
                    Console.WriteLine("El año {0} es bisiesto.", i);
                }
            }
            //Console.WriteLine("Los años ingresados son {0} y {1}.", firstYear, secondYear);
        }
    }
}
