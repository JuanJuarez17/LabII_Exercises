using System;
using Estanteria;

namespace _04_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);
            Estante estante2 = new Estante(3, 2);

            // Creo 4 productos
            Producto p1 = new Producto("PESDS97413", "Pepsi", (float)18.5);
            Producto p2 = new Producto("COSDS55752", "Coca-Cola", (float)11.5);
            Producto p3 = new Producto("MASDS51292", "Manaos", (float)20.5);
            Producto p4 = new Producto("CRSDS54861", "Crush", (float)10.17);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p1)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.WriteLine(Estante.MostrarEstante(estante2));
            
            // Quito un producto del estante
            Estante estante3 = estante - p3;
            Console.WriteLine(Estante.MostrarEstante(estante3));

            // Agrego un producto al estante anterior
            if (estante3 + p4)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("No se puedo agregar {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            Console.WriteLine(Estante.MostrarEstante(estante3));
        }
    }
}
