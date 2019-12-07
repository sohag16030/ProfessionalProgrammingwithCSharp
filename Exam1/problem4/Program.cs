using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n, m,k;
            int[,] arr1 = new int[50, 50];

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("Input elements in the matrix :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                   
                }
            }
            int upp = 0, low = 0, lef = 0, rig = 0;
            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++)
                {
                    upp = i - 1;low = i + 1;lef = j - 1;rig = j + 1;
                    if(upp>=0&&upp<n)
                    sum = arr1[upp,j];
                    if (low >= 0 && low < n)
                        sum = sum + arr1[low, j];
                    if (lef >= 0 && lef < n)
                        sum = sum + arr1[i, lef];
                    if (rig >= 0 && rig < n)
                        sum = sum + arr1[i, rig];
                }
                Console.WriteLine(sum);

            }


        }
    }
}
