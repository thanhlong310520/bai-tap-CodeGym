using System;
using System.Collections.Generic;
using System.Text;

namespace HinhChuNhat
{
    class Rectangle
    {
        double width;
        double height;
        public Rectangle()
        {

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }
}
