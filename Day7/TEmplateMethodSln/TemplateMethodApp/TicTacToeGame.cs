using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodApp
{
    internal class TicTacToeGame : BoardGame
    {
        protected override void ConcludeGame()
        {
            Console.WriteLine("concluding Tictactoe game");
        }

        protected override void InitializeBoard()
        {
            Console.WriteLine("inti Tictactoe game");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine("taking turn Tictactoe");
        }

    }
    
}
