using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IColorable
{
    class Square:Shape,IColorable
    {
        double size;

        public Square(double size)
        {
            this.Size = size;
        }

        public double Size { get => size; set => size = value; }

        public string HowToColor()
        {
            return "Color all four side.........";
        }

        public override double Area()
        {
            return size * size;
        }
        public override string ToString()
        {
            return $"hinh vuong co size la {size} - va co dien tich la {Area()}";
        }
    }
}
