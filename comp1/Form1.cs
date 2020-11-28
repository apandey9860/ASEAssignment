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
        public Graphics g;

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
                parseCommand cmd = new parseCommand();
                cmd.Command(command, mulCommand, MyCanvass);
                Refresh();
            }
        }

        private void OutputWindow_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        

       
    }
}
