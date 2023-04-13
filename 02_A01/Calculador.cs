namespace _02_A01
{
    internal class Calculador
    {
        public static double CalculadoraFactorial(int number)
        {
            double accu = 1;

            for (int i = number; i > 0; i--)
            {
                accu = accu * i;
            }
            return accu;
        }
    }
}
