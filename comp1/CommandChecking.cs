using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    /// <summary>
    /// Class which chekcs user inputted commands for errors or exceptions
    /// </summary>
    class SyntaxChecking
    {
        /// <summary>
        /// Displays error when entered command does not exist
        /// </summary>
        /// <param name="MyCanvass">Canvass on which error message is displayed</param>
        /// <param name="n">For the line number of the command</param>
        /// <param name="x">For the location in the canvass where error message is dispalyed</param>
        public void CommandChecking(Canvass MyCanvass, int n, int x)
        {
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            n++;
            if (n != 0)
            {
                if (x==0)
                {
                    MyCanvass.reset();
                }
                MyCanvass.g.DrawString("Command on line " + (n) + " does not exist", drawFont, drawBrush, 0, 0 + x);
            }
            else
            {
                MyCanvass.g.DrawString("Command does not exist", drawFont, drawBrush, 0, 0);
            }
            MyCanvass.err = true;
        }

        /// <summary>
        /// Displays error when enetered parameters are not valid in the context
        /// </summary>
        /// <param name="par">Boolean value which recives value according to validity of parameters</param>
        /// <param name="data">String where the invalid parameter is found</param>
        /// <param name="n">For the line number of the command</param>
        /// <param name="MyCanvass">Canvass on which error message is displayed</param>
        /// <param name="x">For the location in the canvass where error message is dispalyed</param>
        public void ParmChecking(bool par, String data, int n, Canvass MyCanvass, int x)
        {
            if (!par)
            {
                Font drawFont = new Font("Arial", 10);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                if (x == 0)
                {
                    MyCanvass.reset();
                }
                if (data.Equals("Right-Angled Triangle Exec"))
                {
                    MyCanvass.g.DrawString("Cannot draw triangle with given measurements", drawFont, drawBrush, 0, 0 + x);
                }
                else if ((n + 1) == 0)
                {
                    MyCanvass.g.DrawString("Paramater " + data + " is invalid", drawFont, drawBrush, 0, 0 + x);
                }
                else
                {
                    MyCanvass.g.DrawString("Paramater " + data + " on line " + (n + 1) + " is invalid", drawFont, drawBrush, 0, 0 + x);
                }
                MyCanvass.err = true;
            }
        }

        /// <summary>
        /// Displays error when number of enetered parameters are not valid in the context
        /// </summary>
        /// <param name="e">Whenever an exception is caught which checking for the validity of parameter</param>
        /// <param name="MyCanvass">Canvass on which error message is displayed</param>
        /// <param name="n">For the line number of the command</param>
        /// <param name="x">For the location in the canvass where error message is dispalyed</param>
        public void ParmChecking(Exception e, Canvass MyCanvass, int n, int x)
        {
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            if (x == 0)
            {
                MyCanvass.reset();
            }
            if ((n + 1) == 0)
            {
                MyCanvass.g.DrawString("Wrong number of parameters inputted", drawFont, drawBrush, 0, 0 + x);
            }
            else
            {
                MyCanvass.g.DrawString("Wrong number of parameters inputted on line " + (n + 1), drawFont, drawBrush, 0, 0 + x);
            }
            MyCanvass.err = true;
        }
    }
}
