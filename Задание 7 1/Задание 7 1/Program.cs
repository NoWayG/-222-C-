using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_1
{
    internal class Program
    {
        static void Main()
        {
            char[] symbols = new char[12] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
            for (int i = 0; i < symbols.Length; i++)
            {
                int doubledCode = (int)symbols[i] * 2;
                Console.WriteLine("Символ: " + symbols[i] + ", ИТог: " + doubledCode);
            }
            Console.ReadKey();
        }

    }
}
