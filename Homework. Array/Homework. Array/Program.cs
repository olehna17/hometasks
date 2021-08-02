using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of element of array");
            int n = int.Parse(Console.ReadLine());

            Class1 class1 = new Class1(n);

            class1.Print();
           
            Console.WriteLine();


            
            Console.WriteLine($"Min number - {class1.Min()}");
            Console.WriteLine($"Max number - {class1.Max()}");
            Console.WriteLine($"Sum  - {class1.Sum()}");
            Console.WriteLine($"Arifm  - {class1.Arifm()}");
            class1.Num();


            Console.ReadKey();
        }
    }
}
