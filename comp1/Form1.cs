using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1
{
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(640, 480);
        Canvass MyCanvass;

        public Form1()
        {
            InitializeComponent();
            MyCanvass = new Canvass(Graphics.FromImage(OutputBitmap));
        }


        private void cmdLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String command = cmdLine.Text.Trim().ToLower();
                String mulCommand = ProgramWindow.Text.Trim().ToLower();
                parseCommand(command, mulCommand);
                Refresh();
            }
        }

        private void OutputWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        public void parseCommand(String command, String mulCommand)
        {
            if (mulCommand.Length.Equals(0))
            {
                singleCommand(command);
            }
            else
            {
                multiCommand(mulCommand);
            }
            
        }
        public void singleCommand(String command)
        {
            String[] cmd = command.Split(' ');
            spl(cmd);
            
        }
        public void multiCommand(String command)
        {
            String[] val = command.Split('\n');
            int n = 0;
            while (n < val.Length)
            {
                String[] cmd = val[n].Split(' ');
                spl(cmd);
                n++;
            }
        }
        public void spl(String[] cmd)
        {
            if (cmd[0].Equals("line"))
            {
                String[] data = cmd[1].Split(',');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                MyCanvass.DrawLine(x, y);
            }
        }
    }
}
