using System;
using System.Collections.Generic;
using System.Text;

namespace Diem2Dva3D
{
    class Point2D
    {
        protected float x = 0f;
        protected float y = 0f;
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetX(float x)
        {
            this.x = x;    
        }
        public void SetY(float y)
        {
            this.y = y;
        }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            float[] arr = new float[] { x, y };
            return arr;
        }
        public override string ToString()
        {
            return $"diem 2D co toa do la ({x},{y})";
        }
    }
}
