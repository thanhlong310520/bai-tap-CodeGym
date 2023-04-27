using System;

namespace HinhTronVaHinhTru
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(12, "yellow");
            Console.WriteLine(circle.ToString());
            Cylinder cylinder = new Cylinder(23, 11, "red");
            Console.WriteLine(cylinder.ToString());
        }
    }
}
