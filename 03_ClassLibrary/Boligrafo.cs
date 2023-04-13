using System;
using System.Text;

namespace _03_04_ClassLibrary_01
{
    public class Boligrafo
    {
        //ATTRIBUTES
        private short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        // GETTERS

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        // SETTER

        private void SetTinta(short buffer)
        {
            if (this.tinta + buffer <= 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta + buffer >= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta += buffer;
            }
        }

        // METHOD
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            Console.ForegroundColor = this.color;
            StringBuilder sb = new StringBuilder();

            if (this.tinta == 0)
            {
                sb.Append("No hay tinta");
            }

            else if (this.tinta - gasto < 0)
            {
                for (int i = 0; i < this.tinta; i++)
                {
                    sb.Append("*");
                }
                SetTinta((short)(gasto * -1));
            }
            else
            {
                for (int i = 0; i < gasto; i++)
                {
                    sb.Append("*");
                }
                SetTinta((short)(gasto * -1));
            }
            dibujo = sb.ToString();
            return true;
        }

    }


}
