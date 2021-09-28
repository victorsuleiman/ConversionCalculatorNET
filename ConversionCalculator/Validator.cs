using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionCalculator
{
    public static class Validator
    {
        private static string lineEnd = "\n";

        public static string LineEnd
        {
            get
            {
                return lineEnd;
            }
            set
            {
                lineEnd = value;
            }
        }

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        public static string IsNotDigitOnly (string value, string name)
        {
            string msg = "";
            bool digitOnly = true;
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    digitOnly = false;
                }

                if (c == '.')
                {
                    digitOnly = true;
                }
            }

            if (digitOnly)
            {
                msg += name + " cannot be only digits." + LineEnd;
            }

            return msg;
        }
    }
}
