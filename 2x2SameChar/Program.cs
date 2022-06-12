using System;
using System.Linq;

namespace _2x2SameChar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(cmdArg[0]);
            int cowls = int.Parse(cmdArg[1]);

            char[][] array = new char[rows][];

            for(int i = 0; i < rows; i++)
            {
                array[i] = new char[cowls];
            }

           

            for(int i = 0; i < rows; i++)
            {
                char[] arrayInfoRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < cowls; j++)
                {
                    array[i][j] = arrayInfoRow[j];
                }
            }

            int count = 0;

            for(int i = 0; i < rows-1; i++)
            {
                for(int j = 0; j < cowls-1; j++)
                {
                    bool isTrue = true;
                    for(int rowStart = i; rowStart <= i + 1; rowStart++)
                    {
                        for(int cowlStart = j; cowlStart <= j + 1; cowlStart++)
                        {
                            if (array[i][j] != array[rowStart][cowlStart])
                            {
                                isTrue = false;
                                
                            }
                        }
                        if (isTrue == false)
                        {
                            break;
                        }
                    }
                    if (isTrue)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
