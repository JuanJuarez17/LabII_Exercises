using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Geometria
{
    public class Punto
    {
        // ATTRIBUTES
        private int x;
        private int y;

        // CONSTRUCTOR
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //GETTER
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
    }

    public class Rectangulo
    {
        // ATTRIBUTES
        private float area;
        private float primetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        // CONSTRUCTOR
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            Punto vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;
        }

        // METHOD
        public float GetArea()
        {
            float suelo = Math.Abs(vertice4.GetX() - vertice1.GetX());
            float altura = Math.Abs(vertice1.GetY() - vertice2.GetY());

            return suelo * altura;
        }

        public float GetPerimetro()
        {
            float suelo = Math.Abs(vertice4.GetX() - vertice1.GetX());
            float altura = Math.Abs(vertice1.GetY() - vertice2.GetY());

            return (suelo + altura) * 2;
        }
    }
}
