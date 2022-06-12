using System;

namespace KnightsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[numberOfRows, numberOfRows];

            for (int i = 0; i < numberOfRows; i++)
            {

                string rowInfo = Console.ReadLine();

                for (int j = 0; j < numberOfRows; j++)
                {

                    char knightOrNot = rowInfo[j];

                    chessBoard[i, j] = knightOrNot;
                }
            }


            int maxAttackRow=0;
            int maxAttackCOwl=0;
            int counter = 0;
            while (true)
            {

            int maxAttakcs = 0;
            int finalMaxAttacks = 0;

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfRows; j++)
                    {

                        if (chessBoard[i, j] == 'K')
                        {


                            if (isIndexValid(numberOfRows, i - 1, j - 2))
                            {
                                if (chessBoard[i - 1, j - 2] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i - 2, j - 1))
                            {
                                if (chessBoard[i - 2, j - 1] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i - 2, j + 1))
                            {
                                if (chessBoard[i - 2, j + 1] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i - 1, j + 2))
                            {
                                if (chessBoard[i - 1, j + 2] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i + 1, j + 2))
                            {
                                if (chessBoard[i + 1, j + 2] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i + 2, j + 1))
                            {
                                if (chessBoard[i + 2, j + 1] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i + 2, j - 1))
                            {
                                if (chessBoard[i + 2, j - 1] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }
                            if (isIndexValid(numberOfRows, i + 1, j - 2))
                            {
                                if (chessBoard[i + 1, j - 2] == 'K')
                                {
                                    maxAttakcs++;
                                }
                            }


                        }

                        if (maxAttakcs > finalMaxAttacks)
                        {
                            finalMaxAttacks = maxAttakcs;
                            maxAttackRow = i;
                            maxAttackCOwl = j;
                        }
                        maxAttakcs = 0;

                    }
                }

                if (finalMaxAttacks == 0)
                {
                    break;
                }
                else
                {
                    chessBoard[maxAttackRow, maxAttackCOwl] = '0';

                    counter++;

                  
                   
                }
            }

            Console.WriteLine(counter);



           
        }


        public static bool isIndexValid(int size, int i, int j){

            if (i < 0 || j < 0 || i >= size || j >= size)
            {
                return false;
            }
            else
            {
                return true;
            }


            }
            
           



    }
}
