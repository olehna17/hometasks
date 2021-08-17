using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_6
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("Enter value between 10 and 99");
            int a = int.Parse(Console.ReadLine());

            Calculation calculation = new Calculation(a);
            calculation.LenghtCalculation();

            if (a > 10 & a < 100)
            {
                Console.WriteLine($"Wright part: {calculation.LenghtCalc}, Left Part: {calculation.RestCalc}");
            }
            else
            {
                goto Start;
            }
            Console.ReadKey();
        }
    }
}

