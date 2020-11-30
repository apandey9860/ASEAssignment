using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace comp1
{
    class parseCommand
    {
        int x=0;

        public void Command(String command, String mulCommand, Canvass MyCanvass)
        {

            if (mulCommand.Length.Equals(0))
            {
                singleCommand(command, MyCanvass);
            }
            else if (command.Equals("run"))
            {
                multiCommand(mulCommand, MyCanvass);
            }
            else
            {
                multiCommand(mulCommand, MyCanvass);
            }

        }
        public void singleCommand(String command, Canvass MyCanvass)
        {
            String[] cmd = command.Split(' ');
            spl(cmd, MyCanvass, -1);

        }
        public void multiCommand(String command, Canvass MyCanvass)
        {
            String[] val = command.Split('\n');
            int n = 0;
            while (n < val.Length)
            {
                String[] cmd = val[n].Split(' ');
                spl(cmd, MyCanvass, n);
                n++;
            }
        }
        public void spl(String[] cmd, Canvass MyCanvass, int n)
        {
            if (cmd[0].Equals("drawto"))
            {
                String[] data = cmd[1].Split(',');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                MyCanvass.DrawLine(x, y);
            }
            else if (cmd[0].Equals("moveto"))
            {
                String[] data = cmd[1].Split(',');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                MyCanvass.MoveTo(x, y);
            }
            else if (cmd[0].Equals("rectangle"))
            {
                String[] data = cmd[1].Split(',');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                Shape rect = new DrawSquare(x, y);
                rect.draw(MyCanvass);
            }
            else if (cmd[0].Equals("triangle"))
            {
                String[] data = cmd[1].Split(',');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                int z = int.Parse(data[2]);
                Shape tri = new DrawTriangle(x, y, z);
                tri.draw(MyCanvass);
            }
            else if (cmd[0].Equals("square"))
            {
                int x = int.Parse(cmd[1]);
                Shape sqr = new DrawSquare(x,x);
                sqr.draw(MyCanvass);
            }
            else if (cmd[0].Equals("circle"))
            {
                int x = int.Parse(cmd[1]);
                Shape sqr = new DrawCircle(x);
                sqr.draw(MyCanvass);
            }
            else if (cmd[0].Equals("pen"))
            {
                Color color = Color.FromName(cmd[1]);
                MyCanvass.set_Pen_Color(color);
            }
            else if (cmd[0].Equals("fill"))
            {
                if (cmd[1].Equals("on"))
                {
                    MyCanvass.fill = true;
                }
                else if (cmd[1].Equals("off"))
                {
                    MyCanvass.fill = false;
                }
            }
            else if (cmd[0].Equals("clear"))
            {
                MyCanvass.clear();
            }
            else if (cmd[0].Equals("reset"))
            {
                MyCanvass.reset();
            }
            else if (cmd[0].Equals("exit"))
            {
                Application.Exit();
            }
            else
            {
                Font drawFont = new Font("Arial", 10);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                n++;
                if (n != 0)
                {
                    if (x == 0)
                    {
                        MyCanvass.reset();
                    }
                    MyCanvass.g.DrawString("Command on line " + (n) + " does not exist", drawFont, drawBrush, 0, 0+x);
                    x=x+20;
                }
                else
                {
                    MyCanvass.g.DrawString("Command does not exist", drawFont, drawBrush, 0, 0);
                }
                n--;
                
            }
        }
    }
}
