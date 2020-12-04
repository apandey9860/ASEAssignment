using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace comp1
{
    /// <summary>
    /// Class which takes user input in textbox/richtextbox and runs according to given instructions
    /// </summary>
    public class parseCommand
    {
        int lineNum=0;

        /// <summary>
        /// Runs further according to given command in cmdLine or ProgramWindow
        /// </summary>
        /// <param name="command">User input in cmdLine(Single line textbox)</param>
        /// <param name="mulCommand">User input in ProgramWindow(Multi line rich textbox)</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        public void Command(String command, String mulCommand, Canvass MyCanvass)
        {
            //to reset err value and canvass after execution in case of an error
            if (MyCanvass.err)
            {
                MyCanvass.reset();
                MyCanvass.err = false;//sets err to false
            }
            //if there no input in rich text box(program window)
            if (mulCommand.Length.Equals(0))
            {
                singleCommand(command, MyCanvass);
            }
            //if 'run' is used in command line
            else if (command.Equals("run"))
            {
                multiCommand(mulCommand, MyCanvass);
            }
            else
            {
                multiCommand(mulCommand, MyCanvass);
            }

        }

        /// <summary>
        /// Splits given instruction in cmdLine and executes Simple Programming Language(spl)
        /// </summary>
        /// <param name="command">User input in cmdLine(Single line textbox)</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        public void singleCommand(String command, Canvass MyCanvass)
        {
            String[] cmd = command.Split(' ');
            spl(cmd, MyCanvass, -1);

        }

        /// <summary>
        /// Splits given instruction in ProgramWindow and executes Simple Programming Language(spl) based on the number of lines
        /// </summary>
        /// <param name="command">User input in ProgramWindow(Multi line rich textbox)</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        public void multiCommand(String command, Canvass MyCanvass)
        {
            String[] val = command.Split('\n');
            int n = 0;
            //loop for input in rich text box/program window
            while (n < val.Length)
            {
                String[] cmd = val[n].Split(' ');
                spl(cmd, MyCanvass, n);
                n++;
            }
        }

        /// <summary>
        /// Simple Programming Language(spl) which check the user inputted commands for errors and exception and runs if no error is found
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="MyCanvass"></param>
        /// <param name="n"></param>
        public void spl(String[] cmd, Canvass MyCanvass, int n)
        {
            SyntaxChecking syntax = new SyntaxChecking();

            //Checks if entered command exists(if not call displays error also stops further execution) also checks for validity of parameters and number of parametes
            if (cmd[0].Equals("drawto"))
            {
                String[] data = cmd[1].Split(','); ;
                int x = 0;
                int y = 0;
                try
                {
                    if(!int.TryParse(data[0], out x))
                    {
                        syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!int.TryParse(data[1], out y))
                    {
                        syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    MyCanvass.DrawLine(x, y);
                }
            }
            else if (cmd[0].Equals("moveto"))
            {
                String[] data = cmd[1].Split(','); ;
                int x = 0;
                int y = 0;
                try
                {
                    if (!int.TryParse(data[0], out x))
                    {
                        syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!int.TryParse(data[1], out y))
                    {
                        syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                    MyCanvass.MoveTo(x, y);
            }
            else if (cmd[0].Equals("rectangle"))
            {
                String[] data = cmd[1].Split(','); ;
                int x = 0;
                int y = 0;
                try
                {
                    if (!int.TryParse(data[0], out x))
                    {
                        syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!int.TryParse(data[1], out y))
                    {
                        syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    Shape rect = new DrawSquare(x, y);
                    rect.draw(MyCanvass);
                }
            }
            else if (cmd[0].Equals("triangle"))
            {
                String[] data = cmd[1].Split(','); ;
                int x = 0;
                int y = 0;
                int z = 0;
                try
                {
                    if (!int.TryParse(data[0], out x))
                    {
                        syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!int.TryParse(data[1], out y))
                    {
                        syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if(!int.TryParse(data[2],out z))
                    {
                        syntax.ParmChecking(false, data[2], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (x != (y + z))
                    {
                        syntax.ParmChecking(false, "Right-Angled Triangle Exec", n, MyCanvass,lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    Shape tri = new DrawTriangle(x, y, z);
                    tri.draw(MyCanvass);
                }
            }
            else if (cmd[0].Equals("square"))
            {
                int x = 0;
                try
                {
                    if (!int.TryParse(cmd[1], out x))
                    {
                        syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    Shape sqr = new DrawSquare(x, x);
                    sqr.draw(MyCanvass);
                }
            }
            else if (cmd[0].Equals("circle"))
            {
                int x = 0;
                try
                {
                    if (!int.TryParse(cmd[1], out x))
                    {
                        syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                }
                catch (Exception e)
                {
                    syntax.ParmChecking(e, MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    Shape sqr = new DrawCircle(x);
                    sqr.draw(MyCanvass);
                }
            }
            else if (cmd[0].Equals("pen"))
            {
                Color color = Color.FromName(cmd[1]);
                if (color.IsKnownColor == false)
                {
                    syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                    MyCanvass.set_Pen_Color(color);
            }
            else if (cmd[0].Equals("fill"))
            {
                bool valOn = cmd[1].Equals("on");
                bool valOff = cmd[1].Equals("off");
                if (valOn == false && valOff == false)
                {
                    syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
                if (!MyCanvass.err)
                {
                    if (valOn)
                    {
                        MyCanvass.fill = true;
                    }
                    else if (valOff)
                    {
                        MyCanvass.fill = false;
                    }
                }
            }
            else if (cmd[0].Equals("clear"))
            {
                if (!MyCanvass.err)
                    MyCanvass.clear();
            }
            else if (cmd[0].Equals("reset"))
            {
                if (!MyCanvass.err)
                    MyCanvass.reset();
            }
            else if (cmd[0].Equals("exit"))
            {
                if (!MyCanvass.err)
                    Application.Exit();
            }
            else
            {
                
                syntax.CommandChecking(MyCanvass, n, lineNum);
                lineNum = lineNum + 20;
            }
        }
    }
}
