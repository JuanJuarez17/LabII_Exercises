using System;
using _08_ClassLibrary;

namespace _08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion1 = new Camion(Colores.Rojo, 6, 8, 9, 1000);
            Automovil auto1 = new Automovil(Colores.Azul, 4, 4, 6, 4);
            Moto moto1 = new Moto(Colores.Azul, 4, 4, 150);

            Console.WriteLine(moto1.MostrarMoto());
            Console.WriteLine(auto1.MostrarAuto());
            Console.WriteLine(camion1.MostrarCamion());
        }
    }
}
