using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardStragteyApp
{
    internal class TicTacToeGame : IBoardGameStrategy
    {
        public void ConcludeGame()
        {
            Console.WriteLine("concluding Tictactoe game");
        }

        public int GetNumberOfTurns()
        {
            return 10;
        }

        public void InitializeBoard()
        {
            Console.WriteLine("inti Tictactoe game");
        }

        public void TakeTurn()
        {
            Console.WriteLine("taking turn Tictactoe");
        }

    }

}
