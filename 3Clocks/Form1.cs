using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Clocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            digitalClock1.Visible = true;
            binaryClock1.Visible = false;
        }
        private void binaryClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            digitalClock1.Visible = false;
            binaryClock1.Visible = true;
        }
    }
}
