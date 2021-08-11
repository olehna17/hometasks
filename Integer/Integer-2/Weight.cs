using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_2
{
    class Weight
    {
        public int m;
        public int W { get; set; }

        public Weight(int M)
        {
            m = M;
        }

        public void WeightCalculation()
        {
            W = m / 1000;
        }

    }
}
