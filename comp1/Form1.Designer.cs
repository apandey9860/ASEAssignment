
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
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.cmdLine = new System.Windows.Forms.TextBox();
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(524, 25);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(570, 370);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputWindow_Paint);
            // 
            // cmdLine
            // 
            this.cmdLine.Location = new System.Drawing.Point(35, 446);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(465, 22);
            this.cmdLine.TabIndex = 1;
            this.cmdLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdLine_KeyDown);
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Location = new System.Drawing.Point(35, 25);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(465, 370);
            this.ProgramWindow.TabIndex = 2;
            this.ProgramWindow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 480);
            this.Controls.Add(this.ProgramWindow);
            this.Controls.Add(this.cmdLine);
            this.Controls.Add(this.OutputWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.TextBox cmdLine;
        private System.Windows.Forms.RichTextBox ProgramWindow;
    }
}

