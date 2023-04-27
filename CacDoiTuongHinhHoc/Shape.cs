using System;
using System.Collections.Generic;
using System.Text;

namespace CacDoiTuongHinhHoc
{
    class Shape
    {
        String color;
        bool filled;
        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public String GetColor()
        {
            return color;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }

        public bool IsFilled()
        {
            return filled;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public override String ToString()
        {
            return "A shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");

        }

    }
}
