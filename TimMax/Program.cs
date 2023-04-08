using System;

namespace TimMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so phan tu mang: ");
            int sptm = int.Parse(Console.ReadLine());
            int[] arr = new int[sptm];

            Console.WriteLine("nhap mang");
            string[] inp = Console.ReadLine().Split();
            for(int i = 0; i < sptm; i++)
            {
                arr[i] = Convert.ToInt32(inp[i]);
            }
            int max = arr[0];
            foreach(var temp in arr)
            {
                if (max < temp)
                    max = temp;
            }
            Console.WriteLine($"phan tu lon nhat trong mang la : {max}");
        }
    }
}
