﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4_3
{
    internal class Program
    {
        static void Main()
        {
            int n = 7;
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else if (i < j)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 2;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
