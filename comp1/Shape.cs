using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    /// <summary>
    /// Abstract class for other classes to inherit
    /// </summary>
    abstract class Shape
    {
        int height;
        int width;

        /// <summary>
        /// Set height and width of the shape
        /// </summary>
        /// <param name="x">Width of shape</param>
        /// <param name="y">Height of shape</param>
        public Shape(int x, int y)
        {
            height = y;
            width = x;
        }

        /// <summary>
        /// abstract method for drawing shapes in inheriting classes
        /// </summary>
        /// <param name="canvass">Canvass in which the specifies shape is drawn</param>
        public abstract void draw(Canvass canvass);
    }
}
