using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(cmdArg[0]);
            int cowls = int.Parse(cmdArg[1]);

            int[][] array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cowls];
            }


            for (int i = 0; i < rows; i++)
            {
                int[] arrayInfoRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < cowls; j++)
                {
                    array[i][j] = arrayInfoRow[j];
                }
            }

            int currentSum = 0;
            int maxSum = 0;
            int rowIndex=0;
            int cowlsIndex=0;

            for(int i = 0; i < rows-2; i++)
            {
                for(int j = 0; j < cowls-2; j++)
                {
                    currentSum = 0;
                    for(int x = i; x < i+3; x++)
                    {
                        for(int y = j; y < j+3; y++)
                        {

                            currentSum += array[x][y];

                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = i;
                        cowlsIndex = j;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for(int i = rowIndex; i < rowIndex + 3; i++)
            {
                for(int j = cowlsIndex; j < cowlsIndex + 3; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
