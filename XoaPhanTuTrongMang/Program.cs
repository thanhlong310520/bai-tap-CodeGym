using System;
using System.Collections.Generic;

namespace XoaPhanTuTrongMang
{
    class Program
    {
        static int val;
        static void Main(string[] args)
        {
            Console.Write("nhap so phan tu mang: ");
            int sptm = int.Parse(Console.ReadLine());
            int[] arr = new int[sptm];
            Nhap(ref arr);
            Console.Write("nhap val: ");
            val = int.Parse(Console.ReadLine());
            int valNum = CountVal(arr) ;
            List<int> list = new List<int>();
            list.AddRange(arr);
            Xoa(list, valNum);
        }
        static void Nhap(ref int[] arr)
        {
            Console.WriteLine("nhap mang");
            string[] inp = Console.ReadLine().Split();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(inp[i]);
            }

        }
        static int CountVal(int[] arr )
        {
            int count = 0;
            foreach(var temp in arr)
            {
                if (temp == val) count++;
            }
            return count;
        }
        static void Xoa(List<int> list, int valNum)
        {
            list.RemoveAll(DieuKien);   
            for(int i = 1; i<= valNum; i++)
            {
                list.Add(0);
            }
            foreach(var x in list)
            {
                Console.Write(x +" ");
            }
        }

        static bool DieuKien(int x)
        {
            return x == val;
        }
        
    }
}
