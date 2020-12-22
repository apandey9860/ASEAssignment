using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    class DrawPolygon : Shape
    {
        PointF[] points;
        /// <summary>
        /// Set coordinates of polygon
        /// </summary>
        /// <param name="x">Coordinate of Polygon</param>
        public DrawPolygon(int[] x) : base(x[0], x[1])
        {
            int i = 0;
            PointF[] p = new PointF[x.Length];
            while (x.Length > i)
            {
                if ((i + 1) == x.Length)
                {
                    p[i] = new PointF(x[i], x[0]);
                }
                else
                {
                    p[i] = new PointF(x[i], x[i + 1]);
                }
                i++;
            }
            points = p;
        }
        /// <summary>
        /// Draw a polygon according to user defined coordinates
        /// </summary>
        /// <param name="canvass">Canvass in which the polygon is drawn</param>
        public override void draw(Canvass canvass)
        {
            canvass.g.DrawPolygon(canvass.pen, points);//Draw a polygon
            if (canvass.fill)
            {
                canvass.g.FillPolygon(canvass.brush, points);//Draws a filled polygon if fill is true
            }
        }
    }
}
