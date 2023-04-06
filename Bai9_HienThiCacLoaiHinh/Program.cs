using System;

namespace Bai9_HienThiCacLoaiHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the triangle");
                Console.WriteLine("3. Draw isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Rectangle();
                            break;
                        }
                    case 2:
                        {
                            Triangle();
                            break;
                        }
                    case 3:
                        {
                            IsoscelesTriangle();
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("again");
                            break;

                        }
                }

                Console.WriteLine("====================================================================================================");
            } while (choice != 4);
        }

        static void Rectangle()
        {
            Console.WriteLine("nhap chieu dai: ");
            int chieudai = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap chieu rong: ");
            int chieurong = int.Parse(Console.ReadLine());
            for(int i = 1; i <= chieurong; i++)
            {
                for(int j= 1; j <= chieudai; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Triangle()
        {
            Console.WriteLine("nhap goc vuong: ");
            Console.WriteLine("1. Top-Left");
            Console.WriteLine("2. Top-Right");
            Console.WriteLine("3. Bot-Left");
            Console.WriteLine("4. Bot-Right");
            Console.WriteLine("0. Back");
            int luachon = int.Parse(Console.ReadLine());
            Console.Write("nhap do dai canh: ");
            int dodai = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    {
                        TopLeft(dodai);
                        break;
                    }
                case 2:
                    {
                        TopRight(dodai);
                        break;
                    }
                case 3:
                    {
                        BotLeft(dodai);
                        break;
                    }
                case 4:
                    {
                        BotRight(dodai);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            
        }
        static void IsoscelesTriangle()
        {
            Console.Write("nhap do dai canh(do dai canh le): ");
            int dodai = int.Parse(Console.ReadLine());
            while(dodai%2 == 0)
            {
                Console.Write("again: ");
                dodai = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dodai; i++)
            {
                for (int j = 0; j <= dodai+i; j++)
                {
                    if(j<(dodai - i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        static void TopLeft(int dodai)
        {
            for(int i = 0; i < dodai; i++)
            {
                for (int j = 0; j < dodai - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void TopRight(int dodai)
        {
            for (int i = 0; i < dodai; i++)
            {
                for (int j = 0; j < dodai; j++)
                {
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        static void BotLeft(int dodai)
        {
            for (int i = 0; i < dodai; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void BotRight(int dodai)
        {
            for (int i = 0; i < dodai; i++)
            {
                for (int j = dodai-1; j >= 0; j--)
                {
                    if (j <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
