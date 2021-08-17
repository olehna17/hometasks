using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_10
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("Enter value between 100 and 1000");
            int a = int.Parse(Console.ReadLine());

            Calculation calculation = new Calculation(a);
            calculation.LenghtCalculation();

            if (a >= 100 & a <= 1000)
            {
                Console.WriteLine($"Last number: {calculation.RestCalc}, Dozens: {calculation.LenghtCalc}");
            }
            else
            {
                goto Start;
            }
            Console.ReadKey();
        }
    }
}
