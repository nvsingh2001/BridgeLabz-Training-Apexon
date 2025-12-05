using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class RotateMatrixBy90Degree
    {
        public static int[,] RotateMatrix(int[,] matrix)
        {
            int[,] rotatedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    rotatedMatrix[j, matrix.GetLength(0) - i - 1] = matrix[i, j];
                }
            }
            return rotatedMatrix;
        }
    }
}
