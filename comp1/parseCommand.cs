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
                /*MyCanvass.reset();*/
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
            spl spl = new spl(cmd, MyCanvass, -1, lineNum);
            /*spl(cmd, MyCanvass, -1);*/

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
            try
            {
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
                        spl spl = new spl(cmd, MyCanvass, n, lineNum);
                        n++;
                        /*spl(cmd, MyCanvass, n);*/
                    }

                    
                }
            }
            catch
            {
                MyCanvass.syntax.CommandChecking(MyCanvass, n, lineNum);
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
            String[] method = cmd[1].Split('(',')');
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
                    MyCanvass.syntax.ParmChecking(false, "", n-z, MyCanvass, lineNum);
                    lineNum = lineNum + 20;
                }
            }
            catch
            {
                MyCanvass.syntax.ParmChecking(false, "", n-z, MyCanvass, lineNum);
                lineNum = lineNum + 20;
            }
        }
    }
}
