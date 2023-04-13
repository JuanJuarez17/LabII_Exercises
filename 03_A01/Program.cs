using _03_ClassLibrary;
using System;
using System.Linq;
using System.Text;

namespace _03_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion y asginacion de variables
            string buffer;
            bool isNumber;
            string driverName;
            int[] trails = new int[7]; // Array para cargar recorridos
            Conductor[] drivers = new Conductor[3];
            int maxTravel = 0;
            string maxTravelName = "";
            int maxTravelThird = 0;
            string maxTravelNameThird = "";
            int maxTravelFifth = 0;
            string maxTravelNameFifth = "";

            // Carga del array Conductores
            for (int j = 0; j < drivers.Length; j++)
            {
                Console.WriteLine("Ingrese el nombre del {0}° conductor: ", j + 1);
                driverName = Console.ReadLine();

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Ingrese los kilometros recorrido en el {0}° dia: ", i + 1);
                    buffer = Console.ReadLine();
                    isNumber = int.TryParse(buffer, out trails[i]);

                    while (!isNumber || trails[i] < 0 || trails[i] > 500)
                    {
                        Console.WriteLine("Error! Ingrese los kilometros recorrido en el {0}° dia: ", i + 1);
                        buffer = Console.ReadLine();
                        isNumber = int.TryParse(buffer, out trails[i]);
                    }
                }
                drivers[j] = new Conductor(driverName, trails);
                Console.Clear();
            }

            // Punto A - Conductor con mas kilometros
            for (int i = 0; i < drivers.Length; i++)
            {
                if (i == 0 || drivers[i].AccumulativeTrail() > maxTravel)
                {
                    maxTravel = drivers[i].AccumulativeTrail();
                    maxTravelName = drivers[i].GetName();
                }
            }

            // Punto B - Conductor con mas kilometros al 3er dia
            for (int i = 0; i < drivers.Length; i++)
            {
                if (i == 0 || drivers[i].GetTrial(3) > maxTravelThird)
                {
                    maxTravelThird = drivers[i].GetTrial(3);
                    maxTravelNameThird = drivers[i].GetName();
                }
            }

            // Punto C - Conductor con mas kilometros al 5to dia
            for (int i = 0; i < drivers.Length; i++)
            {
                if (i == 0 || drivers[i].GetTrial(5) > maxTravelFifth)
                {
                    maxTravelFifth = drivers[i].GetTrial(5);
                    maxTravelNameFifth = drivers[i].GetName();
                }
            }

            Console.WriteLine("Datos cargados. Pulse una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            // Muestro datos de conductores
            Console.WriteLine("Datos conductores");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine(drivers[i].ShowDriver());
            }

            Console.WriteLine("Pulse una tecla para continuar.");
            Console.ReadKey();

            // Muestro respuestas
            StringBuilder respuestas = new StringBuilder();
            respuestas.AppendLine($"A - El conductor con mas recorrido es {maxTravelName} quien realizo {maxTravel} km.");
            respuestas.AppendLine($"B - El conductor con mas recorrido el 3er dia es {maxTravelNameThird} " +
                                  $"quien realizo {maxTravelThird} km.");
            respuestas.AppendLine($"C - El conductor con mas recorrido el 5to dia es {maxTravelNameFifth} " +
                                  $"quien realizo {maxTravelFifth} km.");
            respuestas.ToString();
            Console.WriteLine(respuestas);

            /*
            // Creo un array de int para guardar los recorridos totales de cada conductor
            int[] accuTotal = new int[3];

            // Cargo el array
            for (int i = 0; i < drivers.Length; i++)
            {
                accuTotal[i] = drivers[i].AccumulativeTrail();
            }

            // Utilizo el array para mostrar el acumulado de cada constructor
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine("Viaje acumulado {0}: {1} km.", drivers[i].GetName(), accuTotal[i]);
            }

            // Dentro del array busco el mayor acumulado y lo muestro
            int maxAccuTotal = accuTotal.Max();
            Console.WriteLine($"El mayor recorrido es de {accuTotal.Max()} km");
             */

            /* 
             * Diferencia entre metodo de instacia y metodo estatico
            Console.WriteLine($"(Instancia) El viaje acumulado de {drivers[0].GetName()} " +
                              $"es {drivers[0].AccumulativeTrail()}");
            Console.WriteLine($"(Estatico) El viaje acumulado de {drivers[0].GetName()} " +
                              $"es {Conductor.AccumulativeTrailStatic(drivers[0])}");
             */
        }
    }
}
