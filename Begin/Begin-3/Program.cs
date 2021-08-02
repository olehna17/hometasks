using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side1");
            double Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side2");
            double Side2 = double.Parse(Console.ReadLine());

            Calculation calculation = new Calculation(Side1, Side2);

            calculation.PerimetrCalc();
            calculation.AreaCalc();

            Console.WriteLine($"Area {calculation.Area}");
            Console.WriteLine($"Perimetr {calculation.Perim}");

            Console.ReadKey();

        }
    }
}
