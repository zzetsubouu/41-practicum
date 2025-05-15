using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practicum
{
    class Program
    {
        static double Min(double x, double y)
        {
            if (x > y)
            {
                return y;
            }
            else if (x < y)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
        static double Max(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return 0;
            }
        }
        delegate double HigherOrGreater(double x, double y);
        static void Main(string[] args)
        {
            HigherOrGreater min = Min;
            HigherOrGreater max = Max;

            Console.WriteLine("введите первое число");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(min(num1, num2));
            Console.WriteLine(max(num1, num2));
        }
    }

}
