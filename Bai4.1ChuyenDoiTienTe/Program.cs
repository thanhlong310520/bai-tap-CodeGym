using System;

namespace Bai4._1ChuyenDoiTienTe
{
    class Program
    {
        const int tigia = 23000;
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so tien: ");
            float usd = float.Parse(Console.ReadLine());
            float vnd = usd * tigia;
            Console.WriteLine("chuyen doi: " + vnd);
        }
    }
}
