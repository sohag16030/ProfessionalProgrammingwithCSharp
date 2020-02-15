using System;

namespace EF_CRUDE_
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();
            Book newbook = new Book("B213","jango","pabble",54);
            db.Add(newbook);
            db.SaveChanges();

        }
    }
}
