using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание11_2
{
    class Parallelepiped
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public Parallelepiped()
        {
            _sideA = 1;
            _sideB = 1;
            _sideC = 1;
        }
        public Parallelepiped(double a, double b, double c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }
        ~Parallelepiped()
        {
            Console.WriteLine("Объект уничтожен");
        }
        public double CalculateSurfaceArea()
        {
            return 2 * (_sideA * _sideB + _sideA * _sideC + _sideB * _sideC);
        }
        public double CalculateEdgesSum()
        {
            return 4 * (_sideA + _sideB + _sideC);
        }
        public string GetInfo()
        {
            return $"Стороны: {_sideA}, {_sideB}, {_sideC}";
        }
        static void Main()
        {
            Parallelepiped constantParallelepiped = new Parallelepiped();
            Console.WriteLine("Параметры:");
            Console.WriteLine(constantParallelepiped.GetInfo());
            Console.WriteLine($"Площадь: {constantParallelepiped.CalculateSurfaceArea()}");
            Console.WriteLine($"Сумма всех рёбер: {constantParallelepiped.CalculateEdgesSum()}");
            Console.WriteLine("Введите новые стороны:");
            double inputA = double.Parse(Console.ReadLine());
            double inputB = double.Parse(Console.ReadLine());
            double inputC = double.Parse(Console.ReadLine());
            Parallelepiped userParallelepiped = new Parallelepiped(inputA, inputB, inputC);
            Console.WriteLine("Введенная инфа:");
            Console.WriteLine(userParallelepiped.GetInfo());
            Console.WriteLine($"Новая площадь поверхности: {userParallelepiped.CalculateSurfaceArea()}");
            Console.WriteLine($"Новая сумма всех рёбер: {userParallelepiped.CalculateEdgesSum()}");
            Console.Read();
        }

    }
}
