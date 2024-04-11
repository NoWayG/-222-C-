using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] massiv = new int[5, 10];
            Console.WriteLine("Значение массива");
            Random rand = new Random();

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    massiv[x, y] = rand.Next(1, 100);
                }
            }

            for (int x = 0; x < massiv.GetLength(0); x++)
            {
                for (int y = 0; y < massiv.GetLength(1); y++)
                {
                    Console.Write(massiv[x, y] + "\t");
                }
                Console.WriteLine("");
            }
            int minElement = massiv[0, 0];
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    if (minElement > massiv[i, j])
                    {
                        minElement = massiv[i, j];
                    }
                }
            }
            Console.WriteLine($"Минимальный элемент массива:{minElement}");
            Console.ReadKey();
        }
    }
}
