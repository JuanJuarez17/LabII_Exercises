using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ClassLibrary._09_02
{
    public class Rectangulo : Figura
    {
        private double ladoA;
        private double ladoB;

        public Rectangulo(double ladoA, double ladoB)
        {
            this.ladoA=ladoA;
            this.ladoB=ladoB;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this.ladoA * this.ladoB;
        }
        public override double CalcularPerimetro()
        {
            return (this.ladoA + this.ladoB) * 2;
        }
    }
}
