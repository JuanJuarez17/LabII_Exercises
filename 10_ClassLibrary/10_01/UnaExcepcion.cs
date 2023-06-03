using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassLibrary
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(Exception inner) : base("Exception: UnaException", inner)
        {

        }
        public UnaExcepcion() : this(null)
        {

        }
    }
}
