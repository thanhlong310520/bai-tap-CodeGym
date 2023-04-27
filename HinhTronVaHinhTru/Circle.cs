using System;
using System.Collections.Generic;
using System.Text;

namespace HinhTronVaHinhTru
{
    class Circle
    {
        protected float radius;
        protected string color;

        public Circle() { }
        public Circle(float radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public float Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return $"hinh tron co ban kinh = {radius} va co mau la {color}";
        }
    }
}
