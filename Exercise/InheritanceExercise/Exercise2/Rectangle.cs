using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Rectangle : Square
    {
       public double Width { get; set; }
       public double Length { get; set; }

        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public Rectangle(double width, double length, string color,bool filled)
        {
            Width = width;
            Length = length;
            Color = color;
            Filled = filled;
        }
        public override double GetArea()
        {
            return 2 * 3.14 * Length * (Width + Length);
        }
        public override double GetPerimeter()
        {
            return 2 * 3.14 * Length;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Width is :{Width}");
            Console.WriteLine($"Rectangle Length is :{Length}");
            Console.WriteLine($"Rectangle Color is :{Color}");
            Console.WriteLine($"Rectangle Filled is :{Filled}");
            Console.WriteLine("Rectangle Area is :" + GetArea());
            Console.WriteLine("Rectangle Perimeter is :" + GetPerimeter());
        }
    }
}
