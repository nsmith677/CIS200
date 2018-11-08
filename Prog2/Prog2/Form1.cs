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
    public partial class MainForm : Form
    {
        private Library library; //The Library
        public MainForm()
        {
            InitializeComponent();
            library = new Library();
        }

        //Precondition: File -> About menu item is activated
        //Postcondition: Information is displayed in MessageBox
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 2{0}Grading ID: D8735{0}" + "Due Date: March 9th{0}Section: CIS200-01{0}",
                Environment.NewLine), "About Program 2");
        }

        //Precondition: File -> Exit menu item is activated
        //Postcondition: Application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Precondition: Report -> Patron menu item is activated
        //Postcondition: List of patrons is displayed
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); //New patron dialog box fomr
            DialogResult result = patronForm.ShowDialog(); //Show form and store result

            if( result == DialogResult.OK)
            {
                library.AddPatron(patronForm.PatronName, patronForm.PatronID); //Get patron info and send to library
            }
        }

        //Precondition: Insert -> book item is activated
        //Postcondition: New book is inserted
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            DialogResult result = bookForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                library.AddLibraryBook(bookForm.BookTitle, bookForm.BookPublisher, int.Parse(bookForm.BookCopyright),
                    int.Parse(bookForm.BookLoanPeriod), bookForm.BookCallNumber, bookForm.BookAuthor);
            }
        }

        //Precondition: Item -> Checkout item is activated
        //Postcondition: item is checked out
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items; //List of library items
            List<LibraryPatron> patrons; //List of library patrons

            items = library.GetItemsList();
            patrons = library.GetPatronsList();

            CheckOutForm checkoutForm = new CheckOutForm(items, patrons); //Check out dialog box form
            DialogResult result = checkoutForm.ShowDialog(); //Show form as dialog & store the result
            if(result == DialogResult.OK)
            {
                library.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
            }

        }


        //Precondition: Item -> return item is activated
        //Postcondition: Item is returned
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items; //List of library items
            List<LibraryPatron> patrons; //List of library patrons

            items = library.GetItemsList();
            patrons = library.GetPatronsList();

            ReturnForm returnForm = new ReturnForm(items); //Check out dialog box form
            DialogResult result = returnForm.ShowDialog(); //Show form as dialog & store the result
            if (result == DialogResult.OK)
            {
                library.ReturnToShelf(returnForm.ItemIndex);
            }
        }

        //Precondition: Report -> PatronList item is activated
        //Postcondition: Patron List is displayed
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds the text while the report is being built
            List<LibraryPatron> patrons; //List of library patrons
            patrons = library.GetPatronsList();
            result.Append(String.Format("List of Patrons - {0} patrons", library.GetPatronCount()));
            result.Append(Environment.NewLine);
            result.Append(Environment.NewLine);

            foreach(LibraryPatron lp in patrons)
            {
                result.Append(lp.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTextBox.Text = result.ToString(); //Display the result
        }

        //Precondition: Report -> ItemList item is activated
        //Postcondition: Item List is displayed
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds the text while the report is being built
            List<LibraryItem> items; //List of library items
            items = library.GetItemsList();
            result.Append(String.Format("List of Items - {0} items", library.GetItemCount()));
            result.Append(Environment.NewLine);
            result.Append(Environment.NewLine);

            foreach (LibraryItem item in items)
            {
                result.Append(item.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTextBox.Text = result.ToString(); //Display the result
        }

        //Precondition: Report -> CheckOutList item is activated
        //Postcondition: Checkout List is displayed
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds the text while the report is being built
            List<LibraryItem> items; //List of library patrons
            items = library.GetItemsList();

            //LINQ to select the checked out items
            var checkedOut =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append(String.Format("List of Checked Out Items - {0} items", library.GetItemCount()));
            result.Append(Environment.NewLine);
            result.Append(Environment.NewLine);

            foreach (LibraryItem item in checkedOut)
            {
                result.Append(item.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTextBox.Text = result.ToString(); //Display the result

        }
    }
}

