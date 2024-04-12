using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание11_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("x=");
            double inputX = double.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            double inputY = double.Parse(Console.ReadLine());
            Point myPoint = new Point(inputX, inputY);
            Console.WriteLine($"Площадь прямоугольника: {myPoint.CalculateRectangleArea()}");
            Console.ReadKey();
        }
        class Point
        {
            private double x1;
            private double y1;
            public Point(double x, double y)
            {
                x1 = x;
                y1 = y;
            }
            public double CalculateRectangleArea()
            {
                double width = Math.Abs(x1);
                double height = Math.Abs(y1);

                double area = width * height;
                return area;
            }
        }

    }
}
