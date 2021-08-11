using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_5
{
    class Rest
    {
        public int a;
        public int b;

        public int LenghtCalc { get; set; }

        public Rest(int A, int B)
        {
            a = A;
            b = B;
        }

        public void RestCalculation()
        {
            LenghtCalc = a % b;
        }
    }
}
