using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MulCommandTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("run", "drawto 10,10", MyCanvass);
        }

        [TestMethod]
        public void SglCommandTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("drawto 10,10", "", MyCanvass);
        }

        [TestMethod]
        public void DrawToTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("drawto 10,10", "", MyCanvass);
        }

        [TestMethod]
        public void MoveToTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("moveto 10,10", "", MyCanvass);
        }

        [TestMethod]
        public void RectangleTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("rectangle 10,10", "", MyCanvass);
            parse.Command("square 10", "", MyCanvass);
        }

        [TestMethod]
        public void CircleTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("circle 10", "", MyCanvass);
        }

        [TestMethod]
        public void TriangleTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("drawto 100,80,20", "", MyCanvass);
        }

        [TestMethod]
        public void ColorTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("pen black", "", MyCanvass);
        }

        [TestMethod]
        public void FillTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("fill on", "", MyCanvass);
        }

        [TestMethod]
        public void ClearTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("clear", "", MyCanvass);
        }

        [TestMethod]
        public void ResetTest()
        {
            comp1.Form1 form = new comp1.Form1();
            comp1.parseCommand parse = new comp1.parseCommand();
            Bitmap outBitmap = form.OutputBitmap;

            comp1.Canvass MyCanvass = new comp1.Canvass(Graphics.FromImage(outBitmap));
            parse.Command("reset", "", MyCanvass);
        }
    }
}