using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    class Cylinder : Circle
    {
        private double Height;
        public Cylinder()
        {
            Height = 1.0;
        }
        public Cylinder(double height)
        {
            this.Height = height;
        }
        public Cylinder(double height, double radius) : base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double height, double radius, string color, bool filled) : base(radius, color, filled)
        {
            this.Height = height;
        }
        public override double GetArea()
        {
            Console.Write("Cylinder GetArea() is Called ::");
            return 2 * Math.PI * Radius * (Height + Radius);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Given height = {0} ", Height);
            base.DisplayInfo();

        }
    }
}
