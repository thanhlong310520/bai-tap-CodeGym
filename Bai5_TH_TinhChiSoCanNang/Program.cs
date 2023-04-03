using System;

namespace Bai5_TH_TinhChiSoCanNang
{
    class Program
    {
        static void Main(string[] args)
        {
            float canNang;
            float chieuCao;
            Console.WriteLine("Please enter a height");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            canNang = float.Parse(Console.ReadLine());

            double bmi = canNang / Math.Pow(chieuCao, 2); // pow hàm mũ
            bmi = Math.Round(bmi, 1); // round hàm làm tròn
            Console.Write("BMI: " + bmi);
            if (bmi < 18)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }
    }
}
