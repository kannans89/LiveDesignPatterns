using BoardStragteyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodApp
{
    internal class ChessGame : IBoardGameStrategy
    {
        public  void ConcludeGame()
        {
            Console.WriteLine("concluding chess game");
        }

        public void  InitializeBoard()
        {
            Console.WriteLine("inti chess game");
        }

        public void TakeTurn()
        {
            Console.WriteLine("taking turn chess game");
        }

        public int GetNumberOfTurns()
        {
            return 5;
        }
    }
}
