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

        /// <summary>
        /// Exitx the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// About Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By:\nAashish Bhattarai \n2020");
        }

        /// <summary>
        /// Syntax of all commands in Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void syntaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "Syntax:\n";
            message = message + "1. To move the pointer: \nmoveto x,y (where x and y are pointer you want to move to) \n";
            message = message + "2. To draw to a point: \ndrawto x,y (where x and y are pointer you want to draw to) \n";
            message = message + "3. To create a square: \nsquare x (where x is the width of the square) \n";
            message = message + "4. To create a rectangle: \nrectangle x,y (where x is the width and y is the height of the rectangle)\n";
            message = message + "5. To create a triangle: \ntriangle x,y,z (where x,y,z is the hyp,base and adjacent of the triangle)\n";
            message = message + "6. To create a circle: \nrectangle x (where x is the radius of the circle)\n";
            message = message + "7. To choose a color for pen: \npen color (where coolr is the desired color for the pen)\n";
            message = message + "8. To choose to fill: \nfill on/off (On or off depending on the user)\n";
            message = message + "9. To clear the canvass: \nclear (Clear the canvass)\n";
            message = message + "10. To reset the canvass: \nreset (Clear the canvass and data)\n";
            message = message + "11. To run the command: \nrun (runs the command)\n";
            MessageBox.Show(message);
        }

        /// <summary>
        /// Syntax of moveto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void movePointerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To move the pointer: \nmoveto x,y (where x and y are pointer you want to move to) \n");
        }

        /// <summary>
        /// Syntax of drawto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void drawLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To draw to a point: \ndrawto x,y (where x and y are pointer you want to draw to) \n");
        }

        /// <summary>
        /// Syntax of square
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void drawSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a square: \nsquare x (where x is the width of the square) \n");
        }

        /// <summary>
        /// Syntax of rectangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void drawRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a rectangle: \nrectangle x,y (where x is the width and y is the height of the rectangle)\n");
        }

        /// <summary>
        /// Syntax of triagnle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void drawTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a triangle: \ntriangle x,y,z (where x,y,z is the hyp,base and adjacent of the triangle)\n");
        }

        /// <summary>
        /// Syntax of circle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void drawCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a circle: \nrectangle x (where x is the radius of the circle)\n");
        }

        /// <summary>
        /// Syntax of pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void chooseAColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To choose a color for pen: \npen color (where coolr is the desired color for the pen)\n");
        }

        /// <summary>
        /// Syntax of fill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void chooseFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To choose to fill: \nfill on/off (On or off depending on the user)\n");
        }

        /// <summary>
        /// Syntax of clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To clear the canvass: \nclear (Clear the canvass)\n");
        }

        /// <summary>
        /// Syntax of reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To reset the canvass: \nreset (Clear the canvass and data)\n");
        }

        /// <summary>
        /// Command run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        private void runCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To run the command: \nrun (runs the command entered in Program Window)\n");
        }
    }
}
