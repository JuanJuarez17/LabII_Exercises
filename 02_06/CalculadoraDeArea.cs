namespace _02_06
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double rtn = 0;
            rtn = longitudLado * longitudLado;
            return rtn;
        }
        public static double CalcularAreaTriangulo(double bas, double altura)
        {
            double rtn = 0;
            rtn = (bas * altura) / 2;
            return rtn;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            double rtn = 0;
            rtn = 3.14 * (radio * radio);
            return rtn;
        }
    }
}
