using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight in KG");
            int m = int.Parse(Console.ReadLine());

            Weight weight = new Weight(m);
            weight.WeightCalculation();

            Console.WriteLine($"Full weight in TON = {weight.W}");

            Console.ReadKey();
        }
    }
}
