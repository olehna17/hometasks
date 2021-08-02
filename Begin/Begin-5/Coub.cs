using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_5
{
    class Coub
    {
        double a;

        public double Volume { get; set; }
        public double Surface { get; set; }

        public Coub(double A)
        {
            a = A;
        }

        public void VolumeCalc()
        {
            Volume = Math.Pow(a, 3);
        }

        public void SurfaceCalc()
        {
            Surface = 6*(Math.Pow(a, 2));
        }
    }
}
