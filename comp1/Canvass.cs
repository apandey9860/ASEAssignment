using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1
{
    /// <summary>
    /// Canvass class holds information that is displayed on the form in response to the Simple Pragramming Language (SPL) commands
    /// </summary>
    public class Canvass
    {


        /// <summary>
        /// Initialization of graphics
        /// </summary>
        public Graphics g;
        /// <summary>
        /// Initialization of class VarStore
        /// </summary>
        public VarStore v;
        /// <summary>
        /// Initialization of class MethodStore
        /// </summary>
        public MethodStore m;

        /// <summary>
        /// Initialization of class SyntaxChecking
        /// </summary>
        public SyntaxChecking syntax;
        /// <summary>
        /// Initialization of Pen
        /// </summary>
        public Pen pen;
        /// <summary>
        /// Initialization of SolidBrush
        /// </summary>
        public SolidBrush brush;
        /// <summary>
        /// Initialization of xPos and yPos
        /// </summary>
        public int xPos, yPos;
        /// <summary>
        /// Initialization of bool fill
        /// </summary>
        public bool fill = false;
        /// <summary>
        /// Initialization of bool err
        /// </summary>
        public bool err = false;

        /// <summary>
        /// Constructor initialized canvas to white pen at 0,0
        /// </summary>
        /// <param name="g">Graphics context of the place to draw on</param>
        public Canvass(Graphics g)
        {
            this.g = g;
            v = new VarStore();
            m = new MethodStore();
            syntax = new SyntaxChecking();
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);//default pen with constants
            brush = new SolidBrush(Color.Black);
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
        /// Set a specific pen and brush colour
        /// </summary>
        /// <param name="c">Colour to set on pen and brush</param>
        public void set_Pen_Color(Color c)
        {
            //Color colour = c.Color;
            pen = new Pen(c, 1);
            brush = new SolidBrush(c);
        }

        /// <summary>
        /// Move from current Pen position(xPos, yPos)
        /// </summary>
        /// <param name="toX">x position to move to</param>
        /// <param name="toY">y position to move to</param>
        public void MoveTo(int toX,int toY)
        {
            xPos = toX;
            yPos = toY;
            //Pointer for user convenience
            g.DrawRectangle(pen, xPos, yPos, 1, 1);
        }

        /// <summary>
        /// Reset and clear the Canvass
        /// </summary>
        public void reset()
        {
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);//default pen with constants
            err = false;
            fill = false;
            v.reset();
            m.reset();
            g.Clear(SystemColors.Control);
            g.DrawRectangle(pen, xPos, yPos, 1, 1);
        }

        /// <summary>
        /// Clear the Canvass without removing the data in variables
        /// </summary>
        public void clear()
        {
            g.Clear(SystemColors.Control);
        }
    }
}
