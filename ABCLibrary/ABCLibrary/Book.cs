using System;
using System.Collections.Generic;
using System.Text;

namespace ABCLibrary
{
    public class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int AddStock { get; set; }
        public List<BorrowBook> BorrowBooks { get; set; }
        public List<ReturnBook> ReturnBooks { get; set; }

    }
}
