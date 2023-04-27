using System;

namespace Diem2Dva3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(1, 2);
            Point3D point3D = new Point3D(2, 1, 5);
            Console.WriteLine(point2D.ToString());
            Console.WriteLine(point3D);
        }
    }
}
