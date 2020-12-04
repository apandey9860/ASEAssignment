using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    /// <summary>
    /// Class which inherits shape and draws a triangle
    /// </summary>
    class DrawTriangle : Shape
    {
        public int hyp;
        public int bse;
        public int adj;

        /// <summary>
        /// Set the hypotenuse, base and adjactent of the triangle
        /// </summary>
        /// <param name="x">Hypotenuse of the triangle</param>
        /// <param name="y">Base of the triangle</param>
        /// <param name="z">Adjacent of the triangle</param>
        public DrawTriangle(int x, int y, int z) : base(x, y)
        {
            hyp = x;
            bse = y;
            adj = z;
        }

        /// <summary>
        /// Draws a triangle according to given hypotenuse, base and adjactent
        /// </summary>
        /// <param name="canvass">Canvass in which the triangle is drawn</param>
        public override void draw(Canvass canvass)
        {
            PointF a = new Point(canvass.xPos, canvass.yPos);
            PointF b = new Point(canvass.xPos, canvass.yPos + bse);
            PointF c = new PointF(canvass.xPos + adj, canvass.yPos + hyp);
            PointF[] pnt = { a, b, c };
            canvass.g.DrawPolygon(canvass.pen, pnt);//Draws a triangle
            if (canvass.fill)
            {
                canvass.g.FillPolygon(canvass.brush, pnt);//Draws a filled triangle if fill is true
            }
        }
    }
}
