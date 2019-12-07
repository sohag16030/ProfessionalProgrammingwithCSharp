using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacedependencyExactSolution.Weapon
{
    class Bomb : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Bomb Drop");
        }
    }
}
