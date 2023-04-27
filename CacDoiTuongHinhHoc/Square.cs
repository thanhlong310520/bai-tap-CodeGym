using System;
using System.Collections.Generic;
using System.Text;

namespace CacDoiTuongHinhHoc
{
    class Square:Rectangle
    {
        public Square()
        {

        }
        public Square(double side) : base(side, side)
        {

        }
        public Square(double side, string color, bool filled): base(side, side, color, filled)
        {

        }
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override string ToString()
        {
            return "A Square with side = " + GetSide()+", which is a subclass of "+base.ToString();
        }


    }
}
