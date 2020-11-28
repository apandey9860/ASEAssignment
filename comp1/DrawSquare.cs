using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    class DrawSquare : Shape
    {
        public int height;
        public int width;
        public DrawSquare(int x, int y) : base( x,  y)
        {
            height = x;
            width = y;
        }

        public override void draw(Canvass canvass)
        {
            canvass.g.DrawRectangle(canvass.pen, canvass.xPos, canvass.yPos, width, height);
        }
    }
}
