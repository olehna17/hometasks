using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value B");
            int B = int.Parse(Console.ReadLine());

            int summ = 0;
            int i = A + 1;
            while (i < B)
            {
                summ += i;
                i++;
                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Console.ReadKey();
        }
    }
}
