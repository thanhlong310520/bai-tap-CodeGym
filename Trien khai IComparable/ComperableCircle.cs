using System;
using System.Collections.Generic;
using System.Text;

namespace Trien_khai_IComparable
{
    class ComperableCircle : Circle,IComparable
    {
        public ComperableCircle(double radius) : base(radius)
        {
        }

        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled)
        {
        }

        public int CompareTo(object obj)
        {
            ComperableCircle o = obj as ComperableCircle;
            if (this.Radius > o.Radius)
            {
                return 1;
            }
            else if(this.Radius < o.Radius)
            {
                return -1;
            }
            return 1;
        }
    }
}
