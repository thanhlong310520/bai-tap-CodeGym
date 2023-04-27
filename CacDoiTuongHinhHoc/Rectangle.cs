using System;
using System.Collections.Generic;
using System.Text;

namespace CacDoiTuongHinhHoc
{
    class Rectangle:Shape
    {
        double width = 1;
        double length = 10;

        public Rectangle()
        {
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width,double length,string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return width;
        }
        public double GetLength()
        {
            return length;
        }
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
        public virtual void SetLength(double length)
        {
            this.length = length;
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length * width);
        }
        public override string ToString()
        {
            return "A rectangle with width = "+GetWidth()+" and length = "+ GetLength()+ ", which is a subclass of "+base.ToString();
        }

    }
}
