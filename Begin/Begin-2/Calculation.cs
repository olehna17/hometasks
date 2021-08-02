using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_2
{
    class Calculation
    {
        public double Side1;

        public double Area { get; set; }

        public Calculation(double side1)
        {
            Side1 = side1;
        }

        public void AreaCalc()
        {
            Area = Math.Pow(Side1, 2);
        }
    }
}
