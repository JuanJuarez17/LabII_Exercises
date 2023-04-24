using System;

namespace _04_ClassLibrary
{
    public class Sumador
    {
        #region ATTRIBUTES
        private int cantidadSumas;
        #endregion

        #region CONSTRUCTOR
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {
        }
        #endregion

        #region GETTERS
        public int GetCantSumas()
        {
            return this.cantidadSumas;
        }
        #endregion

        #region METHODS
        // METODO SOBRECARGADOS
        public long Sumar(long oper1, long oper2)
        {
            this.cantidadSumas++;
            return oper1 + oper2;
        }
        public string Sumar(string oper1, string oper2)
        {
            this.cantidadSumas++;
            return oper1 + " " + oper2;
        }
        // OPERADORES SOBRECARGADOS
        public static long operator +(Sumador s1 , Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            //if(s1.cantidadSumas == s2.cantidadSumas)
            //{
            //    return true;
            //}
            //return false;

            return s1.cantidadSumas == s2.cantidadSumas;
        }
        // OPERADORES EXPLICITOS
        public static explicit operator long(Sumador sumador) // Operadores explicitos siempre static
        {
            return sumador.cantidadSumas;
        }
        #endregion

    }
}
