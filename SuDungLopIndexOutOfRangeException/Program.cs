﻿using System;
using System.Collections.Generic;

namespace SuDungLopIndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd' });
                int value = characters[6];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
