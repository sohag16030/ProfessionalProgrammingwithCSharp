using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacedependencyExactSolution.Weapon
{
    class Gun :IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Gun Fire");
        }
    }
}
