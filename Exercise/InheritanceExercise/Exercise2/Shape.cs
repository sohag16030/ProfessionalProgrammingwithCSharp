using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Shape
    {
     
        public string Color { get; set; }
        public bool Filled { get; set; }

        public Shape()
        {
            this.Color = "red";
            this.Filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }
        public virtual void DisplayInfo()
        {

            Console.WriteLine($"Shape Color is :{Color}");
            Console.WriteLine($"Shape Filled is :{Filled}");

        }
    }
}
