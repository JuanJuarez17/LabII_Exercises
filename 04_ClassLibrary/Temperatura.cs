using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        private float valueCelsius;
        public Celsius(float bufferValue)
        {
            this.valueCelsius = bufferValue;
        }
        public float GetValueCelsius()
        {
            return this.valueCelsius;
        }
        public static explicit operator Kelvin(Celsius bufferValue)
        {
            return new Kelvin(bufferValue.valueCelsius + 273.15f);
        }
        public static explicit operator Fahrenheit(Celsius bufferValue)
        {
            return new Fahrenheit((bufferValue.valueCelsius * 1.8f) + 32);
        }
    }
    public class Kelvin
    {
        private float valueKelvin;
        public Kelvin(float bufferValue)
        {
            this.valueKelvin = bufferValue;
        }
        public float GetValueKelvin()
        {
            return this.valueKelvin;
        }
        public static explicit operator Celsius(Kelvin bufferValue)
        {
            return new Celsius(bufferValue.valueKelvin - 273.15f);
        }
        public static explicit operator Fahrenheit(Kelvin bufferValue)
        {
            return new Fahrenheit(1.8f * (bufferValue.valueKelvin - 273.15f) + 32);
        }
    }
    public class Fahrenheit
    {
        private float valueFahrenheit;
        public Fahrenheit(float bufferValue)
        {
            this.valueFahrenheit = bufferValue;
        }
        public float GetValueFahrenheit()
        {
            return this.valueFahrenheit;
        }
        public static explicit operator Celsius(Fahrenheit bufferValue)
        {
            return new Celsius((bufferValue.valueFahrenheit - 32) / 1.8f);
        }
        public static explicit operator Kelvin(Fahrenheit bufferValue)
        {
            return new Kelvin((0.555555555f*(bufferValue.valueFahrenheit - 32)) + 273.15f);
        }
    }
}
