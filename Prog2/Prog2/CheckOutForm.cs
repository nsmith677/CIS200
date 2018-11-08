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
    public partial class CheckOutForm : Form
    {
        private List<LibraryItem> items; //List of items
        private List<LibraryPatron> patrons; //List of patrons


        public CheckOutForm(List<LibraryItem> itemList, List<LibraryPatron> patronList)
        {
            InitializeComponent();

            items = itemList;
            patrons = patronList;
           
        }

        //Precondition: None
        //Postcondition: The items and patrons list are used to populate the combo boxes
        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in items)
            {
                itemComboBox.Items.Add(item.Title + ", " + item.CallNumber);
            }
            foreach (LibraryPatron patron in patrons)
            {
                patronComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);
            }
        }

        public int ItemIndex
        {
            //Precondition: None
            //Postcondition: The index of the selected item is returned
            get
            {
                return itemComboBox.SelectedIndex;
            }
        }
        public int PatronIndex
        {
            //Precondition: None
            //Postcondition: The index of the selected patron is returned
            get
            {
                return patronComboBox.SelectedIndex;
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

        private void patronComboBox_Validating(object sender, CancelEventArgs e)
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


        //Precondition: User clicks on okButton
        //Postcondition: Return OK and close the form
        private void okButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren()) //If all controls will validate
            {
                this.DialogResult = DialogResult.OK; //Form will close and return OK as a result
            }
        }

        //Precondition: User clicks on cancelButton
        //Postcondition: Return Cancel and close the form
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemComboBox,"");

        }

        private void patronComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronComboBox, "");

        }
    }
}
