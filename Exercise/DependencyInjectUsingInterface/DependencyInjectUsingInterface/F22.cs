using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class F22 : ISelectedWeapon
    {
        public void DisplayWeapon()
        {
            Console.WriteLine("You have Selcted : F22\n====================================");
        }
    }
}
