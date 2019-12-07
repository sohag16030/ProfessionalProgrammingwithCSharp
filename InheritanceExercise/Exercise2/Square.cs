using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Square : Rectangle
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
        }
        public Square(double side, string color, bool fillded)
        {
            this.Side = side;
            this.Color = color;
            this.Filled = Filled;
        }
        private double GetArea()
        {
            return Side * Side;
        }
        private double GetPerimeter()
        {
            return 4 * Side;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Square Side is :{Side}");
            Console.WriteLine($"Square Color is :{Color}");
            Console.WriteLine($"Square Filled is :{Filled}");
            Console.WriteLine("Square Area is :" + GetArea());
            Console.WriteLine("Square Perimeter is :" + GetPerimeter());
        }
    }
}
