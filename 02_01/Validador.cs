namespace _02_01
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool rtn = true;
            if (valor < min || valor > max)
            {
                rtn = false;
            }
            return rtn;
        }
    }
}
