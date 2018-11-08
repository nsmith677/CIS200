// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: D8735

// File: EditBook.cs
// This class creates the Edit Book dialog box form. It performs validation
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
    public partial class EditBook : Form
    {
        private List<LibraryItem> books; //List of Library Books

        //Precondition: List is populated wiht available Library Books
        //Postcondition: GUI is ready for display
        public EditBook(List<LibraryItem> bookList)
        {
            InitializeComponent();
            books = bookList;
        }

        //Precondition: None
        //Postcondition: Combo box populated with list of books
        private void EditBook_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem book in books) //Populate combo box
            {
                selectBookComboBox.Items.Add(book.Title + ", " + book.CallNumber);
            }
        }

        public int BookIndex
        {
            //Precondition: None
            //Postcondition: Selected book index returned
            get
            {
                return selectBookComboBox.SelectedIndex;
            }
        }

        //Precondtion: Focus shifts from selectBookComboBox
        //Postcondition: ErrorProvider highlights field if invalid
        private void selectBookComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (selectBookComboBox.SelectedIndex == -1) //Nothing is selected
            {
                e.Cancel = true;
                errorProvider1.SetError(selectBookComboBox, "Please select a book!");
            }
        }

        //Precondition: Data is OK
        //Postcondition: ErrorProvider cleared
        private void selectBookComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(selectBookComboBox, "");
        }

        //Precondition: OK button clicked
        //Postcondition: If there is an invalid field, it recieves the focus. If not, return OK and form closes.
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) //If all controls validate
            {
                this.DialogResult = DialogResult.OK; //Form closes and OK result returned
            }
        }

        //Precondition: Cancel button pressed
        //Postcondtion: Result is cancelled and form is closed
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
