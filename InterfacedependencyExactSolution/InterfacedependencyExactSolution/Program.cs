using InterfacedependencyExactSolution.Plane;
using InterfacedependencyExactSolution.Weapon;
using System;

namespace InterfacedependencyExactSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select Plane");
            Console.WriteLine("1: F22");
            Console.WriteLine("2: Mig29");
          
            int planeOption = Convert.ToInt32(Console.ReadLine());

            IPlane plan = null;
            switch (planeOption)
            {
                case 1:
                    plan = new F22();
                    break;
                case 2:
                    plan = new Mig29();
                    break;
              
                default:
                    break;
            }
            Console.WriteLine("You have selected" + plan.GetType().Name);
            Console.WriteLine("Select Primary Weapon:");
            Console.WriteLine("1: Bomb");
            Console.WriteLine("2: Gun");
            int primaryOption = Convert.ToInt32(Console.ReadLine());
            switch (primaryOption)
            {
                case 1:
                    plan.PrimaryWeapon = new Bomb();
                    break;
                case 2:
                    plan.PrimaryWeapon = new Gun();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Select Secondary Weapon:");
            Console.WriteLine("1: Bomb");
            Console.WriteLine("2: Gun");
            int secondaryOption = Convert.ToInt32(Console.ReadLine());
            switch (secondaryOption)
            {
                case 1:
                    plan.SecondaryWeapon = new Bomb();
                    break;
                case 2:
                    plan.SecondaryWeapon = new Gun();
                    break;
                default:
                    break;
            }
            while (true)
            {
                Console.WriteLine("Select Attack Option:");
                Console.WriteLine("1: Primary");
                Console.WriteLine("2: Secondary");
                int attckOption = Convert.ToInt32(Console.ReadLine());
                switch (attckOption)
                {
                    case 1:
                        plan.PrimaryWeapon.Attack();
                        break;
                    case 2:
                        plan.SecondaryWeapon.Attack();
                        break;
                    default:
                        break;
                }
                if (attckOption > 2)
                {
                    break;
                }
            }
            Console.WriteLine("Game Over");
        }
    
    }
}
