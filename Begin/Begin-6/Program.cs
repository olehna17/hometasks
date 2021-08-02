using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a side");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b side");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c side");
            double c = double.Parse(Console.ReadLine());

            Paralel paralel = new Paralel(a, b, c);

            paralel.VolumeCalc();
            paralel.SurfaceCalc();

            Console.WriteLine($"Volume is {paralel.Volume}");
            Console.WriteLine($"Surface is {paralel.Surface}");

            Console.ReadKey();


        }
    }
}
