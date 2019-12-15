using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace ADO.NET_crude_
{
    public class InsertUpdateOperation
    {
        string connectionString = "Server=DESKTOP-VKV44NQ;Database=ABCLibrary;Integrated Security=True";
        public void InsertBook()
        {
            try
            {
                Console.Write("Book Code:");
                string bookCode = (Console.ReadLine());
                Console.Write("Book Name:");
                string bookName = (Console.ReadLine());
                Console.Write("Book Author:");
                string bookAuthor = (Console.ReadLine());
                Console.Write("Add Stock:");
                int bookstock = int.Parse(Console.ReadLine());

                //string Sql="insert into BookList values('"+bookCode+"','"+bookName+"','"+bookAuthor+"','"+bookstock+"')";
                string sql = "insert into BookList values(@BookCode,@BookName,@BookAuthor,@Stock)";
                using (var connection = new SqlConnection(connectionString))
                {

                    using (var command = new SqlCommand(sql, connection))
                    {
                        var bookCodeParam = new SqlParameter("@BookCode", System.Data.SqlDbType.NVarChar);
                        bookCodeParam.Value = bookCode;
                        var bookNameParam = new SqlParameter("@BookName", System.Data.SqlDbType.NVarChar);
                        bookNameParam.Value = bookName;
                        var bookAuthorParam = new SqlParameter("@BookAuthor", System.Data.SqlDbType.NVarChar);
                        bookAuthorParam.Value = bookAuthor;
                        var bookStockParam = new SqlParameter("@Stock", System.Data.SqlDbType.Int);
                        bookStockParam.Value = bookstock;

                        command.Parameters.Add(bookCodeParam);
                        command.Parameters.Add(bookNameParam);
                        command.Parameters.Add(bookAuthorParam);
                        command.Parameters.Add(bookStockParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Successfully Book added in Library ");
            }
            catch (Exception)
            {
                Console.WriteLine("Opps!Book is not added in Library");
            }
        }

        public void BookBorrow()
        {
        Console.Write("Book Code:");
        string bookCode = Console.ReadLine();
        Console.Write("Borrow Book Quantity:");
        int borrowBookQuantity = int.Parse(Console.ReadLine());
        List<Book> BorrowBookRecord = new List<Book>();
        string sql = "select * from BookList where BookCode='"+bookCode+"'";
        using (var connection = new SqlConnection(connectionString))
        {

           using (var command = new SqlCommand(sql, connection))
            {

              connection.Open();
               using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                         {                           
                                string bookcode = reader["BookCode"].ToString();
                                string bookname = reader["BookName"].ToString();
                                string bookauthor = reader["BookAuthor"].ToString();
                                int bookstock = int.Parse(reader["Stock"].ToString());
                                Book book = new Book(bookcode, bookname, bookauthor, bookstock);
                                BorrowBookRecord.Add(book);
                            }

                        }

                    }
                }

           
                if(BorrowBookRecord[0].Stock >= borrowBookQuantity)
                {
                    string Sql = "update BookList set Stock=@stock where BookCode=@bookcode";
                    using (var connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand command = new SqlCommand(Sql, connection))
                        {
                        var codeParam = new SqlParameter("@bookcode", System.Data.SqlDbType.NVarChar);
                        codeParam.Value = bookCode;
                        command.Parameters.Add(codeParam);
                        var stockParam = new SqlParameter("@stock", System.Data.SqlDbType.Int);
                        stockParam.Value = BorrowBookRecord[0].Stock - borrowBookQuantity;
                        command.Parameters.Add(stockParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        }
                    }
                Console.WriteLine("Successfully Book borrwed from Libray");
                }
               else
               {
                Console.WriteLine("Sorry given quantity is not available on Stock");
               }
    }
        public void BookReturn()
        {
                Console.Write("Book Code:");
                string bookCode = Console.ReadLine();
                Console.Write("Return Book Quantity:");
                int returnBookQuantity = int.Parse(Console.ReadLine());
                List<Book> ReturnBookRecord = new List<Book>();
                string sql = "select * from BookList where BookCode='" + bookCode + "'";
                using (var connection = new SqlConnection(connectionString))
                {

                    using (var command = new SqlCommand(sql, connection))
                    {

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string bookcode = reader["BookCode"].ToString();
                                string bookname = reader["BookName"].ToString();
                                string bookauthor = reader["BookAuthor"].ToString();
                                int bookstock = int.Parse(reader["Stock"].ToString());
                                Book book = new Book(bookcode, bookname, bookauthor, bookstock);
                                ReturnBookRecord.Add(book);
                            }

                        }

                    }
                }
           

                string Sql = "update BookList set Stock=@stock where BookCode=@bookcode";
                using (var connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand command = new SqlCommand(Sql, connection))
                    {
                        var codeParam = new SqlParameter("@bookcode", System.Data.SqlDbType.NVarChar);
                        codeParam.Value = bookCode;
                        command.Parameters.Add(codeParam);
                        var stockParam = new SqlParameter("@stock", System.Data.SqlDbType.Int);
                        stockParam.Value = ReturnBookRecord[0].Stock + returnBookQuantity;
                        command.Parameters.Add(stockParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                Console.WriteLine("Successfully Book returned to Libray");           
          
        }

        public List<Book> DisplayBook()
        {   
            List<Book> BookList = new List<Book>();
            string sql = "select * from BookList";
            
            using (var connection = new SqlConnection(connectionString))
            {

                using (var command = new SqlCommand(sql, connection))
                {
                    
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {                           
                            string bookcode = reader["BookCode"].ToString();
                            string bookname = reader["BookName"].ToString();
                            string bookauthor = reader["BookAuthor"].ToString();
                            int bookstock = int.Parse(reader["Stock"].ToString());
                            Book book = new Book(bookcode, bookname, bookauthor,bookstock);
                            BookList.Add(book);
                        }
                      
                    }
                   
                }
            }
            return BookList;

        }
    }
}
