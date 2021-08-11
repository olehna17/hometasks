using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_4
{
    class Calculation
    {
        public int a;
        public int b;

        public int LenghtCalc { get; set; }

        public Calculation(int A, int B)
        {
            a = A;
            b = B;
        }

        public void LenghtCalculation ()
        {
            LenghtCalc = a / b;
        }

    }
}
