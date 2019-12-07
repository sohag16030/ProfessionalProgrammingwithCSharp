using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacedependencyExactSolution.Plane
{
    internal class Mig29 :IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }
    }
}

