using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Laser : IFiringSelectedWeapon
    {
        public void Fire()
        {
            Console.WriteLine("=====================================> Firing Laser");
        }
    }
}
