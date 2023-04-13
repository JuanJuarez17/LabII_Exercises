using System;

namespace _02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFloat;
            bool isChar;
            float firstOp;
            float secondOp;
            char operation;
            float result;

            Console.WriteLine("Ingrese el primer operador: ");
            isFloat = float.TryParse(Console.ReadLine(), out firstOp);

            while (!isFloat)
            {
                Console.WriteLine("Error! Ingrese el primer operador: ");
                isFloat = float.TryParse(Console.ReadLine(), out firstOp);
            }

            Console.WriteLine("Ingrese el segundo operador: ");
            isFloat = float.TryParse(Console.ReadLine(), out secondOp);

            while (!isFloat)
            {
                Console.WriteLine("Error! Ingrese el segundo operador: ");
                isFloat = float.TryParse(Console.ReadLine(), out secondOp);
            }

            Console.WriteLine("Ingrese la operacion (+, -, *, /) : ");
            isChar = char.TryParse(Console.ReadLine(), out operation);

            while (!isChar || !(operation == '+' || operation == '-' || operation == '*' || operation == '/'))
            {
                Console.WriteLine("Error! Ingrese la operacion (+, -, *, /) : ");
                isChar = char.TryParse(Console.ReadLine(), out operation);
            }

            result = Calculadora.Calcular(firstOp, secondOp, operation);

            if (secondOp == 0 && operation == '/')
            {
                Console.WriteLine("La operacion no pudo realizarce.");
            }
            else
            {
                Console.WriteLine("El resultado de la operacion es: {0:N2}", result); // N2 Mostrar 2 decimales despues de la "coma"
            }
            //Console.WriteLine("Los operadores ingresados son {0}, {1}, {2}.", firstOp, secondOp, operation);
        }
    }
}
