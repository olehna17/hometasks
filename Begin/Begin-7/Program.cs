using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of circle");
            double r = double.Parse(Console.ReadLine());

            Circle circle = new Circle(r);

            circle.LineCalc();
            circle.SurfaceCalc();

            Console.WriteLine($"Line value {circle.Line}");
            Console.WriteLine($"Surface value {circle.Surface}");

            Console.ReadKey();
        }
    }
}
