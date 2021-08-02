using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of Coub");
            double a = double.Parse(Console.ReadLine());

            Coub coub = new Coub(a);

            coub.VolumeCalc();
            coub.SurfaceCalc();

            Console.WriteLine($"Volume of cube = {coub.Volume}");
            Console.WriteLine($"Surface of cube = {coub.Surface}");


            Console.ReadKey();
        }
    }
}
