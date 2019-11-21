using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Cylinder : Circle
    {
        public Cylinder()
        {
            this.Height = 1.0;
        }
        public Cylinder(double height)
        {
            this.Height = height;
        }
        public Cylinder(double height, double radius)
        {
            this.Height = height;
            this.Radius = radius;
        }
        public Cylinder(double height, double radius, string color, bool filled)
        {
            this.Height = height;
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;
        }
        private double GetArea()
        {
            return 2 * 3.14 * Radius * (Height + Radius);
        }
        private double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Cylinder Hieght is :{Height}");
            Console.WriteLine($"Cylinder Radius is :{Radius}");
            Console.WriteLine($"Cylinder Color is :{Color}");
            Console.WriteLine($"Cylinder Filled is :{Filled}");
            Console.WriteLine("Cylinder Area is :" + GetArea());
            Console.WriteLine("Cylinder Perimeter is :" + GetPerimeter());
        }
    }
}
