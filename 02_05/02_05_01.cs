using System.Text;

namespace _02_05
{
    internal class Tabla
    {

        public static string MultiplicationTable(int number)
        {
            // Ayuda con StringBuilder https://www.dotnetperls.com/stringbuilder

            StringBuilder message = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                message.Append("\n" + number + " x " + i + " = " + number * i);
            }
            string rtn = message.ToString();
            return rtn;
        }

    }
}
