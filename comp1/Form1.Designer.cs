
namespace comp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLine = new System.Windows.Forms.TextBox();
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movePointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.runCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLine
            // 
            this.cmdLine.Location = new System.Drawing.Point(12, 387);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(465, 22);
            this.cmdLine.TabIndex = 1;
            this.cmdLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdLine_KeyDown);
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Location = new System.Drawing.Point(12, 31);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(465, 350);
            this.ProgramWindow.TabIndex = 2;
            this.ProgramWindow.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::comp1.Properties.Resources._84297;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::comp1.Properties.Resources._25402;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::comp1.Properties.Resources._217_2179335_exit_clipart_svg_exit_icon_vector_png;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syntaxToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // syntaxToolStripMenuItem
            // 
            this.syntaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movePointerToolStripMenuItem,
            this.drawLineToolStripMenuItem,
            this.drawSquareToolStripMenuItem,
            this.drawRectangleToolStripMenuItem,
            this.drawTriangleToolStripMenuItem,
            this.drawCircleToolStripMenuItem,
            this.chooseAColorToolStripMenuItem,
            this.chooseFillToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.runCommandToolStripMenuItem});
            this.syntaxToolStripMenuItem.Image = global::comp1.Properties.Resources._2701073_200;
            this.syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            this.syntaxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.syntaxToolStripMenuItem.Text = "Syntax";
            this.syntaxToolStripMenuItem.Click += new System.EventHandler(this.syntaxToolStripMenuItem_Click);
            // 
            // movePointerToolStripMenuItem
            // 
            this.movePointerToolStripMenuItem.Name = "movePointerToolStripMenuItem";
            this.movePointerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.movePointerToolStripMenuItem.Text = "Move Pointer";
            this.movePointerToolStripMenuItem.Click += new System.EventHandler(this.movePointerToolStripMenuItem_Click);
            // 
            // drawLineToolStripMenuItem
            // 
            this.drawLineToolStripMenuItem.Name = "drawLineToolStripMenuItem";
            this.drawLineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawLineToolStripMenuItem.Text = "Draw Line";
            this.drawLineToolStripMenuItem.Click += new System.EventHandler(this.drawLineToolStripMenuItem_Click);
            // 
            // drawSquareToolStripMenuItem
            // 
            this.drawSquareToolStripMenuItem.Name = "drawSquareToolStripMenuItem";
            this.drawSquareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawSquareToolStripMenuItem.Text = "Draw Square";
            this.drawSquareToolStripMenuItem.Click += new System.EventHandler(this.drawSquareToolStripMenuItem_Click);
            // 
            // drawRectangleToolStripMenuItem
            // 
            this.drawRectangleToolStripMenuItem.Name = "drawRectangleToolStripMenuItem";
            this.drawRectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawRectangleToolStripMenuItem.Text = "Draw Rectangle";
            this.drawRectangleToolStripMenuItem.Click += new System.EventHandler(this.drawRectangleToolStripMenuItem_Click);
            // 
            // drawTriangleToolStripMenuItem
            // 
            this.drawTriangleToolStripMenuItem.Name = "drawTriangleToolStripMenuItem";
            this.drawTriangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawTriangleToolStripMenuItem.Text = "Draw Triangle";
            this.drawTriangleToolStripMenuItem.Click += new System.EventHandler(this.drawTriangleToolStripMenuItem_Click);
            // 
            // drawCircleToolStripMenuItem
            // 
            this.drawCircleToolStripMenuItem.Name = "drawCircleToolStripMenuItem";
            this.drawCircleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawCircleToolStripMenuItem.Text = "Draw Circle";
            this.drawCircleToolStripMenuItem.Click += new System.EventHandler(this.drawCircleToolStripMenuItem_Click);
            // 
            // chooseAColorToolStripMenuItem
            // 
            this.chooseAColorToolStripMenuItem.Name = "chooseAColorToolStripMenuItem";
            this.chooseAColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chooseAColorToolStripMenuItem.Text = "Choose a color";
            this.chooseAColorToolStripMenuItem.Click += new System.EventHandler(this.chooseAColorToolStripMenuItem_Click);
            // 
            // chooseFillToolStripMenuItem
            // 
            this.chooseFillToolStripMenuItem.Name = "chooseFillToolStripMenuItem";
            this.chooseFillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chooseFillToolStripMenuItem.Text = "Choose Fill";
            this.chooseFillToolStripMenuItem.Click += new System.EventHandler(this.chooseFillToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::comp1.Properties.Resources.info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.Filter = "Images (*.jpg)|*.jpg| Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.SystemColors.Control;
            this.OutputWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputWindow.Location = new System.Drawing.Point(493, 31);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(570, 350);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputWindow_Paint);
            // 
            // runCommandToolStripMenuItem
            // 
            this.runCommandToolStripMenuItem.Name = "runCommandToolStripMenuItem";
            this.runCommandToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.runCommandToolStripMenuItem.Text = "Run Command";
            this.runCommandToolStripMenuItem.Click += new System.EventHandler(this.runCommandToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1080, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgramWindow);
            this.Controls.Add(this.cmdLine);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Programming Language";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.TextBox cmdLine;
        private System.Windows.Forms.RichTextBox ProgramWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syntaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movePointerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCommandToolStripMenuItem;
    }
}

