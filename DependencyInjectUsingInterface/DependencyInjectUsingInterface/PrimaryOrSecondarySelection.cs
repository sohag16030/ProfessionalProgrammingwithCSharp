using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class PrimaryOrSecondarySelection 
    {
        public void Attack(IFiringSelectedWeapon Weapon)
        {
            Weapon.Fire();
        }
    }
}
