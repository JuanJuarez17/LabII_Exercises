using System;

namespace _01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio I07
            Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
            hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
            */

            /*
            La consigna es sin vectores ni array, nose como hacerlo de esa forma.
            */

            string employeeName;
            int antiquity;
            int hourValue;
            int hourQty;
            char response = 's';
            bool isInt;
            bool isChar;
            float grossSalary;
            float netSalary;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                employeeName = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad del empleado: ");
                isInt = int.TryParse(Console.ReadLine(), out antiquity);

                while (!isInt || antiquity <= 0 || antiquity >= 47)
                {
                    Console.WriteLine("Error! Ingrese la antiguedad del empleado: ");
                    isInt = int.TryParse(Console.ReadLine(), out antiquity);
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas del empleado: ");
                isInt = int.TryParse(Console.ReadLine(), out hourQty);

                while (!isInt || hourQty < 0 || hourQty >= 250)
                {
                    Console.WriteLine("Error! Ingrese la cantidad de horas trabajadas del empleado: ");
                    isInt = int.TryParse(Console.ReadLine(), out hourQty);
                }

                Console.WriteLine("Ingrese el valor de cada hora: ");
                isInt = int.TryParse(Console.ReadLine(), out hourValue);

                while (!isInt || hourValue < 0 || hourValue >= 4000)
                {
                    Console.WriteLine("Error! Ingrese la cantidad de horas trabajadas del empleado: ");
                    isInt = int.TryParse(Console.ReadLine(), out hourValue);
                }

                grossSalary = (hourQty * hourValue) + (antiquity * 150f);

                netSalary = grossSalary - grossSalary * (13 / 100f);

                Console.WriteLine("\n***************************** RECIBO DE SUELDO ******************************\n" +
                                  "Nombre         Antiguedad    Valor por hora    Salario bruto     Salario neto\n" +
                                  "{0,-12}       {1}       {2,10}       {3,15:C2}  {4,15:C2}",
                                  employeeName, antiquity, hourValue, grossSalary, netSalary);

                Console.WriteLine("Desea agregar otro empleado (S/N): ");
                isChar = char.TryParse(Console.ReadLine(), out response);
                while (!isChar || !(response == 's' || response == 'n'))
                {
                    Console.WriteLine("Error! Desea agregar otro empleado (S/N): ");
                    isChar = char.TryParse(Console.ReadLine(), out response);
                }
                if (response == 's') Console.Clear();

            } while (response == 's');
        }
    }
}
