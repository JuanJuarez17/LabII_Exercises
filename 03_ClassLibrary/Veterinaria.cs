using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente
    {
        #region ATTRIBUTES
        private string name;
        private string surname;
        private string address;
        private string phoneNumber;
        private Mascota[] pets = new Mascota[10];
        #endregion

        #region CONSTRUCTOR
        public Cliente(string name, string surname, string address, string phoneNumber)
        {
            SetName(name);
            SetSurname(surname);
            SetAdress(address);
            SetPhoneNumber(phoneNumber);
        }
        #endregion

        #region SETTERS
        public bool SetName(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.name = buffer;
                return true;
            }
            return false;
        }
        public bool SetSurname(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.surname = buffer;
                return true;
            }
            return false;
        }
        public bool SetAdress(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.address = buffer;
                return true;
            }
            return false;
        }
        public bool SetPhoneNumber(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.phoneNumber = buffer;
                return true;
            }
            return false;
        }
        public bool SetPet(string bufferSpecie, string bufferName, DateTime bufferBirth)
        {
            for (int i = 0; i < this.pets.Length; i++)
            {
                if (this.pets[i] == null)
                {
                    this.pets[i] = new Mascota(bufferSpecie, bufferName, bufferBirth);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region GETTERS
        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public Mascota GetPet(int index)
        {
            return this.pets[index];
        }
        #endregion

        #region METHODS
        public string ShowClient()
        {
            int flagCharge = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------- DATOS CLIENTE ----------");
            sb.AppendLine($"Nombre: {this.name,27}");
            sb.AppendLine($"Apellido: {this.surname,25}");
            sb.AppendLine($"Direccion: {this.address,24}");
            sb.AppendLine($"N° Telefonico: {this.phoneNumber,20}");
            for (int i = 0; i < this.pets.Length; i++)
            {
                if (this.pets[i] != null)
                {
                    sb.AppendLine($"{this.pets[i].ShowPet()}");
                    flagCharge = 1;
                }
            }
            if (flagCharge == 0)
            {
                sb.AppendLine("---------- DATOS MASCOTA ----------");
                sb.AppendLine("--- NO HAY MASCOTAS REGISTRADAS ---");
            }
            return sb.ToString();
        }
        #endregion
    }
    public class Mascota
    {
        #region ATTRIBUTES
        private string specie;
        private string name;
        private DateTime birthday;
        private string[] vaccines = new string[10];
        #endregion

        #region CONSTRUCTOR
        public Mascota(string specie, string name, DateTime birthday)
        {
            SetSpecie(specie);
            SetName(name);
            SetBirthday(birthday);
        }
        #endregion

        #region SETTERS
        public bool SetSpecie(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.specie = buffer;
                return true;
            }
            return false;
        }
        public bool SetName(string buffer)
        {
            if (!string.IsNullOrWhiteSpace(buffer))
            {
                this.name = buffer;
                return true;
            }
            return false;
        }
        public bool SetBirthday(DateTime buffer)
        {
            if (buffer != DateTime.MinValue)
            {
                this.birthday = buffer;
                return true;
            }
            return true;
        }
        public bool SetVaccine(string buffer)
        {
            for (int i = 0; i < this.vaccines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(this.vaccines[i]))
                {
                    this.vaccines[i] = buffer;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region METHODS
        internal string ShowPet()
        {
            int flagCharge = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------- DATOS MASCOTA ----------");
            sb.AppendLine($"Especie: {this.specie,26}");
            sb.AppendLine($"Nombre: {this.name,27}");
            sb.AppendLine($"Fecha de nacimiento:      {this.birthday:d}");
            sb.AppendLine("----- HISTORIAL DE VACUNACION -----");
            for (int i = 0; i < this.vaccines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(this.vaccines[i]))
                {
                    sb.AppendLine($"Vacuna: {this.vaccines[i],27}");
                    flagCharge = 1;
                }
            }
            if (flagCharge == 0)
            {
                sb.AppendLine("--- NO HAY VACUNAS REGISTRADAS ---");
            }
            return sb.ToString();
        }
        #endregion
    }
}
