using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1
{
    /// <summary>
    /// Simple Programming Language- spl
    /// </summary>
    class spl
    {
        /// <summary>
        /// Simple Programming Language(spl) which check the user inputted commands for errors and exception and runs if no error is found
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="MyCanvass"></param>
        /// <param name="n"></param>
        /// <param name="lineNum"></param>
        public spl(String[] cmd, Canvass MyCanvass, int n, int lineNum)
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
                    /*int y = 0;
                    int z = 0;*/
                    bool var1 = false;
                    try
                    {
                        while (data.Length>i)
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
                        spl spl = new spl(valueStore, MyCanvass, n, lineNum);
                        x++;
                    }
                    parseCommand mul = new parseCommand();
                    mul.multiCommand(methodCommand, MyCanvass);

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
