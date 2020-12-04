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
            Font drawFont = new Font("Arial", 10);//create font
            SolidBrush drawBrush = new SolidBrush(Color.Black);//create brush
            n++;
            if (n != 0)
            {
                if (x==0)
                {
                    MyCanvass.reset();//resets if error has never been found prevoiusly
                }
                MyCanvass.g.DrawString("Command on line " + (n) + " does not exist", drawFont, drawBrush, 0, 0 + x);//displays where and what the problem is(in case of multiline commands)(for component2)
            }
            else
            {
                MyCanvass.g.DrawString("Command does not exist", drawFont, drawBrush, 0, 0);//displays if the command is not recognized
            }
            MyCanvass.err = true;//sets the err to true
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
                Font drawFont = new Font("Arial", 10);//create font
                SolidBrush drawBrush = new SolidBrush(Color.Black);//create brush
                if (x == 0)
                {
                    MyCanvass.reset();//resets if error has never been found prevoiusly
                }
                else if ((n + 1) == 0)
                {
                    //displays if parameters are invalid
                    MyCanvass.g.DrawString("Paramater " + data + " is invalid", drawFont, drawBrush, 0, 0 + x);
                }
                else
                {
                    //displays if parameters are invalid(for multi line commands)(for component2)
                    MyCanvass.g.DrawString("Paramater " + data + " on line " + (n + 1) + " is invalid", drawFont, drawBrush, 0, 0 + x);
                }
                MyCanvass.err = true;//sets the err to true
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
            Font drawFont = new Font("Arial", 10);//create font
            SolidBrush drawBrush = new SolidBrush(Color.Black);//create brush
            if (x == 0)
            {
                MyCanvass.reset();//resets if error has never been found prevoiusly
            }
            if ((n + 1) == 0)
            {
                //displays if number of parameters are invalid
                MyCanvass.g.DrawString("Wrong number of parameters inputted", drawFont, drawBrush, 0, 0 + x);
            }
            else
            {
                //displays if number of parameters are invalid(for multi line commands)(for component2)
                MyCanvass.g.DrawString("Wrong number of parameters inputted on line " + (n + 1), drawFont, drawBrush, 0, 0 + x);
            }
            MyCanvass.err = true;//sets the err to true
        }
    }
}
