using System;
using System.Collections.Generic;
using System.Text;

namespace ABCLibrary
{
    public class AddBorrowReturnDisplayBook
    {
        List<Book> BookList =new List<Book>();
        public void BookAddition()
        {
            var book = new Book();

            Console.Write("Book Code:");
            book.BookCode=(Console.ReadLine());
            Console.Write("Book Name:");
            book.BookName = (Console.ReadLine());
            Console.Write("Book Author:");
            book.BookAuthor = (Console.ReadLine());
            Console.Write("Add Stock:");
            book.AddStock=int.Parse(Console.ReadLine());
            
            BookList.Add(book);
            Console.WriteLine(BookList.Count);
        }
        //public void BookBorrow()
        //{
        //    var borrowbook = new BorrowBook();
        //    Console.Write("Book Code:");
        //    borrowbook.BookCode = Console.ReadLine();
        //    Console.Write("Borrow Book Quantity:");
        //    borrowbook.BorrowBookQuantity =int.Parse(Console.ReadLine());
        //    List<BorrowBook> BorrowBookList = new List<BorrowBook>();
        //    BorrowBookList.Add(borrowbook);

        //}
        //public void BookReturn()
        //{
        //    var returnbook = new ReturnBook();
        //    Console.Write("Book Code:");
        //    returnbook.BookCode = Console.ReadLine();
        //    Console.Write("Return Book Quantity");
        //    returnbook.ReturnBookQuantity = int.Parse(Console.ReadLine());
        //    List<ReturnBook> ReturnBookList = new List<ReturnBook>();
        //    ReturnBookList.Add(returnbook);

        //}
        public void DisplayBook()
        {
            
            //Console.WriteLine("Code Name Author Remaining Stock");

            //foreach (Book items in BookList)
            //{
            //    Console.WriteLine(items.BookCode);

            //}

        }
        
    }
}
