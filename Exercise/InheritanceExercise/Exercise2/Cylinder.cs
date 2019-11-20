using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Cylinder
    {
       public double Height { get; set; }
       public double Radius { get; set; }
       public string Color { get; set; }
       public bool Filled { get; set; }
        public Cylinder()
        {
            Height = 1.0;
        }
        public Cylinder(double height)
        {
           Height = height;
        }
        public Cylinder(double height, double radius)
        {
            Height = height;
            Radius = radius;
        }
        public Cylinder(double height, double radius, string color, bool filled)
        {
            Height = height;
            Radius = radius;
            Color = color;
            Filled = filled;
        }
       public virtual double GetArea()
        {
            return 2 * 3.14 * Radius * (Height + Radius);
        }
       public virtual double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public virtual void  DisplayInfo()
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
