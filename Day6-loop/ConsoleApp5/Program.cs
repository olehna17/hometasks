using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter count of clients");
            int c = int.Parse(Console.ReadLine());

            //count of cars pre described in exercise 
            int factorial = 1;

            do
            {
                factorial *= c--;
            }
            while (c > 0);

            Console.WriteLine($"Count of variants of way {factorial}");

            Console.ReadKey();
        }
    }
}
