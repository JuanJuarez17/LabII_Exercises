using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassLibrary._10_02
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
        public ParametrosVaciosException(string mensaje) : this(mensaje, null)
        {

        }
    }
}
