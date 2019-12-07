using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class Bomb : IFiringSelectedWeapon
    {
        public void Fire()
        {
            Console.WriteLine("=====================================> Dropping Bomb");
        }
    }
}
