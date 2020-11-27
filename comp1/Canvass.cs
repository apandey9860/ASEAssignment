using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    /// <summary>
    /// Canvass class holds information that is displayed on the form in response to the Simple Pragramming Language (SPL) commands
    /// </summary>
    class Canvass
    {
        //Instance data for x,y pos, pen and graphic context
        Graphics g;
        Pen pen;
        int xPos, yPos;


        /// <summary>
        /// Constructor initialized canvas to white pen at 0,0
        /// </summary>
        /// <param name="g">Graphics context of the place to draw on</param>
        public Canvass(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);//default pen with constants
        }
        /// <summary>
        /// Draw a line from current Pen position(xPos, yPos)
        /// </summary>
        /// <param name="toX">x position to draw to</param>
        /// <param name="toY">y position to draw to</param>
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(pen, xPos, yPos, toX, toY);//drawing line
            xPos = toX;
            yPos = toY; //pen position is moved to the end of the line
        }

        /// <summary>
        /// Draw a square from current Pen position(xPos, yPos)
        /// </summary>
        /// <param name="width">Width/Height of the square</param>
        public void DrawSquare(int width)
        {
            g.DrawRectangle(pen, xPos, yPos, xPos+width, yPos+width);
        }
    }
}
