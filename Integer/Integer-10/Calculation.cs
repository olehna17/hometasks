using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_10
{
    class Calculation
    {
        public int a;

        public int LenghtCalc { get; set; }
        public int RestCalc { get; set; }

        public Calculation(int A)
        {
            a = A;
        }

        public void LenghtCalculation()
        {
            LenghtCalc = a / 10;
            RestCalc = a % 10;
        }
    }
}
