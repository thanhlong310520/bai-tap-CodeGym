﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name)
        : base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }
}
