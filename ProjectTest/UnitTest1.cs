using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void SglParseCommandTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("drawto 10,10", "", MyCanvass);
        }
    }
}
