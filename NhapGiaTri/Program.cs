using System;

namespace NhapGiaTri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so  phan tu mang: ");
            int sptm = Convert.ToInt32(Console.ReadLine());
            int x;
            int[] arr = new int[sptm];
            do
            {
                Console.Write("nhap vi tri(lon hon 0 va nho hon size): ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 0 || x > sptm - 1);
            Console.Write("nhap Gia tri: ");
            int val = Convert.ToInt32(Console.ReadLine());
            arr[x] = val;
            foreach(var temp in arr)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
