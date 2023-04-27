using System;
using System.IO;

namespace tong_cac_so_trong_file_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\CodeGym\bai tap CodeGym\File\tong cac so trong file text\tong cac so trong file text\bin\Debug\netcoreapp3.1\text.txt";
            Console.WriteLine("Please input file path");
            string path = Console.ReadLine();
            try
            {
                FileStream file = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);
                int sum = 0;
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                reader.Close();
                Console.WriteLine("Sum = " + sum);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
