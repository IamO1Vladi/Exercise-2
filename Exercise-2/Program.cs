using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix=new int[n,n];

           for(int i = 0; i < n; i++)
            {
                int[] rowNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

              
                for(int j = 0; j < n; j++)
                {
                    matrix[i,j] = rowNumbers[j];
                }
            }

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for(int i = 0; i < n; i++)
            {
                sumPrimaryDiagonal += matrix[i, i];
            }
            
            for(int i = 0; i < n; i++)
            {
                sumSecondaryDiagonal += matrix[i, n - i - 1];
            }


            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
        }
    }
}
