using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan f1 = new Fan();
            f1.Speed = (int)SPEED.FAST;
            f1.Radius = 10;
            f1.Color = "yellow";
            f1.SttOn = true;
            Console.WriteLine("quat thu 2 la : " + f1.ToString());
            Fan f2 = new Fan();
            f2.Speed = (int)SPEED.MEDIUM;
            f2.Radius = 5;
            f2.SttOn = false;
            Console.WriteLine("quat thu 2 la : " + f2.ToString());
        }
    }
}
