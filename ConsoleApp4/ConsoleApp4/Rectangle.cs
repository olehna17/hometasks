using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

     public class Rectangle
    {
        double Side1;
        double Side2;
        public double Area { get => _area; }
        public double Perim { get; private set; }
        private double _area { get; set; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public void AreaCalc()
        {
            _area = Side1 * Side2;
            
        }
        public void PerimCalc()
        {
            Perim = (Side1 + Side2)*2;
        }


    }
}
