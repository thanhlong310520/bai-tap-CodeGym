using System;
using System.Collections.Generic;
using System.Text;

namespace CacDoiTuongHinhHoc
{
    class Circle:Shape
    {
        double radius = 1;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public override string ToString()
        {
            return "A Circle with radius = "+ GetRadius()+", which is a subclass of "+ base.ToString();
        }
    }
}
