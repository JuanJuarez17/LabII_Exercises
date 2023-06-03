using _10_ClassLibrary;
using System;

namespace _10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoOtraClase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
