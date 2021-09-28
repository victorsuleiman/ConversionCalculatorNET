using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionCalculator
{
    public partial class frmAddConversion : Form
    {
        public frmAddConversion()
        {
            InitializeComponent();
        }

        private string conversion = null;

        public string GetNewConversion()
        {
            this.ShowDialog();
            return conversion;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string msg = validateEntries();
            if (msg == "")
            {
                conversion = textBoxFrom.Text + "|" + textBoxTo.Text + "|" + textBoxMultiplier.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string validateEntries()
        {
            string msg = "";

            msg += Validator.IsPresent(textBoxFrom.Text, textBoxFrom.Tag.ToString())
                + Validator.IsNotDigitOnly(textBoxFrom.Text, textBoxFrom.Tag.ToString())

                + Validator.IsPresent(textBoxTo.Text, textBoxTo.Tag.ToString())
                + Validator.IsNotDigitOnly(textBoxTo.Text, textBoxTo.Tag.ToString())

                + Validator.IsPresent(textBoxMultiplier.Text, textBoxMultiplier.Tag.ToString())
                + Validator.IsDecimal(textBoxMultiplier.Text, textBoxMultiplier.Tag.ToString());

            return msg;
        }
    }
}
