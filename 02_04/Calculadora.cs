using System;

namespace _02_04
{
    internal class Calculadora
    {
        public static float Calcular(float firstOperator, float secondOperator, char operation)
        {
            float rtn = 0;

            switch (operation)
            {
                case '+':
                    rtn = firstOperator + secondOperator;
                    break;
                case '-':
                    rtn = firstOperator - secondOperator;
                    break;
                case '*':
                    rtn = firstOperator * secondOperator;
                    break;
                case '/':
                    if (ValidarSegundoOp(secondOperator))
                    {
                        rtn = firstOperator / secondOperator;
                    }
                    else
                    {
                        Console.WriteLine("El segundo operador debe ser distinto de 0 (cero)");
                    }
                    break;
                default:
                    break;
            }
            return rtn;
        }

        private static bool ValidarSegundoOp(float secondOperator)
        {
            bool rtn = true;
            if (secondOperator == 0)
            {
                rtn = false;
            }
            return rtn;
        }
    }
}
