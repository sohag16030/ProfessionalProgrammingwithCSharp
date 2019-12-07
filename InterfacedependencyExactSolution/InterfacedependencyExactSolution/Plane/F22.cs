using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacedependencyExactSolution.Plane
{
    internal class F22 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get ; set; }
    }
}
