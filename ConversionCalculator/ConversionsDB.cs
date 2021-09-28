using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConversionCalculator
{
    public static class ConversionsDB
    {
        private const string dir = @"..\..\";
        private const string path = dir + "Conversions.txt";
        private const string pathDefault = dir + "ConversionsDefault.txt";

        public static List<Conversion> GetConversions()
        {
            List<Conversion> conversions = new List<Conversion>();

            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                string from = columns[0];
                string to = columns[1];
                decimal multiplier = Convert.ToDecimal(columns[2]);

                Conversion conversion = new Conversion(from, to, multiplier);

                conversions.Add(conversion);

            }

            textIn.Close();

            return conversions;

        }

        public static List<string> GetConversionsRaw()
        {
            List<string> conversions = new List<string>();

            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();

                conversions.Add(row);

            }

            textIn.Close();

            return conversions;

        }

        public static List<string> GetConversionsDefaultRaw()
        {
            List<string> conversions = new List<string>();

            StreamReader textIn = new StreamReader(
                new FileStream(pathDefault, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();

                conversions.Add(row);

            }

            textIn.Close();

            return conversions;

        }

        public static void SaveConversions(List<string> conversions)
        {

            StreamWriter textOut = new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (string c in conversions)
            {
                textOut.WriteLine(c);
            }

            textOut.Close();

        }


    }
}
