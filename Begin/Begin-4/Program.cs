using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter diametr");
            double d = double.Parse(Console.ReadLine());

            Calculate longCircle = new Calculate(d);

            longCircle.LongCalc();

            Console.WriteLine($"Long of Circle is {longCircle.Long}");

            Console.ReadKey();
        }
    }
}
