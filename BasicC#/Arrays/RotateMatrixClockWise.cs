using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class RotateMatrixClockWise
    {
        public static void rotateMatrix(int[,] matrix)
        {
            int n =  matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int row, col;
            row = col = 0;

            int prev, curr;

            while(row < n || col < m)
            {
                if (row + 1 == n || col + 1 == m) break;

                prev = matrix[row + 1, col];

                for(int i = 0; i < m; i++)
                {
                    curr = matrix[row, i];
                    matrix[row, i] = prev;
                    prev = curr;
                }
                row++;

                for(int i = row; i < n; i++)
                {
                    curr = matrix[i, m - 1];
                    matrix[i, m - 1] = prev;
                    prev = curr;
                }
                m--;

                if(row < m)
                {
                    for(int i = m - 1; i >= col; i--)
                    {
                        curr = matrix[n - 1, i];
                        matrix[n - 1, i] = prev;
                        prev = curr;
                    }
                }
                n--;

                if(col < m)
                {
                    for(int i = n - 1; i >= row; i--)
                    {
                        curr = matrix[i, col];
                        matrix[i, col] = prev;
                        prev = curr;
                    }
                }
                col++;
            }
        }
    }
}
