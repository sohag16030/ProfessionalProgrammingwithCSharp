using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
        class Square : Rectangle
        {
        public Square(double side)
        {
           Width = side;
           Length = side;
        }
        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
            Width = side;
            Length = side;
        }
        

        public override double GetArea()
        {
            Console.Write("Square GetArea() is Called ::");
            return Width * Length;
        }
        public override double GetPerimeter()
        {
            Console.Write("Square Perimeter() is Called ::");
            return 2 * (Width + Length);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Area = {0:0.##} ", GetArea());
            Console.WriteLine("Perimeter = {0:0.##} ", GetPerimeter());
        }
    }
 }

