using System;

namespace Bai6_DocSoThanhChu
{
    class Program
    {
        static void Main(string[] args)
        {
            string chu = "";
            Console.WriteLine("nhap so");
            string so = Console.ReadLine();
            int vitri = 0;
            int temp = Convert.ToInt32(so);

            while (temp > 19)
            {
                int x = Convert.ToInt32(so[vitri]); // CHUYEN THANH MA ASCII
                x -= 48; // TRU BO BANG CHU CAI TRUOC CAC SO
                
                if(temp >= 100)
                {
                    ChuyenDoi(ref chu,x,so.Length-vitri);
                }
                if (temp < 100 && temp > 19)
                {
                    ChuyenDoiNhoHon100(ref chu, x);
                }
                temp -= x * (int)Math.Pow(10, (so.Length - vitri - 1));

                vitri++;
            }
            if(temp > 0)
            {
                ChuyenDoiNhoHon20(ref chu, temp);
            }
            Console.WriteLine(chu);
        }
        static void ChuyenDoi(ref string chu, int so , int vitri)
        {
            ChuyenDoiNhoHon20(ref chu, so);
            switch (vitri)
            {
                case 4:
                    {
                        chu += " thousand ";
                        break;
                    }
                case 3:
                    {
                        chu += " hundred ";
                        break;
                    }
            }
        }
        static void ChuyenDoiNhoHon100(ref string chu, int so)
        {
            switch (so)
            {
                case 2:
                    {
                        chu += " Twenty ";
                        break;
                    }
                case 3:
                    {
                        chu += " Thirty ";
                        break;
                    }
                case 4:
                    {
                        chu += " Fourty ";
                        break;
                    }
                case 5:
                    {
                        chu += " Fifty ";
                        break;
                    }
                case 6:
                    {
                        chu += " Sixty ";
                        break;
                    }
                case 7:
                    {
                        chu += " Seventy ";
                        break;
                    }
                case 8:
                    {
                        chu += " Eighty ";
                        break;
                    }
                case 9:
                    {
                        chu += " Ninety";
                        break;
                    }
            }
        }
        static void ChuyenDoiNhoHon20(ref string chu, int so)
        {
            switch (so)
            {
                case 0:
                    {
                        chu += "zero";
                        break;
                    }
                case 1:
                    {
                        chu += "One";
                        break;
                    }
                case 2:
                    {
                        chu += "Two";
                        break;
                    }
                case 3:
                    {
                        chu += "Three";
                        break;
                    }
                case 4:
                    {
                        chu += "Four";
                        break;
                    }
                case 5:
                    {
                        chu += "Five";
                        break;
                    }
                case 6:
                    {
                        chu += "Six";
                        break;
                    }
                case 7:
                    {
                        chu += "Seven";
                        break;
                    }
                case 8:
                    {
                        chu += "Eight";
                        break;
                    }
                case 9:
                    {
                        chu += "Nine";
                        break;
                    }
                case 10:
                    {
                        chu += "Ten";
                        break;
                    }
                case 11:
                    {
                        chu += "Eleven";
                        break;
                    }
                case 12:
                    {
                        chu += "Twelve";
                        break;
                    }
                case 13:
                    {
                        chu += "Thirteen";
                        break;
                    }
                case 14:
                    {
                        chu += "Fourteen";
                        break;
                    }
                case 15:
                    {
                        chu += "Fifteen";
                        break;
                    }
                case 16:
                    {
                        chu += "Sixteen";
                        break;
                    }
                case 17:
                    {
                        chu += "Seventeen";
                        break;
                    }
                case 18:
                    {
                        chu += "Eighteen";
                        break;
                    }
                case 19:
                    {
                        chu += "Nineteen";
                        break;
                    }
            }
        }
    }
}
