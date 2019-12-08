using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCLibrary
{
    public class AddBorrowReturnDisplayBook
    {
        
        public void BookAddition(List<Book> BookList)
        {
            
            var book = new Book();

            Console.Write("Book Code:");
            book.BookCode=(Console.ReadLine());
            Console.Write("Book Name:");
            book.BookName = (Console.ReadLine());
            Console.Write("Book Author:");
            book.BookAuthor = (Console.ReadLine());
            Console.Write("Add Stock:");
            book.Stock=int.Parse(Console.ReadLine());           
            BookList.Add(book);
            Console.WriteLine("Successfully Book Added in Library");
        }
        public void BookBorrow(List<Book> BookList)
        {
            var borrowbook = new BorrowBook();
            Console.Write("Book Code:");
            borrowbook.BookCode = Console.ReadLine();
            Console.Write("Borrow Book Quantity:");
            borrowbook.BorrowBookQuantity = int.Parse(Console.ReadLine());

            var borrowbookrecord = BookList.Single(x => x.BookCode == borrowbook.BookCode);
            if (borrowbookrecord.Stock >= borrowbook.BorrowBookQuantity)
            {
                borrowbookrecord.Stock -= borrowbook.BorrowBookQuantity;
                Console.WriteLine("Successfully Book Borrowed from Library");
            }
            else
                Console.WriteLine("Sorry given quantity is not available in stock");

        }
        public void BookReturn(List<Book> BookList)
        {
            var returnbook = new ReturnBook();
            Console.Write("Book Code:");
            returnbook.BookCode = Console.ReadLine();
            Console.Write("Return Book Quantity :");
            returnbook.ReturnBookQuantity = int.Parse(Console.ReadLine());

            var returnbookrecord = BookList.Single(x => x.BookCode == returnbook.BookCode);
            returnbookrecord.Stock +=returnbook.ReturnBookQuantity;
            Console.WriteLine("Successfully Book returned to Library");

        }
        public void DisplayBook(List<Book> BookList)
        {
            Console.WriteLine("Code Name Author Remaining Stock");

            foreach (Book items in BookList)
            {
                Console.Write(items.BookCode);
                Console.Write(" ");
                Console.Write(items.BookName);
                Console.Write(" ");
                Console.Write(items.BookAuthor);
                Console.Write(" ");
                Console.Write(items.Stock);
                Console.WriteLine(" ");
            }

        }

    }
}
