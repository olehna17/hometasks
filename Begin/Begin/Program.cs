using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            double Side1 = 4;

            Console.WriteLine("Enter Side2 value");
            double side2 = double.Parse(Console.ReadLine());

            Calculation calculation = new Calculation(Side1, side2);

            calculation.Perimetr();

            Console.WriteLine(calculation.Perim);

            Console.ReadKey();
        
        }
    }
}
