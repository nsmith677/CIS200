//Program 2
//CIS200-01
//Due: 3/9/2017
//By: D8735

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
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
        }

        public String PatronName
        {
            //Precondition: None
            //Postcondition: The form's name text has been returned
            get
            {
                return nameTxtBox.Text;
            }
            //Precondition: None
            //Postcondition: The form's name text has been set to value
            set
            {
                nameTxtBox.Text = value;
            }
        }

        public String PatronID
        {
            //Precondition: None
            //Postcondition: The form's id text has been returned
            get
            {
                return idTxtBox.Text;
            }
            //Precondition: None
            //Postcondition: The form's id text has been set to value
            set
            {
                idTxtBox.Text = value;
            }
        }

        private void nameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(nameTxtBox, "Please provide a valid name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void idTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (idTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(idTxtBox, "Please provide a valid ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //Precondition: User clicks on okButton
        //Postcondition: Return OK and close the form
        private void okButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren()) //If all controls will validate
            {
                this.DialogResult = DialogResult.OK; //Form will close and return OK as a result
            }
        }

        //Precondition: User clicks on cancelButton
        //Postcondition: Return Cancel and close the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void nameTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTxtBox, "");

        }

        private void idTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(idTxtBox, "");

        }
    }
}
