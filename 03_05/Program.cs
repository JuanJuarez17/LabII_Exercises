using Geometria;
using System;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace _03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo(new Punto(3, 10), new Punto(15, 2));

            static string MostrarRectangulo(Rectangulo buffer)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"El area del rectangulo es: {buffer.GetArea()}");
                sb.AppendLine($"El perimetro del rectangulo es: {buffer.GetPerimetro()}");

                return sb.ToString();
            }
            Console.WriteLine(MostrarRectangulo(rect1));
        }
    }
}
