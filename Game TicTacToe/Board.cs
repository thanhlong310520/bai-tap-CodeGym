using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TicTacToe
{
    class Board
    {
        public static string[,] listBoard = new string[3, 3]
        {
            { "-","-","-" },
            { "-","-","-" },
            { "-","-","-" },
        };

        public static int currentRow = 0;
        public static int currentColumn = 0;

        public void PrintBoard()
        {
            for(int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(20, 5+i);
                for (int j = 0; j < 3; j++)
                {
                    if (i == currentRow && j == currentColumn)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(listBoard[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(listBoard[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void CheckColumn()
        {
            if(currentColumn < 0)
            {
                currentColumn = 2;
            }
            if(currentColumn > 2)
            {
                currentColumn = 0;
            }
        }
        public static void CheckRow()
        {
            if (currentRow < 0)
            {
                currentRow = 2;
            }
            if (currentRow > 2)
            {
                currentRow = 0;
            }
        }
        public static void SetBoard(string val)
        {
            listBoard[currentRow, currentColumn] = val;
        }
        public int CheckWin()
        {
            // 2 la win, // 1 la hoa
            int temp = 0;
            if((listBoard[0, 0] == listBoard[0, 1] && listBoard[0, 1] == listBoard[0, 2] && listBoard[0, 0]!= "-") ||
               (listBoard[1, 0] == listBoard[0, 1] && listBoard[1, 1] == listBoard[1, 2] && listBoard[1, 0] != "-")||
               (listBoard[2, 0] == listBoard[2, 1] && listBoard[2, 1] == listBoard[2, 2] && listBoard[2, 0] != "-")||
               (listBoard[0, 0] == listBoard[1, 0] && listBoard[1, 0] == listBoard[2, 0] && listBoard[0, 0] != "-") ||
               (listBoard[0, 1] == listBoard[1, 1] && listBoard[1, 1] == listBoard[2, 1] && listBoard[0, 1] != "-") ||
               (listBoard[0, 2] == listBoard[1, 2] && listBoard[1, 2] == listBoard[2, 2] && listBoard[0, 2] != "-") ||
               (listBoard[0, 0] == listBoard[1, 1] && listBoard[1, 1] == listBoard[2, 2] && listBoard[0, 0] != "-") ||
               (listBoard[2, 0] == listBoard[1, 1] && listBoard[1, 1] == listBoard[0, 2] && listBoard[2, 0] != "-")
               )
            {
                temp = 2;
            }
            

            if (temp != 2 && RemainingStep() == 0)
                temp = 1;
            return temp;

        }
        int RemainingStep()
        {
            int steps = 0;
            foreach(string temp in listBoard)
            {
                if (temp == "-")
                    steps++;
            }
            return steps;
        }

    }
}
