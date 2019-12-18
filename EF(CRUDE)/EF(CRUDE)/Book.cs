using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CRUDE_
{
    public class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int Stock { get; set; }

        public Book(string bookcode, string bookname, string bookauthor, int stock)
        {
            BookCode = bookcode;
            BookName = bookname;
            BookAuthor = bookauthor;
            Stock = stock;
        }
        //public void show()
        //{
        //    Console.WriteLine($"{BookCode} {BookName} {BookAuthor} {Stock}");
        //}

    }
}
