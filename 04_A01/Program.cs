using System;
using Temperatura;

namespace _04_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius value1Celcius = new Celsius(32);
            Kelvin value1Kelvin = (Kelvin)value1Celcius;
            Fahrenheit value1Fahrenheit = (Fahrenheit)value1Celcius;

            Kelvin value2Kelvin = new Kelvin(287.98f);
            Celsius value2Celcius = (Celsius)value2Kelvin;
            Fahrenheit value2Fahrenheit = (Fahrenheit)value2Kelvin;

            Fahrenheit value3Fahrenheit = new Fahrenheit(-65.01f);
            Celsius value3Celcius = (Celsius)value3Fahrenheit;
            Kelvin value3Kelvin = (Kelvin)value3Fahrenheit;

            Console.WriteLine("VARIABLE       °C     °K    °F");
            Console.WriteLine("{0} {1:N2} {2:N2} {3:N2}", nameof(value1Celcius), value1Celcius.GetValueCelsius(),
                                                          value1Kelvin.GetValueKelvin(), value1Fahrenheit.GetValueFahrenheit());
            Console.WriteLine("{0} {1:N2} {2:N2} {3:N2}", nameof(value2Kelvin), value2Celcius.GetValueCelsius(),
                                                          value2Kelvin.GetValueKelvin(), value2Fahrenheit.GetValueFahrenheit());
            Console.WriteLine("{0} {1:N2} {2:N2} {3:N2}", nameof(value3Fahrenheit), value3Celcius.GetValueCelsius(),
                                                          value3Kelvin.GetValueKelvin(), value3Fahrenheit.GetValueFahrenheit());
        }
    }
}
