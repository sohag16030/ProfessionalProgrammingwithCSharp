using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Su35 : ISelectedWeapon
    {
        public void DisplayWeapon()
        {
            Console.WriteLine("You have Selcted : Su35\n====================================");
        }
    }
}
