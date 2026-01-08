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
        public static int[,] CreateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
          
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Random.Shared.Next(10, 100);
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
