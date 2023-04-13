using System;

namespace _03_01
{
    /*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
    Deberá tener los atributos:
    - titular que contendrá la razón social del titular de la cuenta.
    - cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:
    - Un constructor que permita inicializar todos los atributos.
    - Un método getter para cada atributo.
    - mostrar retornará una cadena de texto con todos los datos de la cuenta.
    - ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    - retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Se utiliza el constructor
            Cuenta first = new Cuenta("Prisma medios de pago", 109823.8m);
            Cuenta second = new Cuenta("Ferrum S.A.", 109823.89m);
            Cuenta third = new Cuenta("YPF", 76595.4m);
            Cuenta fourth = new Cuenta("  ", -54);

            // 2 - Se utilizan los getters
            Console.WriteLine("2 - GETTERS");
            string titularFirst = first.ObtenerTitular();
            Console.WriteLine(titularFirst);
            decimal cantidadFourth = fourth.ObtenerCantidad();
            Console.WriteLine(cantidadFourth);
            Console.WriteLine("\b");

            // 3 - Se utilizan funcion mostrar
            Console.WriteLine("3 - FUNCION MOSTRAR");
            Console.WriteLine(first.ObtenerCuenta());
            Console.WriteLine(second.ObtenerCuenta());
            Console.WriteLine(third.ObtenerCuenta());
            Console.WriteLine(fourth.ObtenerCuenta());

            // 4 - Se utilizan funcion ingresar
            Console.WriteLine("4 - FUNCION INGRESAR");
            first.IngresarCantidad(109823.89m);
            second.IngresarCantidad(-999); // no hace falta poner la m de decimal

            Console.WriteLine(first.ObtenerCuenta());
            Console.WriteLine(second.ObtenerCuenta());

            // 5 - Se utilizan funcion retirar
            Console.WriteLine("5 - FUNCION RETIRAR");
            third.RetirarCantidad(109823.89m);
            fourth.RetirarCantidad(-3287.28m);

            Console.WriteLine(third.ObtenerCuenta());
            Console.WriteLine(fourth.ObtenerCuenta());
        }
    }
}
