using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacedependencyExactSolution
{
    interface IPlane
    {
        IWeapon PrimaryWeapon { get; set; }
        IWeapon SecondaryWeapon { get; set; }
    }
}
