using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size in Byte");
            int b = int.Parse(Console.ReadLine());

            Byte byteinkylo = new Byte(b);
            byteinkylo.ByteToKyloCalculation();

            Console.WriteLine($"Full size in Kilobyte = {byteinkylo.Kylo}");

            Console.ReadKey();
        }
    }
}
