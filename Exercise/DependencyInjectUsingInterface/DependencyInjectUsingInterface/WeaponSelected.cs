using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectUsingInterface
{
    public class WeaponSelected
    {
        public void ShowWeapon(ISelectedWeapon Weapon)
        {
            Weapon.DisplayWeapon();
        }
    }
}
