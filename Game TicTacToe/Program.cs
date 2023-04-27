using System;
using System.Threading;

namespace Game_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Board board = new Board();
            Player player1 = new Player("x");
            Player player2 = new Player("o");
            bool isPlayer1 = true;
            while (true)
            {
                Console.Clear();
                board.PrintBoard();
                if(board.CheckWin() == 2)
                {
                    Console.WriteLine("winner");
                    break;
                }
                else if(board.CheckWin() == 1)
                {
                    Console.WriteLine("hoa");
                    break;
                }
                if (isPlayer1)
                {
                    player1.GetKey();
                    if (player1.isEnter)
                    {
                        isPlayer1 = false;
                        player2.isEnter = false;
                        player1.isEnter = false;
                    }
                }
                else
                {
                    player2.GetKey();
                    if (player2.isEnter)
                    {
                        isPlayer1 = true;
                        player1.isEnter = false;
                        player2.isEnter = false;
                    }
                }
            }
        }
    }
}
