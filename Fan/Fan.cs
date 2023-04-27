using System;
using System.Collections.Generic;
using System.Text;

namespace Fan
{
    class Fan
    {
        int speed = (int)SPEED.SLOW;
        bool sttOn = false;
        double radius = 5;
        string color = "blue";

        public int Speed { get => speed; set => speed = value; }
        public bool SttOn { get => sttOn; set => sttOn = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            if (sttOn)
            {
                return "speed = " + CheckSpeed() + ", color " + color + ", radius " + radius + ", fan is on";
            }
            else
            {
                return "color " + color + ", radius " + radius + ", fan is off"; 
            }
        }
        SPEED CheckSpeed()
        {
            
            if(speed == (int)SPEED.SLOW)
            {
                return SPEED.SLOW;
            }
            else if(speed == (int)SPEED.MEDIUM)
            {
                return SPEED.MEDIUM;
            }
            else if(speed == (int)SPEED.FAST)
            {
                return SPEED.FAST;
            }
            return SPEED.SLOW;
            
        }
    }
    public enum SPEED
    {
        SLOW = 1,MEDIUM,FAST
    }
}
