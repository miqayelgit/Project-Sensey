using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Classes
{
    public static class MatrixService
    {
        public static int[,] CreateMatrix(int size)
        {
            int[,] matrix = new int[size, size];
          
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.Shared.Next(0, 10);
                }
            }

            return matrix;
        }

        public static int SumMainDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i,i]; 
            }

            return sum;
        }
        public static int SumSecondaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            int j = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
                j--;
            }

            return sum;
        }

        public static int SumAbovePrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            int j = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if(i == matrix.GetLength(0) - 1) break;

                for (j = i + 1; j < matrix.GetLength(1); ++j)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}
