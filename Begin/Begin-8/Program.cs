using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            double a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter b value");
            double b = double.Parse(Console.ReadLine());

            Average average = new Average(a, b);

            average.AverageCalculation();

            Console.WriteLine($"Average of a and b is {average.AverageVal}");

            Console.ReadKey();

        }
    }
}
