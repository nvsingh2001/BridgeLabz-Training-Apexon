using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class MatrixSpiralForm
    {
        public static void PrintSpiralForm(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int row = 0;
            int col = 0;

            while(row < n && col < m)
            {
                if (row + 1 == n || col + 1 == m) break;

                for(int i = 0; i < m; i++)
                {
                    Console.Write(matrix[row, i] + " ");
                }
                row++;

                for(int i = row; i < n; i++)
                {
                    Console.Write(matrix[i, m - 1] + " ");
                }
                m--;

                if(row < n)
                {
                    for(int i = m - 1; i >= col; i--)
                    {
                        Console.Write(matrix[n - 1, i] + " ");
                    }
                    n--;
                }

                if(col < m)
                {
                    for(int i = n - 1; i > row; i--)
                    {
                        Console.Write(matrix[i, col] + " ");
                    }
                    col++;
                }
            }
        }
    }
}
