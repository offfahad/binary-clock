namespace _3Clocks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.digitalClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryClock1 = new _3Clocks.BinaryClock();
            this.digitalClock1 = new _3Clocks.DigitalClock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitalClockToolStripMenuItem,
            this.binaryClockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // digitalClockToolStripMenuItem
            // 
            this.digitalClockToolStripMenuItem.Name = "digitalClockToolStripMenuItem";
            this.digitalClockToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.digitalClockToolStripMenuItem.Text = "Digital Clock";
            this.digitalClockToolStripMenuItem.Click += new System.EventHandler(this.digitalClockToolStripMenuItem_Click);
            // 
            // binaryClockToolStripMenuItem
            // 
            this.binaryClockToolStripMenuItem.Name = "binaryClockToolStripMenuItem";
            this.binaryClockToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.binaryClockToolStripMenuItem.Text = "Binary Clock";
            this.binaryClockToolStripMenuItem.Click += new System.EventHandler(this.binaryClockToolStripMenuItem_Click);
            // 
            // binaryClock1
            // 
            this.binaryClock1.AutoSize = true;
            this.binaryClock1.Location = new System.Drawing.Point(0, 64);
            this.binaryClock1.Name = "binaryClock1";
            this.binaryClock1.Size = new System.Drawing.Size(346, 64);
            this.binaryClock1.TabIndex = 3;
            // 
            // digitalClock1
            // 
            this.digitalClock1.AutoSize = true;
            this.digitalClock1.Location = new System.Drawing.Point(85, 48);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(169, 63);
            this.digitalClock1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 188);
            this.Controls.Add(this.binaryClock1);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clocker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem digitalClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryClockToolStripMenuItem;
        private DigitalClock digitalClock1;
        private BinaryClock binaryClock1;
    }
}

