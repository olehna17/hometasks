using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Array
{
    class Class1
    {
       
        public int[] array1 { get; set; }


        public Class1 (int N)
        {
            array1 = new int[N];
            Random rand = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(100);
            }
        }
        public void Print()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
        }

       
        public int Max()
        {
            int max=0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            }
            return max;
            
        }

        public int Min()
        {
            int min = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < min)
                {
                    min = array1[i];
                }
            }
            return min;

        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = array1[i] + sum;
            }
            return sum;
        }

        public double Arifm()
        {
            double arifm = Sum() / array1.Length;

            return arifm;
        }

        public void Num()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0)
                {
                    Console.Write($"{array1[i]} ");
                }
            }
            Console.WriteLine();
        }

    }
}
