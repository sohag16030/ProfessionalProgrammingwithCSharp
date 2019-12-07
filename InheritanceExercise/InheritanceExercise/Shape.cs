using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    public class Shape
    {
        private string Color;
        private bool Filled;

        public Shape()
        {
            Color = "Red";
            Filled = true;
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Given Color = {0} ", Color);
            Console.WriteLine("Given Filled = {0} ", Filled);
        }
    }
}
