using BoardStragteyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodApp
{
    internal  class BoardGame
    {

        private IBoardGameStrategy _strategy;

        public BoardGame(IBoardGameStrategy strategy) { 
           _strategy = strategy;
        }

        //Template method
        public void Play()
        {
            _strategy.InitializeBoard();//PreLoad()
            for (int i = 0; i < _strategy.GetNumberOfTurns(); i++)
            {
                _strategy.TakeTurn();  //Load()
            }

            _strategy.ConcludeGame(); //LoadComplete

        }

       
    }
}
