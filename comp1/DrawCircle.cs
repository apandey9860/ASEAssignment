using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    /// <summary>
    /// Class which inherits shape and draws a circle
    /// </summary>
    class DrawCircle : Shape
    {
        public int radius;

        /// <summary>
        /// Set the radius of the circle
        /// </summary>
        /// <param name="r">Radius of the triangle</param>
        public DrawCircle(int r) : base(r, 0)
        {
            radius = r;
        }

        /// <summary>
        /// Draws a circle according to given radius
        /// </summary>
        /// <param name="canvass">Canvass in which the triangle is drawn</param>
        public override void draw(Canvass canvass)
        {
            canvass.g.DrawEllipse(canvass.pen, canvass.xPos, canvass.yPos, (radius * 2), (radius * 2));
            if (canvass.fill)
            {
                canvass.g.FillEllipse(canvass.brush, canvass.xPos, canvass.yPos, (radius * 2), (radius * 2));
            }
        }
    }
}
