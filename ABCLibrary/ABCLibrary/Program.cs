using System;
using System.Collections.Generic;

namespace ABCLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC Library System\nPlease select an Option\n1:Add Book\n2:Borrow Book\n3:Return Book\n4:Display List\n5:Exit");
            List<Book> BookList = new List<Book>();
            while (true)
            {
                Console.Write("Please Select an Option:");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:                        
                            AddBorrowReturnDisplayBook Obj1 = new AddBorrowReturnDisplayBook();
                            Obj1.BookAddition(BookList);
                            break;
                    case 2:
                        AddBorrowReturnDisplayBook Obj2 = new AddBorrowReturnDisplayBook();
                        Obj2.BookBorrow(BookList);                        
                        break;
                    case 3:
                        AddBorrowReturnDisplayBook Obj3 = new AddBorrowReturnDisplayBook();
                        Obj3.BookReturn(BookList);
                        break;
                    case 4:
                        AddBorrowReturnDisplayBook Obj4 = new AddBorrowReturnDisplayBook();
                        Obj4.DisplayBook(BookList);
                        break;
                    case 5:
                        Console.WriteLine("Thanks for using ABCLibrary");
                        break;
                }
                if (Option == 5)
                    break;
               
            }
           
        }

    }
}
