/* Grading ID: D8735
 * Program 0
 * 1/20/2017
 * CIS200-01
 * LibraryBook holds the data for the book and validates it, LibraryPatron holds the data for the patron and validates it, 
 * Program prints the data to the console. */

// Program 0
// Starting Point

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            1, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        LibraryBook[] theBooks = { book1, book2, book3, book4, book5 }; // Test array of books
        List<LibraryBook> BooksList = new List<LibraryBook>(); //List to hold books
        BooksList.AddRange(theBooks); //add elements of theBooks array to list


        Console.WriteLine("Original list of books");
        PrintBooks(BooksList);

        LibraryPatron patron1 = new LibraryPatron("John Smith", "A1"); //1st Patron
        LibraryPatron patron2 = new LibraryPatron("Jane Doe", "A2"); //2nd Patron
        LibraryPatron patron3 = new LibraryPatron("Michael Scott", "A3"); //3rd Patron

        //Make changes
        book1.CheckOut(patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);




        Console.WriteLine("After changes");
        PrintBooks(BooksList);

        // Return all the books
        for (int i = 0; i < theBooks.Length; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books");
        PrintBooks(BooksList);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> b)
    {

        foreach (LibraryBook value in b)
        {
            Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
