using System;

namespace Sum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap hang: ");
            int hang = Convert.ToInt32(Console.ReadLine());
            float[,] arr2 = new float[hang, hang];
            Console.WriteLine("nhap mang: ");
            for (int i = 0; i < hang; i++)
            {
                string[] inp = Console.ReadLine().Split();
                for (int k = 0; k < hang; k++)
                {
                    arr2[i, k] = float.Parse(inp[k]);
                }
            }
            float tong = 0;
            for (int i = 0; i < hang; i++)
            {
                tong += arr2[i, i];
            }
            Console.WriteLine("tong duong cheo chinh = " + tong);
        }
    }
}
