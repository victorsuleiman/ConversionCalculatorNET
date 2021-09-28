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
    public partial class frmConversion : Form
    {

        private List<Conversion> conversions = new List<Conversion>();

        public frmConversion()
        {
            InitializeComponent();
        }

        private void frmConversion_Load(object sender, EventArgs e)
        {
            conversions = ConversionsDB.GetConversions();
            FillConversionListBox();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            //check valid input
            string msg = Validator.IsDecimal(textBoxValue.Text, textBoxValue.Tag.ToString())
                + Validator.IsPresent(textBoxValue.Text, textBoxValue.Tag.ToString());
            if (msg == "")
            {
                List<Conversion> selectedConversions = new List<Conversion>();

                decimal value = Convert.ToDecimal(textBoxValue.Text);

                //grab indexes selected
                foreach (object item in listBoxConversions.SelectedItems)
                {
                    int index = listBoxConversions.Items.IndexOf(item);
                    selectedConversions.Add(conversions[index]);
                }

                //foreach of the List<Conversion> selected, display result in listBox
                foreach (Conversion c in selectedConversions)
                {
                    listBoxResults.Items.Add(c.GetResultText(value));
                }
            }
            else
            {
                MessageBox.Show(msg);
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonManageConversions_Click(object sender, EventArgs e)
        {
            frmManageConversions mngConversionsFrm = new frmManageConversions();
            mngConversionsFrm.GetConversions();
            conversions = ConversionsDB.GetConversions();
            ClearForm();
            FillConversionListBox();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillConversionListBox()
        {
            listBoxConversions.Items.Clear();

            foreach (Conversion c in conversions)
            {
                listBoxConversions.Items.Add(c.GetDisplayText());
            }
        }

        private void ClearForm()
        {
            textBoxValue.Clear();
            listBoxConversions.ClearSelected();
            listBoxResults.Items.Clear();
        }

    }
}
