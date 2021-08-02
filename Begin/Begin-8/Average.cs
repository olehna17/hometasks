using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_8
{
    class Average
    {
        double a;
        double b;

        public double AverageVal { get; set; }

        public Average (double A, double B)
        {
            a = A;
            b = B;
        }

        public void AverageCalculation()
        {
            AverageVal = (a + b) / 2;
        }

    }
}
