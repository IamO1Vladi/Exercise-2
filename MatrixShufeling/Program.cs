using System;
using System.Linq;

namespace MatrixShufeling
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(cmdArg[0]);
            int cowls = int.Parse(cmdArg[1]);

            string[][] array = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new string[cowls];
            }


            for (int i = 0; i < rows; i++)
            {
                string[] arrayInfoRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < cowls; j++)
                {
                    array[i][j] = arrayInfoRow[j];
                }
            }


            string[] cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (cmdCommands[0] != "END")
            {
                
                if (cmdCommands[0] == "swap")
                {
                    int firstRow = int.Parse(cmdCommands[1]);
                    int firstColw = int.Parse(cmdCommands[2]);
                    int secondRow = int.Parse(cmdCommands[3]);
                    int secondColw = int.Parse(cmdCommands[4]);

                    if(firstColw<0 || firstColw >= cowls)
                    {
                        Console.WriteLine("Invalid input!");
                        cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    else
                    if (firstRow < 0 || firstRow >= rows)
                    {
                        Console.WriteLine("Invalid input!");
                        cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    else
                    if (secondColw < 0 || secondColw >= cowls)
                    {
                        Console.WriteLine("Invalid input!");
                        cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    else
                    if (secondRow < 0 || secondRow >= rows)
                    {
                        Console.WriteLine("Invalid input!");
                        cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }

                    string currentString = array[firstRow][firstColw];
                    array[firstRow][firstColw] = array[secondRow][secondColw];
                    array[secondRow][secondColw] = currentString;

                   
                    for(int i = 0; i < rows; i++)
                    {
                        for(int j = 0; j < cowls; j++)
                        {
                            Console.Write(array[i][j]+" ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                cmdCommands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }



        }



        


    }
}
