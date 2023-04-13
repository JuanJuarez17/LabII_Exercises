using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ClassLibrary
{
    public class Conductor
    {
        #region ATTRIBUTES
        private string name;
        private int[] trails = new int[7];
        #endregion

        #region CONSTRUCTOR
        public Conductor(string name, int[] trails)
        {
            SetName(name);
            SetTrails(trails);
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
        public bool SetTrails(int[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                this.trails[i] = buffer[i];
            }
            return true;
        }
        #endregion

        #region GETTERS
        public string GetName()
        {
            return this.name;
        }
        public int GetTrial(int day)
        {
            return this.trails[day - 1];
        }
        #endregion

        #region METHODS
        public string ShowDriver()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.name}");
            for (int i = 0; i < 7; i++)
            {
                sb.AppendLine($"Recorrido Dia {i + 1}: {this.trails[i]}");
            }
            return sb.ToString();
        }
        public int AccumulativeTrail()
        {
            int accu = 0;

            for (int i = 0; i < this.trails.Length; i++)
            {
                accu += this.trails[i];
            }
            return accu;
        }
        public static int AccumulativeTrailStatic(Conductor driver)
        {
            int accu = 0;

            for (int i = 0; i < driver.trails.Length; i++)
            {
                accu += driver.trails[i];
            }
            return accu;
        }
        #endregion
    }
}