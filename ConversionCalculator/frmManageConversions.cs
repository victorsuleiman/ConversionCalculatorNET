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
    public partial class frmManageConversions : Form
    {
        public frmManageConversions()
        {
            InitializeComponent();
        }

        List<string> conversions = ConversionsDB.GetConversionsRaw();

        public void GetConversions()
        {
            this.ShowDialog();
        }

        private void frmManageConversions_Load(object sender, EventArgs e)
        {
            FillConversionListBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxConversions.SelectedIndex;

            if (index != -1)
            {
                conversions.RemoveAt(index);
                FillConversionListBox();
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmAddConversion newFrmAddConversion = new frmAddConversion();
            string newConversion = newFrmAddConversion.GetNewConversion();
            if (newConversion != null)
            {
                conversions.Add(newConversion);
                FillConversionListBox();
            }
        }

        private void buttonRestoreDefaults_Click(object sender, EventArgs e)
        {
            conversions = ConversionsDB.GetConversionsDefaultRaw();
            FillConversionListBox();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ConversionsDB.SaveConversions(conversions);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillConversionListBox()
        {
            listBoxConversions.Items.Clear();

            foreach (string c in conversions)
            {
                listBoxConversions.Items.Add(c);
            }
        }
    }
}
