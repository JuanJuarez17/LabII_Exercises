using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassLibrary._10_01
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(Exception inner) : base("Exception: MiException", inner)
        {
            
        }
        public MiExcepcion() : this(null)
        { 

        }
    }
}
