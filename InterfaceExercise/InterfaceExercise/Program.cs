using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select your option:");
            Console.WriteLine("1: F22\n2: Mig29\n3: Mirage5\n4: Su35");
            int n=int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("You have selected : F22\n=====================================");
                    WeaponClass W1 = new WeaponClass();
                    W1.WeaponSelct();
                    break;
                case 2:
                    Console.WriteLine("You have selected : Mig29\n===================================");
                    WeaponClass W2 = new WeaponClass();
                    W2.WeaponSelct();
                    break;
                case 3:
                    Console.WriteLine("You have selected : Mirage5\n===================================");
                    WeaponClass W3 = new WeaponClass();
                    W3.WeaponSelct();
                    break;
                case 4:
                    Console.WriteLine("You have selected : Su35\n====================================");
                    WeaponClass W4 = new WeaponClass();
                    W4.WeaponSelct();
                    break;
            }
            
        }
    }
}
