using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Machine_Gun : IFiringSelectedWeapon
    {
        public void Fire()
        {
            Console.WriteLine("=====================================> Firing Machin Gun");
        }
    }
}

