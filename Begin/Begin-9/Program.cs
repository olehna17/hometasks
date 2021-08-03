using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value");
            double b = double.Parse(Console.ReadLine());

            AverGeom aver = new AverGeom(a, b);

            aver.Calculation();

            Console.WriteLine($"The geometric mean of a and b = {aver.Square}");

            Console.ReadKey();



        }
    }
}
