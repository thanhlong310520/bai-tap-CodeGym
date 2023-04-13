using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static ConsoleKey key;
        static List<int> lhang,lcot;
        static int dodai = 4;
        static int hatCot, hatHang;
        static int tempC;
        static int tempH;
        static bool dead = false;
        static void Main(string[] args)
        {
            lhang = new List<int>();
            lcot = new List<int>();
            dead = false;
            for(int i = 0; i< dodai; i++)
            {
                lhang.Add(6-i);
                lcot.Add(6);
            }
            DoiMau();
            VeKhung(100,20);
            SinhHat();
            key = ConsoleKey.RightArrow;
            Thread t = new Thread(()=> { Inp(); });
            t.Start();
            Thread tt = new Thread(() => { DiChuyen(); });
            tt.Start();

        }

        
        static void DoiMau()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }
        static void VeKhung(int hang, int cot)
        {
            for (int i = 1; i <= hang; i++)
            {
                if(i == 1 || i == hang)
                {
                    for (int j = 1; j<= cot; j++)
                    {
                        
                        Console.SetCursorPosition(i, j); // tro lai vi tri
                        Console.Write("*"); // thay chu H == " "
                    }
                }
                Console.SetCursorPosition(i, 1); // tro lai vi tri
                Console.Write("*");
                Console.SetCursorPosition(i, cot); // tro lai vi tri
                Console.Write("*"); 
            }
        }
        static void VeRan(int x, int y,string content)
        {
            tempC = lcot[lcot.Count - 1];
            tempH = lhang[lhang.Count - 1];
            for(int j = dodai -1; j > 0; j--)
            {
                lcot[j] = lcot[j - 1];
                lhang[j] = lhang[j - 1];
            }
            lhang[0] = x;
            lcot[0] = y;
            Console.SetCursorPosition(tempH, tempC);
            Console.Write(" ");
            for (int i = 0; i< dodai; i++)
            {
                Console.SetCursorPosition(lhang[i], lcot[i]);
                Console.Write(content);
            }

        }
        static void DiChuyen()
        {
            int hang = 6;
            int cot = 6;

            while (!dead)
            {
                Thread.Sleep(200);
                switch (key)
                {

                    case (ConsoleKey.UpArrow):
                        {
                            
                            cot--;
                            break;
                        }
                    case (ConsoleKey.DownArrow):
                        {
                            
                            cot++;
                            break;
                        }
                    case (ConsoleKey.LeftArrow):
                        {
                           
                            hang--;
                            break;
                        }
                    case (ConsoleKey.RightArrow):
                        {
                          
                            hang++;
                            break;
                        }
                    case (ConsoleKey.Escape):
                        {
                            
                            Environment.Exit(0);
                            break;
                        }
                }

                VeRan(hang, cot, "o");
                if(hang == hatHang && cot == hatCot)
                {
                    Console.SetCursorPosition(tempH, tempC);
                    Console.Write("o");
                    lcot.Add(tempC);
                    lhang.Add(tempH);
                    dodai++;
                    SinhHat();
                }
                CheckDead(hang, cot);

            }
        }
        static void Inp()
        {
            ConsoleKey temp = key;
            while (true)
            {
                key = Console.ReadKey().Key;
                if( (temp == ConsoleKey.UpArrow && key == ConsoleKey.DownArrow)|| 
                    (temp == ConsoleKey.DownArrow && key == ConsoleKey.UpArrow)||
                    (temp == ConsoleKey.LeftArrow && key == ConsoleKey.RightArrow)||
                    (temp == ConsoleKey.RightArrow && key == ConsoleKey.LeftArrow))
                {
                    key = temp;
                }
                
                temp = key;
            }
            
        }
        static void SinhHat()
        {
            hatCot = new Random().Next(2, 19);
            hatHang = new Random().Next(2, 99);
            while (Check(hatCot, hatHang))
            {
                hatCot = new Random().Next(2, 19);
                hatHang = new Random().Next(2, 99);
            }

            Console.SetCursorPosition(hatHang, hatCot);
            Console.Write("O");
        }
        static bool Check(int cot,int hang)
        {
            for(int i = 0; i < dodai; i++)
            {
                if (cot == lcot[i] && hang == lhang[i])
                    return true;
            }
            return false;
        }
        static void CheckDead(int hang, int cot)
        {
            if (hang == 1 || hang == 100 || cot == 1 || cot == 20)
            {
                dead = true;
            }

                
            for(int i = 1; i< dodai; i++)
            {
                if (hang == lhang[i] && cot == lcot[i])
                {
                    dead = true;
                    Console.WriteLine(true);
                }
            }
        }
    }
}
