using _06_ClassLibrary;
using System;
using System.Collections.Generic;

namespace _06_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Creo instancias del objeto Equipo
            Equipo e1 = new Equipo(5, "C. A. Ke personajes");
            Equipo e2 = new Equipo(5, "La Rica F.C.");

            // 2 - Creo instancias del objeto Jugador
            Jugador j1 = new Jugador(38751984, "Roberto Carlos");
            Jugador j2 = new Jugador(43890743, "Cristiano Ronaldo");
            Jugador j3 = new Jugador(27865409, "Lionel Messi", 22, 10);
            Jugador j4 = new Jugador(32908865, "Julian Alvarez", 9, 15);
            Jugador j5 = new Jugador(20287654, "Pepe");
            Jugador j6 = new Jugador(20287654, "Robin VanPersie", 2, 24);
            Jugador j7 = new Jugador(38751984, "Andi Garcia");

            // 3 - Utilizo GetPromedioGoles en las instancias que lo permiten
            j4.GetPromedioGoles();
            j6.GetPromedioGoles();
            j3.GetPromedioGoles();

            // 4 - Agrego, de ser posible, Jugadores al atributo List<Jugadores> de Equipo
            if (e1 + j1)
            {
                Console.WriteLine($"Se ha agregado \n {j1.MostrarJugador()} \n al equipo {e1.GetNombreEquipo()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar jugador al equipo {e1.GetNombreEquipo()}");
            }
            if (e1 + j7)
            {
                Console.WriteLine($"Se ha agregado \n {j7.MostrarJugador()} \n al equipo {e1.GetNombreEquipo()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar jugador al equipo {e1.GetNombreEquipo()}");
            }
            if (e1 + j3)
            {
                Console.WriteLine($"Se ha agregado \n {j3.MostrarJugador()} \n al equipo {e1.GetNombreEquipo()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar jugador al equipo {e1.GetNombreEquipo()}");
            }
            if (e1 + j4)
            {
                Console.WriteLine($"Se ha agregado \n {j4.MostrarJugador()} \n al equipo {e1.GetNombreEquipo()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar jugador al equipo {e1.GetNombreEquipo()}");
            }
            // Se podria hacer un metodo que encapsule estos if para no repetir codigo

            AgregarJugador(e1, j5);

            // Utilizando operador de descarte

            _ = e1 + j6;

            // 5 - Muestro los equipos
            Console.WriteLine(e1.MostrarEquipo());
            Console.WriteLine(e2.MostrarEquipo());
        }

        public static void AgregarJugador(Equipo e, Jugador j)
        {
            if (e + j)
            {
                Console.WriteLine($"Se ha agregado \n {j.MostrarJugador()} \n al equipo {e.GetNombreEquipo()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar jugador al equipo {e.GetNombreEquipo()}");
            }
        }
    }
}
