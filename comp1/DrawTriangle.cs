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

            PointF a = new Point(canvass.xPos, canvass.yPos);
            PointF b = new Point(bse, 0);

            double y = (Math.Pow(bse, 2) + Math.Pow(hyp, 2) - Math.Pow(adj, 2)) / (2 * bse);
            double x = Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(y, 2));

            PointF c = new Point((int)x, (int)y);
            PointF[] pnt = { a, b, c };
            canvass.g.DrawPolygon(canvass.pen, pnt);

        }
    }
}
