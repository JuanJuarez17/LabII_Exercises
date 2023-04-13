using System;
using System.Linq;
using System.Text;
using Veterinaria;

namespace _03_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un array de objetos Cliente
            Cliente[] clientes = new Cliente[3];

            // Asigno valores a cada instancia creada
            clientes[0] = new Cliente("Juan", "Juarez", "Paez 145", "1131759081");
            clientes[1] = new Cliente("Marcela", "Truman", "Buena Vista 2156", "1145925487");
            clientes[2] = new Cliente("Victor", "Manes", "Giacosa 23", "1176438091");

            // Uso el metodo de instancia SetPet para setear las mascotas
            clientes[0].SetPet("Perro", "Jaime", new DateTime(2018,09,13));
            clientes[1].SetPet("Gato", "Gigi", new DateTime(2018,09,13));
            clientes[2].SetPet("Gato", "Michigan", new DateTime(2018,09,13));
            clientes[2].SetPet("Perro", "Homero", new DateTime(2018,09,13));

            // Uso el metodo de instancia SetVaccine para setear las vacunas
            clientes[1].GetPet(0).SetVaccine("Triple Felina");
            clientes[2].GetPet(1).SetVaccine("Antirrabica");

            // Respuestas
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Punto A\n{clientes[0].ShowClient()}");
            sb.AppendLine($"Punto B\n{clientes[1].ShowClient()}");
            sb.AppendLine($"Punto C\n{clientes[2].ShowClient()}");
            Console.WriteLine(sb.ToString());
        }
    }
}
