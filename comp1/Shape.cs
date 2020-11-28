using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    abstract class Shape
    {
        int height;
        int width;

        public Shape(int x, int y)
        {
            height = x;
            width = y;
        }
        public abstract void draw(Canvass canvass);
    }
}
