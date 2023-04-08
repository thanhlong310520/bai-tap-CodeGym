using System;

namespace TimMax2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap hang: ");
            int hang = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap cot: ");
            int cot = Convert.ToInt32(Console.ReadLine());
            float[,] arr2 = new float[hang,cot];
            Console.WriteLine("nhap mang: ");
            for(int i = 0; i < hang; i++)
            {
                string[] inp = Console.ReadLine().Split();
                for(int k = 0; k < cot; k++)
                {
                    arr2[i, k] = float.Parse(inp[k]);
                }
            }
            float max = arr2[0,0];
            foreach(float temp in arr2)
            {
                if (max < temp)
                    max = temp;
            }
            Console.WriteLine("phan tu lon nhat trong mang la: "+max);

        }
    }
}
