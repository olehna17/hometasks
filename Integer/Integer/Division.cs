using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer
{
    class Division
    {
        public int l;
        public int Lenght { get; set; }

        public Division(int L)
        {
            l = L;
        }

        public void LenghtCalculation ()
        {
            Lenght = l / 100;
        }
    
    }
}
