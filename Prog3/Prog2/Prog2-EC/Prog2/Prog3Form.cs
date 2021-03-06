﻿// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: D8735

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LibraryItems
{
    public partial class Prog3Form : Form
    {
        private Library _lib; // The library

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog3Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

            // Insert test data - Magic numbers allowed here
            //_lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ25 3G", "Andrew Wright");
            //_lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            //_lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            //    "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            //    LibraryMovie.MPAARatings.PG);
            //_lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            //    "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            //_lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            //    "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            //_lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            //    "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            //_lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            //    "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            //_lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            //    "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9A", 16, 7);
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9B", 16, 8);
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9C", 16, 9);
            //_lib.AddLibraryMagazine("VB Magazine", "UofL Mags", 2017, 14, "MA21 5V", 1, 1);

            //// Add 5 Patrons
            //_lib.AddPatron("Ima Reader", "12345");
            //_lib.AddPatron("Jane Doe", "11223");
            //_lib.AddPatron("John Smith", "54321");
            //_lib.AddPatron("James T. Kirk", "98765");
            //_lib.AddPatron("Jean-Luc Picard", "33456");
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: D8735{NL}CIS 200-01{NL}Spring 2017",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        _lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        _lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }



        //Precondition: File -> Open Library item activated
        //Postcondition: Open file dialog box is opened. If data entered is ok, file is deserialized and data is input to the Library
        private BinaryFormatter reader = new BinaryFormatter(); //Object for deserializing
        private FileStream input; //Stream to read from file
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; //Result of OpenFileDialog
            string fileName; //Name of file containing data 

            using (OpenFileDialog fileSelector = new OpenFileDialog())
            {
                result = fileSelector.ShowDialog();
                fileName = fileSelector.FileName; //Retrieve file name
            }

            if (result == DialogResult.OK) //Validate that OK is clicked
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("File name is invalid"); //Error if invalid
                }
                else
                {
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read); //Create FileStream to have read access
                    _lib = (Library)reader.Deserialize(input);
                    input.Close();

                }
            }
        }



        //Precondition: File -> Save Library item activated
        //Postcondition: Save dialog box is opened. If data is ok, serialized object is outputted to a text file.
        private BinaryFormatter formatter = new BinaryFormatter(); //Create serialization object
        private FileStream output; //Stream to write to file
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName; //Name of file

            using (SaveFileDialog fileSelector = new SaveFileDialog())
            {
                fileSelector.CheckFileExists = false; //Allows user to create file
                result = fileSelector.ShowDialog();
                fileName = fileSelector.FileName; //Retrieve file name
            }

            if (result == DialogResult.OK) //Validate OK is clicked
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("File name is invalid");
                }
                else
                {
                    try //Save file through FileStream if valid
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write); //Use write access to open file
                        formatter.Serialize(output, _lib); //Serialize Object
                        output.Close();
                    }
                    catch (IOException) //If file has problems opening, exception
                    {
                        MessageBox.Show("Error occurred when opening file");
                    }
                }
            }
        }

        //Precondition: Edit -> Patron item activated
        //Postcondition: Edit Patron dialog box is displayed. If data is ok, the patron information is updated.
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons = new List<LibraryPatron>(); //Create list of library patrons
            patrons = _lib.GetPatronsList();

            editPatronForm editPatronForm = new editPatronForm(patrons); //Patron dialog box
            PatronForm patronForm = new PatronForm(); //Create PatronForm

            DialogResult result = editPatronForm.ShowDialog(); //Display form as dialog

            if(result == DialogResult.OK)
            {
                //PatronForm textboxes set to name/ID of selected Patron
                patronForm.PatronName = patrons[editPatronForm.PatronIndex].PatronName;
                patronForm.PatronID = patrons[editPatronForm.PatronIndex].PatronID;

                DialogResult result2 = patronForm.ShowDialog();
                if(result2 == DialogResult.OK)
                {
                    //New values stored in PatronForm send to the values in the associated list
                    patrons[editPatronForm.PatronIndex].PatronName = patronForm.PatronName;
                    patrons[editPatronForm.PatronIndex].PatronID = patronForm.PatronID;
                }
            }
            editPatronForm.Dispose(); //Take out garbage

        }
    }
}
