// Program 1B
// CIS 200-01
// Due: 4/19/2017
// By: D8735

// File: DescendingSort.cs
// This file sorts items by Copyright Year in descending order using the IComparer Interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescendingSort : IComparer<LibraryItem>
    {
        //Precondition: None
        //Postcondition: Reverse the order of Copyright Year so it's descending
        public int Compare(LibraryItem libItem1, LibraryItem libItem2)
        {
            if (libItem1 == null && libItem2 == null) //Both null?
                return 0; //Equal

            if (libItem1 == null) //only libItem1 is null?
                return -1; //null is less than Copyright Year

            if (libItem2 == null) //only libItem2 is null?
                return 1; //Copright Year is greater than null


            if (libItem1.CopyrightYear.CompareTo(libItem2.CopyrightYear) != 0)
                return libItem1.CopyrightYear.CompareTo(libItem2.CopyrightYear);
            else if (libItem1.Title.CompareTo(libItem2.Title) != 0)
                return libItem1.Title.CompareTo(libItem2.Title);
            else
                return libItem1.Publisher.CompareTo(libItem2.Publisher);



        }
    }
}
