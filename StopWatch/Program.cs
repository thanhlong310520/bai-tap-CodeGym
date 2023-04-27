
using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            RandomForArray(ref arr);
            StopWatch sp = new StopWatch();
            sp.Start();
            SelectionSort(arr);
            sp.Stop();
            TimeSpan ts =  sp.GetElapsedTime();
            Console.WriteLine("time span " + ts.Milliseconds);

        }
        static void SelectionSort(int[]arr)
        {
            int temp, smallest;
            for(int i = 0; i< arr.Length; i++)
            {
                smallest = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                        smallest = j;
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
        static void RandomForArray(ref int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(10000);
            }
        }
    }
}
