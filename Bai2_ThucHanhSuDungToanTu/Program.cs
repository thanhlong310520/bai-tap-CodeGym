using System;

namespace Bai2_ThucHanhSuDungToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Width is: " + width);
            Console.WriteLine("Height is: " + height);
            Console.WriteLine("Area is: " + area);
        }
    }
}
