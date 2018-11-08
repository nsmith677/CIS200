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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public String BookTitle
        {
            //Precondition: None
            //Postcondition: The title text field is returned
            get
            {
                return titleTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The title text field is set to value
            set
            {
                titleTxtBox.Text = value;
            }
        }

        public String BookPublisher
        {
            //Precondition: None
            //Postcondition: The publisher text field is returned
            get
            {
                return publisherTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The publisher text field is set to value
            set
            {
                publisherTxtBox.Text = value;
            }
        }

        public String BookCopyright
        {
            //Precondition: None
            //Postcondition: The copyright text field is returned
            get
            {
                return copyrightTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The copyright text field is set to value
            set
            {
                copyrightTxtBox.Text = value;
            }
        }

        public String BookLoanPeriod
        {
            //Precondition: None
            //Postcondition: The loan period text field is returned
            get
            {
                return loanPeriodTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The loan period text field is set to value
            set
            {
                loanPeriodTxtBox.Text = value;
            }
        }

        public String BookCallNumber
        {
            //Precondition: None
            //Postcondition: The call number text field is returned
            get
            {
                return callNumberTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The call number text field is set to value
            set
            {
                callNumberTxtBox.Text = value;
            }
        }

        public String BookAuthor
        {
            //Precondition: None
            //Postcondition: The author text field is returned
            get
            {
                return authorTxtBox.Text;
            }

            //Precondtion: None
            //Postcondition: The author text field is set to value
            set
            {
                authorTxtBox.Text = value;
            }
        }

        private void titleTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (titleTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(titleTxtBox, "Please provide a valid title");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void publisherTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (publisherTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(publisherTxtBox, "Please provide a valid publisher");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void copyrightTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (copyrightTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(copyrightTxtBox, "Please provide a valid copyright");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void loanPeriodTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (loanPeriodTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(loanPeriodTxtBox, "Please provide a valid loan period");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void callNumberTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (callNumberTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(callNumberTxtBox, "Please provide a valid call number");
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
            if (ValidateChildren()) //If all controls will validate
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

        private void titleTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTxtBox, "");
        }

        private void publisherTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(publisherTxtBox, "");

        }

        private void copyrightTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(copyrightTxtBox, "");

        }

        private void loanPeriodTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(loanPeriodTxtBox, "");

        }

        private void callNumberTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(callNumberTxtBox, "");

        }

        private void authorTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTxtBox, "");

        }

        private void authorTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (authorTxtBox.TextLength == 0)
            {
                errorProvider1.SetError(authorTxtBox, "Please provide a valid author");
            }
            else
            {
                errorProvider1.Clear();
            }

        }
    }

}
