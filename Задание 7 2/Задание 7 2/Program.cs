using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_2
{
    internal class Program
    {
        static void Main()
        {
            char[] charArray = { 'a', 'm', 'c', 'd', 'z', 'i', 'f', 'g', 'h', 'i' };
            bool abc = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        Console.WriteLine($"Найдены повторяющиеся символы: {charArray[i]}");
                        abc = true;
                        break;
                    }
                }
                if (abc)
                {
                    break;
                }
            }
            if (!abc)
            {
                Console.WriteLine("Повторяющиеся символы не найдены.");
            }
            Console.ReadKey();
        }
    }
}
