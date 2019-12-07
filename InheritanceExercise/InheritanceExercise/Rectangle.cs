using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Length { get; set; }
        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.Width = width;
            this.Length = length;
        }
        public virtual double GetArea()
        {
            Console.Write("Rectangle GetArea() is Called ::");
            return Width * Length;
        }
        public virtual double GetPerimeter()
        {
            Console.Write("Rectangle Perimeter() is Called ::");
            return 2 * (Width + Length);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Given Width = {0} ", Width);
            Console.WriteLine("Given Length = {0} ", Length);
            base.DisplayInfo();
            Console.WriteLine("Area = {0:0.##} ", GetArea());
            Console.WriteLine("Perimeter = {0:0.##} ", GetPerimeter());
        }
    }
}
