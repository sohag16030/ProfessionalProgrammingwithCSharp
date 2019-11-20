using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Circle
    {
        public double Radius { get; private set; }
        public string Color { get; private set; }

        public Circle()
        {
            Radius = 1.5;
            Color = "Red";
        }
        public Circle(double radius,string color)
        {
            Radius = radius;
            Color = color;
        }
        private double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
        public void CircleDetails()
        {
            Console.WriteLine($"Circle Radius is :{Radius}");
            Console.WriteLine($"Circle Color is :{Color}");
            Console.WriteLine("Circle Area is :"+ CalculateArea());
        }

    }
}
