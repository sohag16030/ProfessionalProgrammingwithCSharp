using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rad = int.Parse(Console.ReadLine());
            Circle C1 = new Circle();
            Circle C2 = new Circle(Rad,"balck");
            C1.CircleDetails();
            C2.CircleDetails();

        }
    }
}
