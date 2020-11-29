using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace comp1
{
    class SyntaxCheck : Form1
    {
        public SyntaxCheck(String command, String multiCommand)
        {
            if (multiCommand.Length.Equals(0))
            {

                sglCommand(command);
            }
            else
            {
                mulCommand(multiCommand);
            }
        }
        public void sglCommand(String command)
        {
            String[] cmd = command.Split(' ');
            if (cmd[0].Equals("moveto") || cmd[0].Equals("drawto") || cmd[0].Equals("rectangle"))
            {
                String[] data = cmd[1].Split(',');
                try
                {
                    int x = int.Parse(data[0]);
                    int y = int.Parse(data[1]);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }
        public void mulCommand(String mulCommand)
        {

        }
    }
}
