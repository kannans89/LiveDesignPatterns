using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodApp
{
    internal abstract class BoardGame
    {

        //Template method
        public void Play()
        {
            InitializeBoard();//PreLoad()
            for (int i = 0; i < GetNumberOfTurns(); i++)
            {
                TakeTurn();  //Load()
            }

            ConcludeGame(); //LoadComplete

        }

        protected abstract void InitializeBoard();
        protected abstract void TakeTurn();//hooks
        protected abstract void ConcludeGame();

        protected virtual int GetNumberOfTurns()
        {
            return 10;
        }
    }
}
