using _10_ClassLibrary._10_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassLibrary
{
    public class MiClase
    {
        private string auxString;

        private MiClase()
        {
            try
            {
                Lanzador();
            }
            catch (Exception ex)
            {
                throw new FormatException("Re lanzada", ex);
            }
        }
        public MiClase(string input)
        {
            try
            {
                MiClase aux = new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion(ex);
            }
        }
        private static void Lanzador()
        {
            throw new DivideByZeroException();
        }
    }
}
