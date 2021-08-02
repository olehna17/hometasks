using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_4
{
    class Calculate
    {
        double d;
        public double Long { get; set; }

       public Calculate(double D)
        {
            d = D;
        }

        public void LongCalc()
        {
            Long = Math.PI * d;
        }
        
    }
}
