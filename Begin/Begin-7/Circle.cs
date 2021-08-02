using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_7
{
    class Circle
    {
        double r;
        public double Line { get; set; }
        public double Surface { get; set; }

        public Circle(double R)
        {
            r = R;
        }

        public void LineCalc()
        {
            Line = 2 * Math.PI * r;
        }

        public void SurfaceCalc()
        {
            Surface = Math.PI * Math.Pow(r, 2);
        }
    }
}
