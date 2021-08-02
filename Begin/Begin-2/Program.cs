using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of square");
            double Side1 = double.Parse(Console.ReadLine());

            Calculation calculation = new Calculation(Side1);

            calculation.AreaCalc();

            Console.WriteLine(calculation.Area);

            Console.ReadKey();
        }
    }
}
