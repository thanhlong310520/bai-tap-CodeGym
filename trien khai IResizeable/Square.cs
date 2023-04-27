using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IResizeable
{
    class Square:Shape
    {
        double size;

        public Square(double size)
        {
            this.Size = size;
        }

        public double Size { get => size; set => size = value; }

        public override void Resize(double percent)
        {
            size = size * percent;
        }

        public override string ToString()
        {
            return $"hinh vuong co size la {size} ";
        }
    }
}
