using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ClassLibrary._09_02
{
    public sealed class Cuadrado : Rectangulo
    {
        // No esta obligado a implentar Dibujar pero si lo hereda
        // No esta obligado a implementar CalcularSuperficie porque su clase base (Rectangulo) ya lo tiene implementado
        // y cuando se instancia un cuadrado va a recurrir a dicho metodo
        public Cuadrado(double ladoA) : base(ladoA, ladoA)
        {
        }
    }
}
