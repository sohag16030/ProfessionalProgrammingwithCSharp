using System;
   
namespace problem3
{
    class problem3
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n,m;
            int[,] arr1 = new int[50, 50];

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.WriteLine("Input elements in the matrix :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }
          
         
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }

                }
            }
            Console.Write("Addition of the  left and right Diagonal elements is :{0}", sum);
        }
    }
}
 

