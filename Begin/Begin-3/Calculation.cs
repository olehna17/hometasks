using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_3
{
    class Calculation
    {
        public double Side1;
        private double Side2;

        public double Perim { get; set; }
        public double Area { get; set; }

        public Calculation(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public void AreaCalc()
        {
            Area = Side1 * Side2;
        }

        public void PerimetrCalc()
        {
            Perim = 2 * (Side1 + Side2);
        }
    }
}
