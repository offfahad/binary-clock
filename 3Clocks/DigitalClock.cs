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
    public partial class DigitalClock : UserControl
    {
        Timer timer = new Timer();
        public DigitalClock()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            timer.Start();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            timer.Start();
        }
    }
}
