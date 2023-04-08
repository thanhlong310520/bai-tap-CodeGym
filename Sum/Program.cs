using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so  phan tu mang: ");
            int sptm = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sptm];
            Console.Write("nhap mang: ");
            string[] inp = Console.ReadLine().Split();
            
            for (int i = 0; i < sptm; i++)
            {
                arr[i] = Convert.ToInt32(inp[i]);
            }
            int tong = 0;
            foreach(var num in arr)
            {
                tong += num;
            }
            Console.WriteLine("tong: " + tong);
        }
    }
}
