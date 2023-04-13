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

        public static bool ValidarRespuesta(char respuesta)
        {
            bool rtn = false;
            if (respuesta == 'S')
            {
                rtn = true;
            }
            return rtn;
        }
    }
}
