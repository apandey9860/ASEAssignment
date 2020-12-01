using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    class SyntaxChecking
    {
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
                MyCanvass.g.DrawString("Paramater " + data + " on line " + (n+1) + " is invalid", drawFont, drawBrush, 0, 0 + x);
                MyCanvass.err = true;
            }
        }
        public void ParmChecking(Exception e, Canvass MyCanvass, int n, int x)
        {
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            MyCanvass.g.DrawString("Wrong number of parameters inputted on line " + (n+1), drawFont, drawBrush, 0, 0 + x);
            MyCanvass.err = true;
        }
    }
}
