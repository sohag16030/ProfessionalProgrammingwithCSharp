using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year:");
            int year = int.Parse(Console.ReadLine());
            if (year < 1971 || year > 2019)
                Console.WriteLine("Sorry,You provide an invalide year. Try again");
           
                
        }
    }
}
