using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_9
{
    class AverGeom
    {
        double a;
        double b;
        public double Square { get; set; }

        public AverGeom (double A, double B)
        {
            a = A;
            b = B;
        }

        public void Calculation()
        {
            Square = Math.Sqrt(a * b);
        }
    }
}
