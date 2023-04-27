using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TicTacToe
{
    class Player
    {
        string value;
        public bool isEnter = false; 
        public Player(string value)
        {
            this.value = value;
                 
        }
        public string GetValue()
        {
            return value;
        }
        public void GetKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                Board.currentColumn++;
                Board.CheckColumn();
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                Board.currentColumn--;
                Board.CheckColumn();
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Board.currentRow--;
                Board.CheckRow();
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Board.currentRow++;
                Board.CheckRow();
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                Board.SetBoard(value);
                isEnter = true;
            }
        }
    }
}
