using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem, flag = 0, temp;

            Console.Write("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);

            if (temp == 1)
                Console.Write("Number is not Prime");
            else
            {
                int m = temp / 2;
                for (int i = 2; i <= m; i++)
                {
                    if (temp % i == 0)
                    {
                        Console.Write("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.Write("Number is Prime.");
            }
        }
    }
}
