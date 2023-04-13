using System;
using System.ComponentModel;
using System.Text;

namespace _03_02_ClassLibrary_01
{
    public class Persona
    {
        // ATTRIBUTE
        private string name;
        private DateTime birthDay;
        int dni;

        // CONSTRUCTOR
        public Persona(string name, DateTime birthDay, int dni)
        {
            SetName(name);
            SetBirthDay(birthDay);
            SetDni(dni);
            //this.name = name;
            //this.birthDay = birthDay;
            //this.dni = dni;
        }

        // SETTERS
        public bool SetName(string buffer)
        {
            if (string.IsNullOrWhiteSpace(buffer))
            {
                this.name = "Sin nombre";
                return false;
            }
            this.name = buffer;
            return true;
        }

        public bool SetBirthDay(DateTime buffer)
        {
            if (buffer == DateTime.MinValue)
            {   
                this.birthDay = new DateTime(1990,03,16);
                return false;
            }
            this.birthDay = buffer;
            return true;
        }

        public bool SetDni(int buffer)
        {
            if (buffer <= 0)
            {
                this.dni = 30000000;
                return false;
            }
            this.dni = buffer;
            return true;
        }

        // GETTERS

        public string GetName()
        {
            return this.name;
        }

        public DateTime GetBirthDay()
        {
            return this.birthDay;
        }

        public int GetDni()
        {
            return this.dni;
        }

        // METHOD

        private int CalculateAge()
        {
            int age;
            DateTime presentDate = DateTime.Today;

            age = presentDate.Year - this.birthDay.Year;

            return age;
        }

        public string ShowPerson()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DE LA PERSONA");
            sb.AppendLine($"Nombre: {name}");
            sb.AppendLine($"Fecha de nacimiento: {birthDay.ToShortDateString()}");
            sb.AppendLine($"Edad: {CalculateAge()}");
            sb.AppendLine($"DNI: {dni}");
            return sb.ToString();
        }

        public string EsMayordeEdad()
        {
            if (CalculateAge() < 18)
            {
                return "es menor de edad.";
            }
            return "es mayor de edad.";
        }
    }
}
