using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_4
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("B value should be less than A");

            Console.WriteLine("Enter size of A line");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size of B line");
            int b = int.Parse(Console.ReadLine());

            if ( a < b)
            {
                goto Start;
            }

            Calculation calculation = new Calculation(a, b);
            calculation.LenghtCalculation();
            
            Console.WriteLine($"Count if lines B in A line {calculation.LenghtCalc}");

            Console.ReadKey();
        }
    }
}
