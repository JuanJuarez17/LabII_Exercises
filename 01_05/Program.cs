using System;

namespace _01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
            El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
            */

            int number;
            bool isInt;
            int testNumber = 0;
            int sumaInf = 0;
            int sumaSup = 0;
            int count = 0;

            Console.WriteLine("Ingrese un numero: ");
            isInt = int.TryParse(Console.ReadLine(), out number);

            while (!isInt || number <= 1)
            {
                Console.WriteLine("Error! Ingrese un numero: ");
                isInt = int.TryParse(Console.ReadLine(), out number);
            }

            for (int i = 1; i < number; i++)
            {
                testNumber = i;
                sumaInf = 0;
                sumaSup = 0;

                for (int j = 1; j < testNumber; j++)
                {
                    sumaInf = sumaInf + j;
                }

                for (int k = testNumber; k <= number; k++)
                {
                    sumaSup = (sumaSup + 1) + k;

                    if (sumaSup > sumaInf)
                    {
                        break;
                    }

                    if (sumaInf == sumaSup)
                    {
                        Console.WriteLine("{0} es un numero centro numerico.", testNumber);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No hay centros numericos entre el 1 y el {0}.", number);
            }
        }
    }
}
