using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }

        public override void SetHeight(int pheight)
        {
            _width=_height=pheight;
        }

        public override void SetWidth(int pheight)
        {
            _width = _height = pheight;
        }
    }
}
