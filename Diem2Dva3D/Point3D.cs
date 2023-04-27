using System;
using System.Collections.Generic;
using System.Text;

namespace Diem2Dva3D
{
    class Point3D:Point2D
    {
        float z = 0f;
        public Point3D() { }
        public Point3D(float x ,float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float[] GetXYZ()
        {
            float[] arr = new float[] { x, y, z };
            return arr;
        }
        public override string ToString()
        {
            return $"diem 3D co toa do la ({x},{y},{z}) duoc ke thua tu "+ base.ToString();
        }

    }
}
