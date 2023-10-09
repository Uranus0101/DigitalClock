using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            greenButton.FlatStyle = FlatStyle.Flat;
            grayButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            purpleButton.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();

        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Green;
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Gray;
        }

        private void blueButton_Click_1(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Blue;
        }

        private void yellowButton_Click_1(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Yellow;
        }

        private void purpelButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Purple;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Mongolian Baiti", 90, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Nirmala UI", 90, FontStyle.Regular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Comic Sans MS", 90, FontStyle.Regular);
        }
    }
}
