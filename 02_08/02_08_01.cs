using System;

namespace _02_08
{
    internal class Calculador
    {
        public static TimeSpan CalcularDias(DateTime birthDay)
        {
            DateTime dateNow = DateTime.Now;

            TimeSpan daysDiff = dateNow - birthDay;

            return daysDiff;
        }
    }
}
