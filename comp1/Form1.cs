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
        const int bitmapVal1 = 640;
        const int bitmapVal2 = 480;
        public Bitmap OutputBitmap = new Bitmap(bitmapVal1, bitmapVal2);

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

        public void OutputWindow_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            OutputBitmap.Save(saveFileDialog1.FileName);
            //OutputWindow.Image = new Bitmap("image1.jpg");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OutputWindow.Load(openFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String command = cmdLine.Text.Trim().ToLower();
            String mulCommand = ProgramWindow.Text.Trim().ToLower();
            parseCommand cmd = new parseCommand();
            cmd.Command(command, mulCommand, MyCanvass);
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String command = cmdLine.Text.Trim().ToLower();
            String mulCommand = ProgramWindow.Text.Trim().ToLower();
            //SyntaxCheck syn = new SyntaxCheck(command, mulCommand);
        }

        private void SyntaxChecking_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
