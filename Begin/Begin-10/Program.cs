using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value");
            double b = double.Parse(Console.ReadLine());

            Operations operations = new Operations(a, b);

            operations.Calculation();

            Console.WriteLine($"Suma chisel a i b = {operations.SumOper}");
            Console.WriteLine($"Raznica chisel a i b = {operations.DifferenceOper}");
            Console.WriteLine($"Proizvedenie chisel a i b = {operations.MultiplyOper}");
            Console.WriteLine($"Chasnost' chisel a i b = {operations.DivOper}");

            Console.ReadKey();
        }
    }
}
