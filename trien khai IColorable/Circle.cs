using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IColorable
{
    class Circle:Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }
        public override double Area()
        {
            return radius *radius * 3.14;
        }
        public override string ToString()
        {
            return $"hinh tron co ban kinh la {radius} - va co dien tich la {Area()}";
        }
    }
}
