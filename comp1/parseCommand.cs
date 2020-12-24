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
        int lineNum = 0;

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
            int x = 0;
            //loop for input in rich text box/program window
            while (n < val.Length)
            {
                String[] cmd = val[n].Split(' ');
                if (cmd[0].Equals("while"))
                {
                    List<String> data = new List<string>();
                    do
                    {
                        x++;
                        data.Add(val[n]);
                        n++;
                        cmd = val[n].Split(' ');
                    }
                    while (!cmd[0].Equals("endwhile"));
                    LoopWhile(data, MyCanvass, n, x);
                }
                else if (cmd[0].Equals("if"))
                {
                    List<String> data = new List<string>();
                    do
                    {
                        x++;
                        data.Add(val[n]);
                        n++;
                        cmd = val[n].Split(' ');
                    }
                    while (!cmd[0].Equals("endif"));
                    ConditionIf(data, MyCanvass, n, x);
                }
                else if (cmd[0].Equals("loop"))
                {
                    List<String> data = new List<string>();
                    do
                    {
                        x++;
                        data.Add(val[n]);
                        n++;
                        cmd = val[n].Split(' ');
                    }
                    while (!cmd[0].Equals("endfor"));
                    LoopFor(data, MyCanvass, n, x);
                }
                else if (cmd[0].Equals("method"))
                {
                    List<String> data = new List<string>();
                    do
                    {
                        x++;
                        data.Add(val[n]);
                        n++;
                        cmd = val[n].Split(' ');
                    }
                    while (!cmd[0].Equals("endmethod"));
                    MethodSelect(data, MyCanvass, n, x);
                }
                else
                {
                    spl(cmd, MyCanvass, n);
                }

                n++;
            }
        }

        /// <summary>
        /// Using given instructions creates a for loop
        /// </summary>
        /// <param name="data">User input for 'for' loop</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        /// <param name="n">Line where the compiler has reached</param>
        /// <param name="z"></param>
        public void LoopFor(List<String> data, Canvass MyCanvass, int n, int z)
        {
            string tempData = string.Join("\n", data);
            String[] val = tempData.Split('\n');
            String[] cmd = val[0].Split(' ');
            int x = 0;
            bool var1 = false;
            List<String> tempList = new List<string>();
            int tempInt = 1;
            while (tempInt < val.Length)
            {
                tempList.Add(val[tempInt]);
                tempInt++;
            }
            try
            {
                if (cmd[1].Equals("for"))
                {
                    if (!int.TryParse(cmd[2], out x))
                    {
                        if (!MyCanvass.v.DataExists(cmd[2]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(cmd[2]);
                        }
                    }
                }
                if (var1)
                {
                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
                else
                {

                    for (int b = 0; b < x; b++)
                    {
                        tempData = string.Join("\n", tempList);
                        multiCommand(tempData, MyCanvass);
                    }
                }

            }
            catch
            {
                MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                lineNum = lineNum + 20;
            }
        }

        /// <summary>
        /// Using given instructions creates a if condition
        /// </summary>
        /// <param name="data">User input for 'if' condition</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        /// <param name="n">Line where the compiler has reached</param>
        /// <param name="z"></param>
        public void ConditionIf(List<String> data, Canvass MyCanvass, int n, int z)
        {
            string tempData = string.Join("\n", data);
            String[] val = tempData.Split('\n');
            String[] cmd = val[0].Split(' ');
            int x = 0;
            bool var1 = false;
            List<String> tempList = new List<string>();
            int tempInt = 1;
            while (tempInt < val.Length)
            {
                tempList.Add(val[tempInt]);
                tempInt++;
            }

            try
            {
                if (cmd[1].Split('<').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('<');
                    if (!int.TryParse(tempVal[1], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[1]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[1]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            if (MyCanvass.v.GetData(tempVal[0]) < x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else if (cmd[1].Split('>').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('>');
                    if (!int.TryParse(tempVal[1], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[1]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[1]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            if (MyCanvass.v.GetData(tempVal[0]) > x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else if (cmd[1].Split('=').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('=');
                    if (!int.TryParse(tempVal[2], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[2]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[2]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[2], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            if (MyCanvass.v.GetData(tempVal[0]) == x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else
                {
                    MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
            }
            catch
            {
                MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                lineNum = lineNum + 20;
            }
        }

        /// <summary>
        /// Using given instructions creates a method
        /// </summary>
        /// <param name="data">User input for method</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        /// <param name="n">Line where the compiler has reached</param>
        /// <param name="z"></param>
        public void MethodSelect(List<String> data, Canvass MyCanvass, int n, int z)
        {
            string tempData = string.Join("\n", data);
            String[] val = tempData.Split('\n');
            String[] cmd = val[0].Split(' ');
            String x = null;
            bool var1 = false;
            String[] method = cmd[1].Split('(', ')');
            String[] methodValue = null;

            MyCanvass.m.StoreData(method[0], method[1]);
            List<String> tempList = new List<string>();
            int tempInt = 1;
            while (tempInt < val.Length)
            {
                tempList.Add(val[tempInt]);
                tempInt++;
            }

            try
            {
                if (MyCanvass.m.DataExists(method[0]))
                {
                    x = MyCanvass.m.GetData(method[0]);
                    methodValue = x.Split(',');
                }
                else
                {
                    var1 = true;
                }
                if (var1)
                {
                    MyCanvass.syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
                else
                {
                    tempData = string.Join("\n", tempList);
                    String methodCmd = method[0] + "command";
                    MyCanvass.m.StoreData(methodCmd, tempData);
                }

            }
            catch
            {
                MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                lineNum = lineNum + 20;
            }

        }

        /// <summary>
        /// Using given instructions creates a while loop
        /// </summary>
        /// <param name="data">User input for 'while' loop</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        /// <param name="n">Line where the compiler has reached</param>
        /// <param name="z"></param>
        public void LoopWhile(List<String> data, Canvass MyCanvass, int n, int z)
        {
            string tempData = string.Join("\n", data);
            String[] val = tempData.Split('\n');
            String[] cmd = val[0].Split(' ');
            int x = 0;
            bool var1 = false;
            List<String> tempList = new List<string>();
            int tempInt = 1;
            while (tempInt < val.Length)
            {
                tempList.Add(val[tempInt]);
                tempInt++;
            }

            try
            {
                if (cmd[1].Split('<').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('<');
                    if (!int.TryParse(tempVal[1], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[1]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[1]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            while (MyCanvass.v.GetData(tempVal[0]) < x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else if (cmd[1].Split('>').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('>');
                    if (!int.TryParse(tempVal[1], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[1]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[1]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[1], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            while (MyCanvass.v.GetData(tempVal[0]) > x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else if (cmd[1].Split('=').Length > 1)
                {
                    String[] tempVal = cmd[1].Split('=');
                    if (!int.TryParse(tempVal[2], out x))
                    {
                        if (!MyCanvass.v.DataExists(tempVal[2]))
                        {
                            var1 = true;
                        }
                        else
                        {
                            x = MyCanvass.v.GetData(tempVal[2]);
                        }
                    }
                    if (var1)
                    {
                        MyCanvass.syntax.ParmChecking(false, tempVal[2], n, MyCanvass, lineNum);
                        lineNum = lineNum + 20;
                    }
                    else
                    {
                        if (!MyCanvass.v.DataExists(tempVal[0]))
                        {
                            var1 = true;
                        }
                        if (var1)
                        {
                            MyCanvass.syntax.ParmChecking(false, tempVal[0], n, MyCanvass, lineNum);
                            lineNum = lineNum + 20;
                        }
                        else
                        {
                            while (MyCanvass.v.GetData(tempVal[0]) == x)
                            {
                                tempData = string.Join("\n", tempList);
                                multiCommand(tempData, MyCanvass);
                            }
                        }
                    }
                }
                else
                {
                    MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
            }
            catch
            {
                MyCanvass.syntax.ParmChecking(false, "", n - z, MyCanvass, lineNum);
                lineNum = lineNum + 20;
            }


        }

        /// <summary>
        /// Simple Programming Language(spl) which check the user inputted commands for errors and exception and runs if no error is found
        /// </summary>
        /// <param name="cmd">String command provided by user</param>
        /// <param name="MyCanvass">Canvass in which the user given instruction is implemented</param>
        /// <param name="n">line where the compiler has reached</param>
        public void spl(String[] cmd, Canvass MyCanvass, int n)
        {
            try
            {
                String[] method = cmd[0].Split('(', ')');
                //Checks if entered command exists(if not call displays error also stops further execution) also checks for validity of parameters and number of parametes
                if (cmd[0].Equals("drawto"))
                {
                    String[] data = cmd[1].Split(',');
                    int x = 0;
                    int y = 0;
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(data[0], out x))
                        {
                            if (!MyCanvass.v.DataExists(data[0]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(data[0]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                        if (!int.TryParse(data[1], out y))
                        {
                            if (!MyCanvass.v.DataExists(data[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                y = MyCanvass.v.GetData(data[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
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
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(data[0], out x))
                        {
                            if (!MyCanvass.v.DataExists(data[0]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(data[0]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                        if (!int.TryParse(data[1], out y))
                        {
                            if (!MyCanvass.v.DataExists(data[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                y = MyCanvass.v.GetData(data[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
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
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(data[0], out x))
                        {
                            if (!MyCanvass.v.DataExists(data[0]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(data[0]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                        if (!int.TryParse(data[1], out y))
                        {
                            if (!MyCanvass.v.DataExists(data[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                y = MyCanvass.v.GetData(data[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
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
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(data[0], out x))
                        {
                            if (!MyCanvass.v.DataExists(data[0]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(data[0]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[0], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                        if (!int.TryParse(data[1], out y))
                        {
                            if (!MyCanvass.v.DataExists(data[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                y = MyCanvass.v.GetData(data[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                        if (!int.TryParse(data[2], out z))
                        {
                            if (!MyCanvass.v.DataExists(data[2]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                z = MyCanvass.v.GetData(data[2]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, data[2], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
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
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(cmd[1], out x))
                        {
                            if (!MyCanvass.v.DataExists(cmd[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(cmd[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
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
                    bool var1 = false;
                    try
                    {
                        if (!int.TryParse(cmd[1], out x))
                        {
                            if (!MyCanvass.v.DataExists(cmd[1]))
                            {
                                var1 = true;
                            }
                            else
                            {
                                x = MyCanvass.v.GetData(cmd[1]);
                            }
                            if (var1)
                            {
                                MyCanvass.syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
                                lineNum = lineNum + 20;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!MyCanvass.err)
                    {
                        Shape circle = new DrawCircle(x);
                        circle.draw(MyCanvass);
                    }
                }
                else if (cmd[0].Equals("polygon"))
                {
                    String[] data = cmd[1].Split(',');
                    List<int> tempPoints = new List<int>();
                    int i = 0;
                    int x = 0;
                    bool var1 = false;
                    try
                    {
                        while (data.Length > i)
                        {
                            if (!int.TryParse(data[i], out x))
                            {
                                if (!MyCanvass.v.DataExists(data[i]))
                                {
                                    var1 = true;
                                }
                                else
                                {
                                    tempPoints.Add(MyCanvass.v.GetData(data[i]));
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, data[i], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                            tempPoints.Add(x);
                            i++;
                        }
                    }
                    catch (Exception e)
                    {
                        MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                        lineNum = lineNum + 20;
                    }
                    if (!MyCanvass.err)
                    {
                        int[] arr = tempPoints.ToArray();
                        Shape poly = new DrawPolygon(arr);
                        poly.draw(MyCanvass);
                    }
                }
                else if (cmd[0].Equals("pen"))
                {
                    Color color = Color.FromName(cmd[1]);
                    if (color.IsKnownColor == false)
                    {
                        MyCanvass.syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
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
                        MyCanvass.syntax.ParmChecking(false, cmd[1], n, MyCanvass, lineNum);
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
                else if (MyCanvass.m.DataExists(method[0]))
                {
                    String[] methodValue = (MyCanvass.m.GetData(method[0])).Split(',');
                    String methodCmd = method[0] + "command";
                    String methodCommand = MyCanvass.m.GetData(methodCmd);
                    String[] userValue = method[1].Split(',');
                    int x = 0;
                    while (methodValue.Length > x)
                    {
                        String[] valueStore = (methodValue[x] + " = " + userValue[x]).Split(' ');
                        spl(valueStore, MyCanvass, n);
                        x++;
                    }
                    multiCommand(methodCommand, MyCanvass);

                }
                else if (cmd[1].Equals("="))
                {
                    try
                    {
                        if (cmd[3].Equals("+"))
                        {
                            int varValue;
                            int x = 0;
                            int y = 0;
                            bool var1 = false;
                            try
                            {
                                if (!int.TryParse(cmd[2], out x))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[2]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        x = MyCanvass.v.GetData(cmd[2]);
                                    }
                                    /*syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;*/
                                }
                                if (!int.TryParse(cmd[4], out y))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[4]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        y = MyCanvass.v.GetData(cmd[4]);
                                    }
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                            catch (Exception e)
                            {

                                MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                                lineNum = lineNum + 20;
                            }
                            varValue = x + y;
                            MyCanvass.v.AppendData(cmd[0], varValue);
                        }
                        if (cmd[3].Equals("-"))
                        {
                            int varValue;
                            int x = 0;
                            int y = 0;
                            bool var1 = false;
                            try
                            {
                                if (!int.TryParse(cmd[2], out x))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[2]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        x = MyCanvass.v.GetData(cmd[2]);
                                    }
                                    /*syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;*/
                                }
                                if (!int.TryParse(cmd[4], out y))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[4]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        y = MyCanvass.v.GetData(cmd[4]);
                                    }
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                            catch (Exception e)
                            {

                                MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                                lineNum = lineNum + 20;
                            }
                            varValue = x - y;
                            MyCanvass.v.AppendData(cmd[0], varValue);
                        }
                        if (cmd[3].Equals("/"))
                        {
                            int varValue;
                            int x = 0;
                            int y = 0;
                            bool var1 = false;
                            try
                            {
                                if (!int.TryParse(cmd[2], out x))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[2]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        x = MyCanvass.v.GetData(cmd[2]);
                                    }
                                    /*syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;*/
                                }
                                if (!int.TryParse(cmd[4], out y))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[4]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        y = MyCanvass.v.GetData(cmd[4]);
                                    }
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                            catch (Exception e)
                            {

                                MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                                lineNum = lineNum + 20;
                            }
                            varValue = x / y;
                            MyCanvass.v.AppendData(cmd[0], varValue);
                        }
                        if (cmd[3].Equals("*"))
                        {
                            int varValue;
                            int x = 0;
                            int y = 0;
                            bool var1 = false;
                            try
                            {
                                if (!int.TryParse(cmd[2], out x))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[2]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        x = MyCanvass.v.GetData(cmd[2]);
                                    }
                                    /*syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;*/
                                }
                                if (!int.TryParse(cmd[4], out y))
                                {
                                    if (!MyCanvass.v.DataExists(cmd[4]))
                                    {
                                        var1 = true;
                                    }
                                    else
                                    {
                                        y = MyCanvass.v.GetData(cmd[4]);
                                    }
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                            catch (Exception e)
                            {

                                MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                                lineNum = lineNum + 20;
                            }
                            varValue = x * y;
                            MyCanvass.v.AppendData(cmd[0], varValue);
                        }
                    }
                    catch
                    {
                        int x = 0;
                        try
                        {
                            bool var1 = false;
                            if (!int.TryParse(cmd[2], out x))
                            {
                                if (!MyCanvass.v.DataExists(cmd[2]))
                                {
                                    var1 = true;
                                }
                                else
                                {
                                    x = MyCanvass.v.GetData(cmd[2]);
                                }
                                if (var1)
                                {
                                    MyCanvass.syntax.ParmChecking(false, cmd[2], n, MyCanvass, lineNum);
                                    lineNum = lineNum + 20;
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MyCanvass.syntax.ParmChecking(e, MyCanvass, n, lineNum);
                            lineNum = lineNum + 20;
                        }
                        if (!MyCanvass.err)
                        {
                            if (!MyCanvass.v.DataExists(cmd[0]))
                            {
                                MyCanvass.v.StoreData(cmd[0], x);
                            }
                            else
                            {
                                MyCanvass.v.AppendData(cmd[0], x);
                            }

                        }
                    }
                }
                else
                {
                    MyCanvass.syntax.CommandChecking(MyCanvass, n, lineNum);
                    lineNum = lineNum + 20;
                }
            }
            catch
            {
                MyCanvass.syntax.CommandChecking(MyCanvass, n, lineNum);
                lineNum = lineNum + 20;
            }


        }
    }
}