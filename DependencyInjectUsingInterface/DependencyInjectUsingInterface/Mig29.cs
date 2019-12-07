using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Mig29 : ISelectedWeapon
    {
        public void DisplayWeapon()
        {
            Console.WriteLine("You have Selcted : Mig29\n====================================");
        }
    }
}
