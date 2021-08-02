using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_6
{
    class Paralel
    {
        double a;
        double b;
        double c;
       public double Volume { get; set; }
       public double Surface { get; set; }

        public Paralel(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public void VolumeCalc()
        {
            Volume = a * b * c;
        }

        public void SurfaceCalc()
        {
            Surface = 2*(a*b + b*c + a*c);
        }
    }
}
