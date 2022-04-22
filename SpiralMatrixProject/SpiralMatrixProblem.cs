using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrixProject
{
    /**
     * Class Name           : SpiralMatrixProblem
     * Constructor          : NA
     * Static/Abstract/Base : NA
     * Access Specifier     : Public [For Test Class to Consume]
     */
    public class SpiralMatrixProblem
    {
        /** Method SpiralOrder - Find index of any particular number in a Matrix Array
          
          * 3 Inputs are: 
               *   matrix      =   Actual Matrix 
                                    Sample Input:   {  1,  2,  3,  4,  5,  6 },
                                                    { 20, 21, 22, 23, 24,  7 },
                                                    { 19, 32, 33, 34, 25,  8 },
                                                    { 18, 31, 36, 35, 26,  9 },
                                                    { 17, 30, 29, 28, 27, 10 },
                                                    { 16, 15, 14, 13, 12, 11 }
               *   numberToFind =  A number in Matrix to find the position
                                    Sample Input: 11
               *   matrixSize   =  Size of the Actual Matrix
                                    Sample Input: 6
           
          * Return: 2D Array with the position
                    Sample OutPut: [6, 6]
        */
        public int[,] SpiralOrder(int[,] matrix, int numberToFind, int matrixSquareSize)
        {
            //Set values for all sides of matrix to Identify
            int topRow = 0, rightColUpDown = matrix.GetLength(1) - 1;
            int bottomRow = matrix.GetLength(0) - 1, leftColDownUp = 0;

            //Variable to return - 2D Array
            int[,]? returnLocation = null;

            //Always start from TopLeft -> TopRight, TopRight -> RightBottom, RightBottom -> LeftBottom, LeftBottom -> TopLeft...
            int direction = 0;

            while (rightColUpDown >= leftColDownUp && bottomRow >= topRow)
            {
                //TopLeft -> TopRight
                if (direction == 0)
                {
                    for (int i = leftColDownUp; i <= rightColUpDown; i++)
                    {
                        if (matrix[topRow, i] == numberToFind)
                        {
                            returnLocation = new int[topRow + 1, i + 1];
                            return returnLocation;
                        }
                    }
                    topRow++;
                }
                // TopRight -> RightBottom
                else if (direction == 1)
                {
                    for (int i = topRow; i <= bottomRow; i++)
                    {
                        if (matrix[i, rightColUpDown] == numberToFind)
                        {
                            returnLocation = new int[i + 1, rightColUpDown + 1];
                            return returnLocation;
                        }
                    }
                    rightColUpDown--;
                }
                // RightBottom -> LeftBottom
                else if (direction == 2)
                {
                    for (int i = rightColUpDown; i >= leftColDownUp; i--)
                    {
                        if (matrix[bottomRow, i] == numberToFind)
                        {
                            returnLocation = new int[bottomRow + 1, i + 1];
                            return returnLocation;
                        }
                    }
                    bottomRow--;
                }
                // LeftBottom -> TopLeft
                else if (direction == 3)
                {
                    for (int i = bottomRow; i >= topRow; i--)
                    {
                        if (matrix[i, leftColDownUp] == numberToFind)
                        {
                            returnLocation = new int[i + 1, leftColDownUp + 1];
                            return returnLocation;
                        }
                    }
                    leftColDownUp++;
                }

                direction = (direction + 1) % matrixSquareSize;
            }

            return returnLocation;

        }
    }
}
