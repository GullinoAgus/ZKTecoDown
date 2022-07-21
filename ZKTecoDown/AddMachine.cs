using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZKTecoDown
{
    public partial class AddMachine : Form
    {
        public AddMachine()
        {
            InitializeComponent();

            PortNumericBox.Controls[0].Hide();
            PortNumericBox.Width = PortNumericBox.Width + 16;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var templistitem = new ListViewItem(new string[] {NameTextBox.Text, IPTextBox.Text, PortNumericBox.Value.ToString()});
            IPAddressListview.Items.Add(templistitem);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in IPAddressListview.SelectedItems)
            {
                IPAddressListview.Items.Remove(item);
            }
        }

        private void IPAddressListview_SizeChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;


            var workingWidth = listView.Width;
            var col1 = 0.40;
            var col2 = 0.40;
            var col3 = 0.20;


            listView.Columns[0].Width = (int)(workingWidth * col1);
            listView.Columns[1].Width = (int)(workingWidth * col2);
            listView.Columns[2].Width = (int)(workingWidth * col3);
        }
    }
}
