using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Missile : IFiringSelectedWeapon
    {
        public void Fire()
        {
            Console.WriteLine("=====================================> Firing Missile");
        }
    }
}
