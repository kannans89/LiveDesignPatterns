using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardStragteyApp
{
    internal interface IBoardGameStrategy
    {

        void InitializeBoard();
        void TakeTurn();
        void ConcludeGame();
        int GetNumberOfTurns();


    }
}
