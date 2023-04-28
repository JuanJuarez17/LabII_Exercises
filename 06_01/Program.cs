using System;
using System.Collections.Generic;

namespace _06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Creo una variable Random y objetos List
            Random rand = new Random();
            List<int> numberList = new List<int>();
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();

            // 2 - Asigno un valor random (escluyendo 0) a cada elemento hasta llegar a 20 elementos
            for (int i = 0; i < 20; i++)
            {
                numberList.Add(rand.Next(-50, 50));
                if (numberList.Contains(0))
                {
                    numberList.Remove(0);
                    numberList.Add(rand.Next(0, 50));
                }
            }

            // 3 - Muestro la lista original
            foreach (int item in numberList)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros: {0}", numberList.Count);

            // 4 - Copio los valores a otra lista en funcion de si son mayores o menores que cero.
            foreach (int item in numberList)
            {
                if (item > 0)
                {
                    positiveNumbers.Add(item);                        
                }
                if (item < 0)
                {
                    negativeNumbers.Add(item);
                }
            }

            // 5 - Imprimo las listas de numeros positivos y negativos
            foreach (int item in positiveNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros: {0}", positiveNumbers.Count);

            foreach (int item in negativeNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros: {0}", negativeNumbers.Count);

            // 5 - Ordeno las listas segun la consigna
            positiveNumbers.Sort(DecreaseSort);
            negativeNumbers.Sort();

            // 6 - Imprimo las listas ordenadas
            foreach (int item in positiveNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros: {0}", positiveNumbers.Count);

            foreach (int item in negativeNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros: {0}", negativeNumbers.Count);
        }
        // Metodo para ordenar de manera decreciente
        public static int DecreaseSort(int a, int b)
        {
            return b -a;
        }
    }
}
