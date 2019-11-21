using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Circle : Shape
    {
        public double Height { get; set; }
        public double Radius { get; set; }
        public Circle()
        {
            this.Radius = 1.0;

        }
        public Circle(double radius)
        {
            this.Radius = radius;

        }
        public Circle(double radius, string color, bool filled)
        {
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;
        }
        private double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
        private  double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle Radius is :{Radius}");
            Console.WriteLine($"Circle Color is :{Color}");
            Console.WriteLine($"Circle Filled is :{Filled}");
            Console.WriteLine("Circle Area is :" + GetArea());
            Console.WriteLine("Circle Perimeter is :" + GetPerimeter());
        }
    }
}
