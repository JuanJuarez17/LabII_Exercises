using Billetes;
using System;

namespace _04_02
{
    internal class Program
    {
        // 18/04 - Sin terminar, faltan los operadores +, -, == & != de las clases Euro y Peso
        static void Main(string[] args)
        {
            Dolar dolar1 = new Dolar(15);
            Euro euro1 = new Euro(34);
            Peso peso1 = new Peso(21);

            Dolar convEurUsd = (Dolar)euro1;
            Dolar convPesUsd = (Dolar)peso1;

            Console.WriteLine("----- DECLARACION VARIABLES -----");
            Console.WriteLine("{0}: {1}", nameof(dolar1), dolar1.GetCantidad());
            Console.WriteLine("{0}: {1}", nameof(euro1), euro1.GetCantidad());
            Console.WriteLine("{0}: {1}", nameof(peso1), peso1.GetCantidad());

            Console.WriteLine("\n----- CONVERSION A USD -----");
            Console.WriteLine("EUR {0:N2} = USD {1:N2}", euro1.GetCantidad(), convEurUsd.GetCantidad());
            Console.WriteLine("PES {0:N2} = USD {1:N2}", peso1.GetCantidad(), convPesUsd.GetCantidad());

            Euro convUsdEur = (Euro)dolar1;
            Euro convPesEur = (Euro)peso1;

            Console.WriteLine("\n----- CONVERSION A EUR -----");
            Console.WriteLine("USD {0:N2} = EUR {1:N2}", dolar1.GetCantidad(), convUsdEur.GetCantidad());
            Console.WriteLine("PES {0:N2} = EUR {1:N2}", peso1.GetCantidad(), convPesEur.GetCantidad());

            Peso convUsdPeso = (Peso)dolar1;
            Peso convEurPeso = (Peso)euro1;

            Console.WriteLine("\n----- CONVERSION A PES -----");
            Console.WriteLine("USD {0:N2} = PES {1:N2}", dolar1.GetCantidad(), convUsdPeso.GetCantidad());
            Console.WriteLine("EUR {0:N2} = PES {1:N2}", euro1.GetCantidad(), convEurPeso.GetCantidad());


            Dolar dolar2 = 18; // Se usa el casteo implicito

            Console.WriteLine("\n----- COMPARACION USD & USD -----");
            Console.WriteLine("USD {0:N2} es igual a USD {1:N2}? {2}", dolar1.GetCantidad(), dolar2.GetCantidad(), dolar1 == dolar2);
            Console.WriteLine("USD {0:N2} es distinto a USD {1:N2}? {2}", dolar1.GetCantidad(), dolar2.GetCantidad(), dolar1 != dolar2);

            Peso peso2 = 1539.75d; // Esto es igual a 15 usd

            Console.WriteLine("\n----- COMPARACION USD & PES -----");
            Console.WriteLine("USD {0:N2} es igual a PES {1:N2}? {2}", dolar1.GetCantidad(), peso2.GetCantidad(), dolar1 == peso2);
            Console.WriteLine("USD {0:N2} es distinto a PES {1:N2}? {2}", dolar1.GetCantidad(), peso2.GetCantidad(), dolar1 != peso2);

            Euro euro2 = 12;
            Console.WriteLine("\n----- COMPARACION USD & EUR -----");
            Console.WriteLine("USD {0:N2} es igual a EUR {1:N2}? {2}", dolar1.GetCantidad(), euro2.GetCantidad(), dolar1 == euro2);
            Console.WriteLine("USD {0:N2} es distinto a EUR {1:N2}? {2}", dolar1.GetCantidad(), euro2.GetCantidad(), dolar1 != euro2);

            Dolar sumUsdPeso = dolar1 + peso1;
            Dolar sumUsdEur = dolar1 + euro1;
            Console.WriteLine("\n----- SUMA USD + EUR & PES -----");
            Console.WriteLine("USD {0:N2} + PES {1:N2} = USD {2:N2}", dolar1.GetCantidad(), peso1.GetCantidad(), sumUsdPeso.GetCantidad());
            Console.WriteLine("USD {0:N2} + EUR {1:N2} = USD {2:N2}", dolar1.GetCantidad(), euro1.GetCantidad(), sumUsdEur.GetCantidad());

            Dolar resUsdPeso = dolar1 - peso1;
            Dolar resUsdEur = dolar1 - euro1;
            Console.WriteLine("\n----- RESTA USD + EUR & PES -----");
            Console.WriteLine("USD {0:N2} + PES {1:N2} = USD {2:N2}", dolar1.GetCantidad(), peso1.GetCantidad(), resUsdPeso.GetCantidad());
            Console.WriteLine("USD {0:N2} + EUR {1:N2} = USD {2:N2}", dolar1.GetCantidad(), euro1.GetCantidad(), resUsdEur.GetCantidad());
        }
    }
}
