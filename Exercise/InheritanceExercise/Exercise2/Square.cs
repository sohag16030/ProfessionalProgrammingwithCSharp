using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Square
    {
       public double Side { get; set; }
       public string Color { get; set; }
       public bool Filled { get; set; }
        public Square()
        {
            
        }
        public Square(double side)
        {
            Side = side;
        }
        public Square(double side, string color,bool fillded)
        {
            Side = side;
            Color = color;
            Filled = Filled;
        }
        public virtual double GetArea()
        {
            return Side*Side;
        }
        public virtual double GetPerimeter()
        {
            return 4*Side;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Square Side is :{Side}");
            Console.WriteLine($"Square Color is :{Color}");
            Console.WriteLine($"Square Filled is :{Filled}");
            Console.WriteLine("Square Area is :" + GetArea());
            Console.WriteLine("Square Perimeter is :" + GetPerimeter());
        }
    }
}
