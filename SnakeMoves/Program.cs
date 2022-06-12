using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(cmdArg[0]);
            int cowls = int.Parse(cmdArg[1]);

            char[][] array = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new char[cowls];
            }

            string snake = Console.ReadLine();
            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j = 0; j < cowls; j++)
                    {
                        array[i][j] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for(int j = cowls - 1; j >= 0; j--)
                    {

                        array[i][j] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }


                    }
                   
                }
               
            }

            for (int i = 0; i < rows; i++)
            {
                
                    for (int j = 0; j < cowls; j++)
                    {
                        Console.Write(array[i][j]);
                    }                                      
                Console.WriteLine();
            }
        }
    }
}
