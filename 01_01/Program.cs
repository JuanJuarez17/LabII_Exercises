using System;

namespace _01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio I01
            Ingresar 5 números por consola, guardándolos en una variable escalar.
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */

            float number = 0;
            float numberMax = 0;
            float numberMin = 0;
            string buffer;
            bool isNumber;
            float accu = 0;
            int count = 0;
            float prom;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el {0}° numero: ", i + 1);
                buffer = Console.ReadLine();
                isNumber = float.TryParse(buffer, out number);

                while (!isNumber)
                {
                    Console.WriteLine("Error! Ingrese un numero: ");
                    buffer = Console.ReadLine();
                    isNumber = float.TryParse(buffer, out number);
                }

                if (number > numberMax || i == 0)
                {
                    numberMax = number;
                }
                if (number < numberMin || i == 0)
                {
                    numberMin = number;
                }
                accu += number;
                count++;
            }
            prom = accu / count;
            Console.WriteLine("El minimo numero ingresado es {0} y el maximo es {1}", numberMin, numberMax);
            Console.WriteLine("El promedio de los numeros ingresados es {0}", prom);
        }
    }
}
