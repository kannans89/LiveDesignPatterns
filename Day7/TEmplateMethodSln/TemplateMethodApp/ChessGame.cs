using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodApp
{
    internal class ChessGame : BoardGame
    {
        protected override void ConcludeGame()
        {
            Console.WriteLine("concluding chess game");
        }

        protected override void InitializeBoard()
        {
            Console.WriteLine("inti chess game");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine("taking turn chess game");
        }

        protected override int GetNumberOfTurns()
        {
            return 5;
        }
    }
}
