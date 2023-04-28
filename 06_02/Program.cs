using System;
using System.Collections.Generic;
using System.Data;

namespace _06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> numberList = new List<int>();
            Queue<int> numberQueue = new Queue<int>();
            Stack<int> numberStack = new Stack<int>();

            List<int> posNumbers = new List<int>();
            List<int> negNumbers = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                numberList.Add(intRdmExcept(-50, 50, 0));

                numberQueue.Enqueue(intRdmExcept(-50, 50, 0));

                numberStack.Push(intRdmExcept(-50, 50, 0));
            }

            foreach (int item in numberList)
            {
                Console.Write(item + "/");
                if (item > 0)
                {
                    posNumbers.Add(item);
                }
                else
                {
                    negNumbers.Add(item);
                }
            }
            Console.WriteLine("Cantidad de numeros en List: {0}", numberList.Count);

            foreach (int item in numberQueue)
            {
                Console.Write(item + "/");
                if (item > 0)
                {
                    posNumbers.Add(item);
                }
                else
                {
                    negNumbers.Add(item);
                }
            }
            Console.WriteLine("Cantidad de numeros en Queue: {0}", numberQueue.Count);

            foreach (int item in numberStack)
            {
                Console.Write(item + "/");
                if (item > 0)
                {
                    posNumbers.Add(item);
                }
                else
                {
                    negNumbers.Add(item);
                }
            }
            Console.WriteLine("Cantidad de numeros en Queue: {0}", numberStack.Count);

            posNumbers.Sort(DecreaseSort);
            negNumbers.Sort();

            foreach (int item in posNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros positivos: {0}", posNumbers.Count);

            foreach (int item in negNumbers)
            {
                Console.Write(item + "/");
            }
            Console.WriteLine("Cantidad de numeros negativos: {0}", negNumbers.Count);

        }

        public static int intRdmExcept(int lowLim, int uppLim, int except)
        {
            Random rand = new Random();
            int rtn = rand.Next(lowLim, (uppLim+1));
            while (rtn == except)
            {
                rtn = rand.Next(lowLim, (uppLim+1));
            }
            return rtn;
        }
        public static int DecreaseSort(int a, int b)
        {
            return b -a;
        }
    }
}
