using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region ATTRIBUTES
        private double cantidad;
        private static double cotzRespectoDolar = 1d;
        #endregion

        #region CONSTRUCTOR
        private Dolar()
        {
            this.cantidad = 0;
        }
        public Dolar(double qty) : this()
        {
            this.cantidad = qty;
        }
        #endregion

        #region GETTER
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        #endregion

        #region CONVERSION OPERATORS
        // OPERADORES DE CONVERSION
        // IMPLICITOS
        public static implicit operator Dolar(double value)
        {
            Dolar valueDolar = new Dolar(value);
            return valueDolar;
        }

        // EXPLICITOS
        public static explicit operator Euro(Dolar valueDolar)
        {
            Euro valueEuro = new Euro(valueDolar.cantidad * Euro.GetCotizacion());
            return valueEuro;
        }
        public static explicit operator Peso(Dolar valueDolar)
        {
            Peso valuePeso = new Peso(valueDolar.cantidad * Peso.GetCotizacion());
            return valuePeso;
        }
        #endregion

        #region OPERATORS
        public static Dolar operator +(Dolar valueDolar1, Dolar valueDolar2)
        {
            return (valueDolar1.cantidad + valueDolar2.cantidad);
        }
        public static Dolar operator +(Dolar valueDolar, Peso valuePeso)
        {
            return valueDolar + (Dolar)valuePeso;
        }
        public static Dolar operator +(Dolar valueDolar, Euro valueEuro)
        {
            return valueDolar + (Dolar)valueEuro;
        }
        public static Dolar operator -(Dolar valueDolar1, Dolar valueDolar2)
        {
            return (valueDolar1.cantidad - valueDolar2.cantidad);
        }
        public static Dolar operator -(Dolar valueDolar, Peso valuePeso)
        {
            return valueDolar - (Dolar)valuePeso;
        }
        public static Dolar operator -(Dolar valueDolar, Euro valueEuro)
        {
            return valueDolar - (Dolar)valueEuro;
        }
        public static bool operator ==(Dolar valueDolar1, Dolar valueDolar2)
        {
            return valueDolar1.cantidad == valueDolar2.cantidad;
        }
        public static bool operator !=(Dolar valueDolar1, Dolar valueDolar2)
        {
            return !(valueDolar1 == valueDolar2);
        }
        public static bool operator ==(Dolar valueDolar1, Peso valuePeso1)
        {
            Dolar auxDolar = (Dolar)valuePeso1;
            return valueDolar1.cantidad == auxDolar.cantidad;
        }
        public static bool operator !=(Dolar valueDolar1, Peso valuePeso1)
        {
            return !(valueDolar1 == valuePeso1);
        }
        public static bool operator ==(Dolar valueDolar1, Euro valueEuro1)
        {
            Dolar auxDolar = (Dolar)valueEuro1;
            return valueDolar1.cantidad == auxDolar.cantidad;
        }
        public static bool operator !=(Dolar valueDolar1, Euro valueEuro1)
        {
            return !(valueDolar1 == valueEuro1);
        }
        #endregion
    }

    public class Euro
    {
        #region ATTRIBUTES
        private double cantidad;
        private static double cotzRespectoDolar = 0.8547d; // 1 USD = 0,8547 EUR
        #endregion

        #region CONSTRUCTOR
        private Euro()
        {
            this.cantidad = 0;
        }
        public Euro(double qty) : this()
        {
            this.cantidad = qty;
        }
        #endregion

        #region SETTERS
        public static void SetCotizacionEuro(double buffer)
        {
            Euro.cotzRespectoDolar = buffer;
        }
        #endregion

        #region GETTER
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        #endregion

        #region CONVERSION OPERATORS
        // IMPLICITOS
        public static implicit operator Euro(double value)
        {
            Euro valueEuro = new Euro(value);
            return valueEuro;
        }
        // EXPLICITOS
        public static explicit operator Dolar(Euro valueEuro)
        {
            Dolar valueDolar = new Dolar(valueEuro.cantidad / Euro.GetCotizacion());
            return valueDolar;
        }
        public static explicit operator Peso(Euro valueEuro)
        {
            Peso valuePeso = new Peso((valueEuro.cantidad / Euro.GetCotizacion()) * Peso.GetCotizacion());
            return valuePeso;
        }
        #endregion

        // Faltan los operadores +, -, == & !=
    }

    public class Peso
    {
        #region ATTRIBUTES
        private double cantidad;
        private static double cotzRespectoDolar = 102.65d; // 1 USD = 102,65 PES
        #endregion

        #region CONSTRUCTOR
        private Peso()
        {
            this.cantidad = 0;
        }
        public Peso(double qty) : this()
        {
            this.cantidad = qty;
        }
        #endregion

        #region SETTERS
        public static void SetCotizacionPeso(double buffer)
        {
            Peso.cotzRespectoDolar = buffer;
        }
        #endregion

        #region GETTER
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        #endregion

        #region CONVERSION OPERATORS
        // OPERADORES DE CONVERSION
        // IMPLICITO
        public static implicit operator Peso(double value)
        {
            Peso valuePeso = new Peso(value);
            return valuePeso;
        }

        // EXPLICITOS
        public static explicit operator Dolar(Peso valuePeso)
        {
            Dolar valueDolar = new Dolar(valuePeso.cantidad / Peso.GetCotizacion());
            return valueDolar;
        }
        public static explicit operator Euro(Peso valuePeso)
        {
            Euro valueEuro = new Euro((valuePeso.cantidad / Peso.GetCotizacion()) * Euro.GetCotizacion());
            return valueEuro;
        }
        #endregion

        // Faltan los operadores +, -, == & !=
    }
}
