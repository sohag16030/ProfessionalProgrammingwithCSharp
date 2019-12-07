using System;

namespace DependencyInjectUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select your option:");
            Console.WriteLine("1: F22\n2: Mig29\n3: Mirage5\n4: Su35");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:                   
                    WeaponSelected W1 = new WeaponSelected();
                    W1.ShowWeapon(new F22());
                    break;
                case 2:
                    WeaponSelected W2 = new WeaponSelected();
                    W2.ShowWeapon(new Mig29());
                    break;
                case 3:
                    WeaponSelected W3 = new WeaponSelected();
                    W3.ShowWeapon(new Mirage5());
                    break;
                case 4:
                    WeaponSelected W4 = new WeaponSelected();
                    W4.ShowWeapon(new Su35());
                    break;
            }
            Console.WriteLine("Select Your Primary weapon:\n1: Bomb\n2: Machine Gun\n3: Missile\n4: Laser");
            int pw = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Your Secondary weapon:\n1: Bomb\n2: Machine Gun\n3: Missile\n4: Laser");
            int sw = int.Parse(Console.ReadLine());  
            level:
            Console.WriteLine("Select your Weapon Command:\n1: Primary\n2: Secondary\n3: Exit");
            int cmnd = int.Parse(Console.ReadLine());
            switch (cmnd)
            {
                case 1:
                    if (pw == 1)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Bomb());
                    }
                    else if (pw == 2)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Machine_Gun());
                    }
                    else if (pw == 3)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Missile());
                    }
                    else if (pw == 4)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Laser());
                    }
                    break;
                case 2:
                    if (sw == 1)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Bomb());
                    }
                    else if (sw == 2)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Machine_Gun());
                    }
                    else if (sw == 3)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Missile());
                    }
                    else if (sw == 4)
                    {
                        PrimaryOrSecondarySelection ps = new PrimaryOrSecondarySelection();
                        ps.Attack(new Laser());
                    }
                    break;

                default:
                    Console.WriteLine("========================================> Game Over");
                    break;
            }
            if (cmnd == 1 || cmnd == 2)
                goto level;


        }
    }
 }

