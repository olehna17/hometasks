using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions of your square(rectangle) X(lines count) x Y(columns count)");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());


            //Pryamougolnik s svobodnim viborom razmernosti

            for (int a = 0; a < X; a++)
            {
                for (int b = 0; b < Y; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Pryamougolniy treugolnik
            for (int c = 0; c < 10; c++)
            {
                for (int d = 0; d < c; d++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Ravnostoronniy

            int i, j, k;
            for (i = 1; i <= 10; i += 2)
            {

                for (k = 10; k > i; k -= 2)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            //Uberite comment esli nuzhen romb

            //for (i = 7; i >= 0; i -= 2)
            //{

            //    for (k = 10; k > i; k -= 2)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
        Console.ReadKey();
        }
    }
}
