using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    /// <summary>
    /// Class which inherits shape and draws a square or rectangle
    /// </summary>
    class DrawSquare : Shape
    {
        public int height;
        public int width;

        /// <summary>
        /// Set width and height of the square/rectangle
        /// </summary>
        /// <param name="x">Width of square/rectangle</param>
        /// <param name="y">Height of square/rectangle</param>
        public DrawSquare(int x, int y) : base( x,  y)
        {
            height = y;
            width = x;
        }
        /// <summary>
        /// Draw a square/rectangle according to set height and width
        /// </summary>
        /// <param name="canvass">Canvass in which the square/rectangle is drawn</param>
        public override void draw(Canvass canvass)
        {
            canvass.g.DrawRectangle(canvass.pen, canvass.xPos, canvass.yPos, width, height);
            if (canvass.fill)
            {
                canvass.g.FillRectangle(canvass.brush, canvass.xPos, canvass.yPos, width, height);
            }
        }
    }
}
