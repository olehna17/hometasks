using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side1");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Side2");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            rectangle.AreaCalc();
            rectangle.PerimCalc();

            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perim);


            Console.ReadKey();

           
        }
    }
}
