using System;
using System.Collections.Generic;

namespace ADO.NET_crude_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC Library System\nPlease select an Option\n1:Add Book\n2:Borrow Book\n3:Return Book\n4:Display List\n5:Exit");
            while (true)
            {
                Console.Write("Please Select an Option:");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        new InsertUpdateOperation().InsertBook();
                        break;
                    case 2:
                        new InsertUpdateOperation().BookBorrow();
                        break;
                    case 3:
                        new InsertUpdateOperation().BookReturn();
                        break;
                    case 4:
                        List<Book> booklist = new InsertUpdateOperation().DisplayBook();
                        foreach(var item in booklist)
                        {
                            item.show();
                        }
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
