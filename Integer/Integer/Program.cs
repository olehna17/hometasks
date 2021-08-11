using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of line in CM");
            int l = int.Parse(Console.ReadLine());

            Division division = new Division(l);
            division.LenghtCalculation();

            Console.WriteLine($"Lenght of line in FULL meters = {division.Lenght}");

            Console.ReadKey();
        }
    }
}
