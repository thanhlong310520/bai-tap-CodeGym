using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IComparer_xo_sanh_cac_lop_hinh_hoc
{
    class Circle
    {
        double radius;
        string color;
        bool filled;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public override string ToString()
        {
            return $"hinh tron co ban kinh {radius}";

        }
    }
}
