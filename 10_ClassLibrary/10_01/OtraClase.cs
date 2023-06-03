using _10_ClassLibrary._10_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassLibrary
{
    public class OtraClase
    {
        public void MetodoOtraClase()
        {
            try
            {
                MiClase auxMiClase = new MiClase("Test");
            }
            catch (Exception ex)
            {
                throw new MiExcepcion(ex);
            }
        }
    }
}
