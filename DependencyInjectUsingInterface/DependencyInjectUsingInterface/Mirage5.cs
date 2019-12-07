using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Mirage5 : ISelectedWeapon
    {
        public void DisplayWeapon()
        {
            Console.WriteLine("You have Selcted : Mirage5\n====================================");
        }
    }
}
