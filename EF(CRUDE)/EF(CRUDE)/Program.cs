using System;

namespace EF_CRUDE_
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();
            Book newbook = new Book("B221", "Algo", "Shmit", 30);
            db.Add(newbook);
            db.SaveChanges();
        }
    }
}
