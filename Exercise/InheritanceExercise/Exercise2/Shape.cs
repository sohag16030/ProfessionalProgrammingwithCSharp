using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Shape 
    {
        static void Main(string[] args)
        {
            Cylinder cy = new Cylinder(2, 3.4, "BLUE", true);
            cy.GetArea();
            cy.DisplayInfo();
            Cylinder cy1 = new Circle(3,"RED", true);
            cy1.GetArea();
            cy1.DisplayInfo();
            Square sq = new Square(3, "BLUE", true);
            sq.GetArea();
            sq.DisplayInfo();
            Square sq1 = new Rectangle(2.4,3, "RED", true);
            sq1.GetArea();
            sq1.DisplayInfo();


        }
    }
}
