using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Circle : Cylinder
    {
        public Circle()
        {
            Radius = 1.0;
        
        }
        public Circle(double radius)
        {
            Radius = radius;
       
        }
        public Circle(double radius, string color, bool filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }
       public override double GetArea()
        {
            return 3.14 * Radius*Radius;
        }
       public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override void  DisplayInfo()
        {
            Console.WriteLine($"Circle Radius is :{Radius}");
            Console.WriteLine($"Circle Color is :{Color}");
            Console.WriteLine($"Circle Filled is :{Filled}");
            Console.WriteLine("Circle Area is :" + GetArea());
            Console.WriteLine("Circle Perimeter is :" + GetPerimeter());
        }
    }
}
