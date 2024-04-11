using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 6];
            Console.WriteLine("Значение массива");
            Random rand = new Random();

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    matrix[x, y] = rand.Next(1, 25);
                }
            }
            PrintMatrix(matrix);
            Swap(matrix);
            Console.WriteLine("После сортировки");
            PrintMatrix(matrix);

            Console.Read();
        }

        private static void Swap(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int jIndex = 0;
                int maxElement = int.MinValue;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        jIndex = j;
                    }
                }

                int temp = matrix[i, i];
                matrix[i, i] = matrix[i, jIndex];
                matrix[i, jIndex] = temp;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
