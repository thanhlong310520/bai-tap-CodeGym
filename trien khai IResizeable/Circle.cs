using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IResizeable
{
    class Circle:Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override void Resize(double percent)
        {
            radius = radius * percent;
        }
        public override string ToString()
        {
            return $"hinh tron co ban kinh la {radius} ";
        }
    }
}
