using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listboxV22_222
{
    internal class Program
    {
        static void Main()
        {
            {
                var random = new Random();
                int[] massiv = new int[10];
                for (int i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = random.Next(1, 10);
                }
                double product = 1.0;
                foreach (int number in massiv)
                {
                    product *= number;
                }
                double geometricMean = Math.Pow(product, 1.0 / massiv.Length);
                Console.WriteLine("Среднее геометрическое: {0}", geometricMean);
            }
            Console.ReadKey();
        }
    }
}
