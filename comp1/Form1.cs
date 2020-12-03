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
    /// <summary>
    /// Displays a form for user input and interaction
    /// </summary>
    public partial class Form1 : Form
    {
        const int bitmapVal1 = 640;
        const int bitmapVal2 = 480;
        public Bitmap OutputBitmap = new Bitmap(bitmapVal1, bitmapVal2);

        Canvass MyCanvass;
        public Graphics g;

        /// <summary>
        /// Initialize form components and Load canvass
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            MyCanvass = new Canvass(Graphics.FromImage(OutputBitmap));
        }

        /// <summary>
        /// Function which runs on user key press in cmdLine within the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The key which is pressed by user in current context</param>
        private void cmdLine_KeyDown(object sender, KeyEventArgs e)
        {
            //Only runs when the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                String command = cmdLine.Text.Trim().ToLower();
                String mulCommand = ProgramWindow.Text.Trim().ToLower();
                parseCommand cmd = new parseCommand();
                cmd.Command(command, mulCommand, MyCanvass);
                Refresh();
            }
        }

        /// <summary>
        /// Loads picturebox to Graphics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Paint event argument for the picturebox</param>
        public void OutputWindow_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }


        /// <summary>
        /// Save the Bitmap image in current picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains information for current event</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exception handling in case save dialog is opened and not used
            try
            {
                saveFileDialog1.ShowDialog();
                OutputBitmap.Save(saveFileDialog1.FileName);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.ToString());
            }
        }

        /// <summary>
        /// Load the Bitmap image in current picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains information for current event</param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exception handling in case load dialog is opened and not used
            try
            {
                openFileDialog1.ShowDialog();
                OutputWindow.Load(openFileDialog1.FileName);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.ToString());
            }
        }

        /// <summary>
        /// Terminates the application on clicking menu item Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains information for current event</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Runs the program on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains information for current event</param>
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
            Application.Exit();
        }
    }
}
