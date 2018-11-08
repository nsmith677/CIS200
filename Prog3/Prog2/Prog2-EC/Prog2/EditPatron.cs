// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: D8735

// File: Edit Patron.cs
// This class creates the Edit Patron dialog box form. It performs validation
// and an int get property for the field associated with the selected index property.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class editPatronForm : Form
    {
        private List<LibraryPatron> patrons; //List of Library Patrons

        //Precondition: List is populated wiht available Library Patrons
        //Postcondition: GUI is ready for display
        public editPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();
            patrons = patronList;
        }

        //Precondition: None
        //Postcondition: Combo box is populated with patrons
        private void EditPatronForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in patrons) //Populate combo box
            {
                selectPatronComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);
            }
        }

        public int PatronIndex
        {
            //Precondition: None
            //Postcondition: Selected patron idex returned
            get
            {
                return selectPatronComboBox.SelectedIndex;
            }
        }

        //Precondition: Focus shifts from selectPatronComboBox 
        //Postcondition: ErrorProvider highlights the field if invalid
        private void SelectPatronComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (selectPatronComboBox.SelectedIndex == -1) //Nothing is selected
            {
                e.Cancel = true;
                errorProvider1.SetError(selectPatronComboBox, "Please select a patron");
            }
        }

        //Precondition: Data is OK
        //Postcondition: ErrorProvider cleared
        private void SelectPatronComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(selectPatronComboBox, "");
        }

        //Precondition: OK button pressed
        //Postcondition: If there is an invalid field, it recieves the focus. If not, return OK and form closes.
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //Precondition: Cancel button pressed
        //Postcondtion: Result is cancelled and form is closed
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
