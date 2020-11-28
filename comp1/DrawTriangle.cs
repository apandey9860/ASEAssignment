using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    class DrawTriangle : Shape
    {
        public int hyp;
        public int bse;
        public int adj;
        public DrawTriangle(int x, int y, int z) : base(x, y)
        {
            hyp = x;
            bse = y;
            adj = z;
        }

        public override void draw(Canvass canvass)
        {
            //int x;
            //canvass.g.DrawLine(canvass.pen, canvass.xPos, canvass.yPos, canvass.xPos + bse, canvass.yPos + bse);
            //canvass.g.DrawLine(canvass.pen, canvass.xPos, canvass.yPos, canvass.xPos + adj, canvass.yPos);
            //x = canvass.xPos + adj;
            //canvass.g.DrawLine(canvass.pen,x, canvass.yPos, x, canvass.yPos + hyp);

            Point a = new Point(canvass.xPos, canvass.yPos);
            Point b = new Point(bse, 0);

            double y = (Math.Pow(bse, 2) + Math.Pow(hyp, 2) - Math.Pow(adj, 2)) / (2 * bse);
            double x = Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(y, 2));

            Point c = new Point((int)x, (int)y);
            canvass.g.DrawLine(Pens.Black, a, b);
            canvass.g.DrawLine(Pens.Black, b, c);
            canvass.g.DrawLine(Pens.Black, c, a);

        }
    }
}
