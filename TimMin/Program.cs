using System;

namespace TimMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int index = FindPosMin(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);

        }
        static int FindPosMin(int[] arr)
        {
            int min = arr[0];
            int index = 0;
            for(int i = 0; i<arr.Length;i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
