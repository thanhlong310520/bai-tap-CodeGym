using System;

namespace DemSoLanXuatHien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap chuoi: ");
            string str = Console.ReadLine();
            char kitu = (char)Console.Read();
            Console.WriteLine($"So luong ki tu '{kitu}' co trong chuoi la: "+CountCharNumber(str,kitu));
        }

        static int CountCharNumber(string str,char c)
        {
            int count = 0;
            foreach(char temp in str)
            {
                if(c == temp) count++;
            }
            return count;
        }
    }
}
