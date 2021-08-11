using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_3
{
    class Byte
    {
        public int b;
        public int Kylo { get; set; }

        public Byte(int B)
        {
            b = B;
        }

        public void ByteToKyloCalculation()
        {
            Kylo = b / 1024;
        }
    }
}
