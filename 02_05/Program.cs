using System;

namespace _02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isInt;

            Console.WriteLine("Ingrese un numero entero:");
            isInt = int.TryParse(Console.ReadLine(), out number);
            while (!isInt)
            {
                Console.WriteLine("Error! Ingrese un numero entero:");
                isInt = int.TryParse(Console.ReadLine(), out number);
            }

            Console.WriteLine("\nTabla de multiplicar del número {0}:", number);

            Console.WriteLine(Tabla.MultiplicationTable(number));
            /*
            for (int i = 1; i < 10; i++)
            {
                //Console.WriteLine("{0} x {1} = {2}", number, i, number * i); // Para escribir por consola sin usar StringBuilder

                StringBuilder message = new StringBuilder(number + " x " + i + " = " + number * i);
                //message.Append(i + " = " + number * i); // Es caso de utilizar el metodo Append

                Console.WriteLine(message);
            }
            */
        }
    }
}
