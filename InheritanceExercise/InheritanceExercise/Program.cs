using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle(2);
            s1.DisplayInfo();
            Console.WriteLine("===========================================");
            Shape s2 = new Cylinder(2, 3);
            s2.DisplayInfo();
            Console.WriteLine("===========================================");
            Shape s3 = new Rectangle(2, 3);
            s3.DisplayInfo();
            Console.WriteLine("===========================================");
            Shape s4 = new Square(2, "Green", false);
            s4.DisplayInfo();
            Console.WriteLine("===========================================");
        }
    }
}
