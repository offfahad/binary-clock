using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Clocks
{
    public partial class BinaryClock : UserControl
    {
        public BinaryClock()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            /*Convert.ToString(hour, 2) converts the integer value hour to a binary string representation. 
            The 2 parameter specifies that the string should be in base 2 (binary).
            .PadLeft(4, '0') pads the binary string with leading zeros so that it has a minimum length
            of 4 characters. This is achieved by the PadLeft method, which takes two arguments: 
            the minimum length of the resulting string (4 in this case) and the character to use
            for padding ('0' in this case).*/

            label1.Text = Convert.ToString(hour, 2).PadLeft(4, '0');
            label2.Text = Convert.ToString(minute, 2).PadLeft(6, '0');
            label3.Text = Convert.ToString(second, 2).PadLeft(6, '0');
        }
        private void BinaryClock_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            label1.Text = Convert.ToString(hour, 2).PadLeft(4, '0');
            label2.Text = Convert.ToString(minute, 2).PadLeft(6, '0');
            label3.Text = Convert.ToString(second, 2).PadLeft(6, '0');
        }
    }
}
