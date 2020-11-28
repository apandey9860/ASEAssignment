using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace comp1
{
    class parseCommand
    {

        public void Command(String command, String mulCommand, Canvass MyCanvass)
        {

            if (mulCommand.Length.Equals(0))
            {
                
                singleCommand(command, MyCanvass);
            }
            else
            {
                multiCommand(mulCommand, MyCanvass);
            }

        }
        public void singleCommand(String command, Canvass MyCanvass)
        {
            String[] cmd = command.Split(' ');
            spl(cmd, MyCanvass);

        }
        public void multiCommand(String command, Canvass MyCanvass)
        {
            String[] val = command.Split('\n');
            int n = 0;
            while (n < val.Length)
            {
                String[] cmd = val[n].Split(' ');
                spl(cmd, MyCanvass);
                n++;
            }
        }
        public void spl(String[] cmd, Canvass MyCanvass)
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
            else if (cmd[0].Equals("clear"))
            {
                MyCanvass.clear();
            }
            else if (cmd[0].Equals("reset"))
            {
                MyCanvass.reset();
            }
        }
    }
}
