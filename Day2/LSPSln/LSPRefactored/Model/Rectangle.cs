using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPRefactored.Model
{
    public class Rectangle:IPolygon
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        public virtual void SetWidth(int pwidth)//can be overriden
        {
            _width = pwidth;
        }

        public virtual void SetHeight(int pheight)
        {
            _height = pheight;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWidth()
        {
            return _width;
        }
    }
}
