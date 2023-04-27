using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IColorable
{
    class Rectangle:Shape 
    {
        double width;
        double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public override double Area()
        {
            return width * height;
        }
        public override string ToString()
        {
            return $"hinh chu nhat co chieu cao la {height} - chieu rong la {width} - va co dien tich la {Area()} ";
        }

    }
}
