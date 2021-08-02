using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Train : IComparable
    {
        public string ArrivalPoint;
        public int TrainNumb;
        public double ArrivalTime;
        public int CompareTo(object obj)
        {
            return TrainNumb.CompareTo(((Train)obj).TrainNumb);
        }
    }
}
