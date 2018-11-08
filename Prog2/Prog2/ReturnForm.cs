// Program 2
// CIS 200-01
// Due: 2/15/2017
// By: D8735
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class ReturnForm : Form
    {
        private List<LibraryItem> items; //List of Library Items
        public ReturnForm(List<LibraryItem> itemList)
        {
            InitializeComponent();
            items = itemList;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in items)
            {
                itemComboBox.Items.Add(item.Title + ", " + item.CallNumber);
            }
        }

        //Precondition: None
        //Postcondition: The index of the selected item is returned
        public int ItemIndex
        {
            get
            {
                return itemComboBox.SelectedIndex;
            }
        }

        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (itemComboBox.SelectedIndex == -1) //Nothing is selected
            {
                errorProvider1.SetError(itemComboBox, "Please select an item");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) //If all controls will validate
            {
                this.DialogResult = DialogResult.OK; //Form will close and return OK as a result
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemComboBox, "");
        }
    }
}
