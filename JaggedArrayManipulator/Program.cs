using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberRows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[numberRows][];

            for(int i = 0; i < numberRows; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for(int i = 0; i < numberRows-1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                        
                    }
                    for(int j = 0; j < matrix[i + 1].Length; j++)
                    {
                        matrix[i + 1][j] /= 2;
                    }
                }
            }


            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


            while (cmdArg[0] != "End")
            {

                if (cmdArg[0] == "Add")
                {
                    int rowIndex = int.Parse(cmdArg[1]);
                    int cowlIndex = int.Parse(cmdArg[2]);

                    int value = int.Parse(cmdArg[3]);

                    if (rowIndex < 0 || rowIndex >= numberRows)
                    {
                        cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    if (cowlIndex < 0 || cowlIndex >= matrix[rowIndex].Length)
                    {
                        cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }

                    matrix[rowIndex][cowlIndex] += value;
                }else if(cmdArg[0]== "Subtract")
                {
                    int rowIndex = int.Parse(cmdArg[1]);
                    int cowlIndex = int.Parse(cmdArg[2]);

                    int value = int.Parse(cmdArg[3]);

                    if (rowIndex < 0 || rowIndex >= numberRows)
                    {
                        cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    if (cowlIndex < 0 || cowlIndex >= matrix[rowIndex].Length)
                    {
                        cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }

                    matrix[rowIndex][cowlIndex] -= value;
                }


                cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }








            for(int i = 0; i < numberRows; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
