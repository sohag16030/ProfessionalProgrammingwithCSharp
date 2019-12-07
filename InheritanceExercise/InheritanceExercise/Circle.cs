using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    public class Circle : Shape
    {
            protected double Radius { get; set; }
            public Circle()
            {
                Radius = 1.0;
            }
            public Circle(double radius)
            {
                this.Radius = radius;
            }
            public Circle(double radius, string color, bool filled) : base(color, filled)
            {
                this.Radius = radius;
            }
            public virtual double GetArea()
            {
                //Console.Write("Circle GetArea() is Called ::");
                return Math.PI * Radius * Radius;
            }
            public virtual double GetPerimeter()
            {
                //Console.Write("Circle Perimeter() is Called ::");
                return 2 * Math.PI * Radius;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine("Given Radius = {0} ", Radius);
                base.DisplayInfo();
                Console.WriteLine("Area = {0:0.##} ", GetArea());
                Console.WriteLine("Perimeter = {0:0.##} ", GetPerimeter());
            }
     }
 }
