using System;

namespace _02_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "02_08";

            DateTime value;
            bool isDate;

            Console.WriteLine("Ingrese su fecha de nacimiento (DD/M/AA):");
            isDate = DateTime.TryParse(Console.ReadLine(), out value);

            while (!isDate)
            {
                Console.WriteLine("Error! Ingrese su fecha de nacimiento (DD/M/AA):");
                isDate = DateTime.TryParse(Console.ReadLine(), out value);
            }

            Console.WriteLine("Fecha ingresada: {0}", value);
            Console.WriteLine("Fecha actual: {0}", DateTime.Now);

            TimeSpan difference = Calculador.CalcularDias(value);

            Console.WriteLine("Usted ha vivido {0} dias hasta hoy.", difference.Days);
        }
    }
}
