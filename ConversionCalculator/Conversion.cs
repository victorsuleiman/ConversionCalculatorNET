using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionCalculator
{
    public class Conversion
    {
        private string from;
        private string to;
        private decimal multiplier;

        public Conversion (string from, string to, decimal multiplier)
        {
            this.from = from;
            this.to = to;
            this.multiplier = multiplier;
        }

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        public decimal Multiplier
        {
            get { return multiplier; }
            set { multiplier = value; }
        }

        public string GetDisplayText()
        {
            return From + " to " + To;
        }

        public string GetResultText (decimal value)
        {
            decimal result = value * Multiplier;
            string resultFormatted = String.Format("{0:0.##}", result);
            return value + " " + From + " = " + resultFormatted + " " + To;
        }
    }
}
