using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_10
{
    class Operations
    {
        double a;
        double b; 

        public double SumOper { get; set; }
        public double DifferenceOper { get; set; }
        public double MultiplyOper { get; set; }
        public double DivOper { get; set; }

        public Operations(double A, double B)
        {
            a = A;
            b = B;
        }

        public void Calculation()
        {
            SumOper = Math.Pow(a, 2) + Math.Pow(b, 2);
            DifferenceOper = Math.Pow(a, 2) - Math.Pow(b, 2);
            MultiplyOper = Math.Pow(a, 2) * Math.Pow(b, 2);
            DivOper = Math.Pow(a, 2) / Math.Pow(b, 2);
        }


    }
}
