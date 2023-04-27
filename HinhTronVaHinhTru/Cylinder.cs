using System;
using System.Collections.Generic;
using System.Text;

namespace HinhTronVaHinhTru
{
    class Cylinder:Circle
    {
        float height;

        public Cylinder()
        {
        }

        public Cylinder(float height,float radius, string color) : base(radius, color)
        {
            this.height = height;
        }

        public float Height { get => height; set => height = value; }

        public override string ToString()
        {
            return $"hinh tru co chieu cao la height = {height}, co ban kinh la {radius} va co mau la {color} ke thua tu " + base.ToString(); 
        }

    }
}
