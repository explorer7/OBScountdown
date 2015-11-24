using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBStimer
{
    public partial class Form1 : Form
    {
        //Original values that are set at timer start
        public static int hour, minute, second, totalInSeconds;
        //Values that are calculated on timer1_tick (all variables store values of seconds)
        public static int totalHr, totalMinAndSec, totalSec; 
        public StringBuilder text = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void hourTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void minuteTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void hourTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minuteTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void secondTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void secondTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                button1.Text = "Start";
                timer1.Enabled = false;
                hourTB.ReadOnly = false;
                minuteTB.ReadOnly = false;
                secondTB.ReadOnly = false;
                hourTB.BackColor = Color.White;
                minuteTB.BackColor = Color.White;
                secondTB.BackColor = Color.White;
            }
            else if (timer1.Enabled == false)
            {
                button1.Text = "Stop";
                hour = Convert.ToInt32(hourTB.Text);
                minute = Convert.ToInt32(minuteTB.Text);
                second = Convert.ToInt32(secondTB.Text);
                convertToSeconds();
                timer1.Enabled = true;
                hourTB.ReadOnly = true;
                minuteTB.ReadOnly = true;
                secondTB.ReadOnly = true;
                hourTB.BackColor = Color.Turquoise;
                minuteTB.BackColor = Color.Turquoise;
                secondTB.BackColor = Color.Turquoise;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalInSeconds >= 0) {
                totalInSeconds -= 1;
                totalMinAndSec = totalInSeconds % 3600;
                totalHr = totalInSeconds / 3600;
                hourTB.Text = Convert.ToString(totalHr);
                text.Append(Convert.ToString(totalHr));
                text.Append(" : ");
                minuteTB.Text = Convert.ToString(totalMinAndSec / 60);
                text.Append(Convert.ToString(totalMinAndSec / 60));
                text.Append(" : ");
                totalSec = totalMinAndSec % 60;
                secondTB.Text = Convert.ToString(totalSec);
                text.Append(Convert.ToString(totalSec));
                System.IO.File.WriteAllText(@"countdown.txt", text.ToString());
                text.Clear();
            } else
            {
                hourTB.BackColor = Color.IndianRed;
                minuteTB.BackColor = Color.IndianRed;
                secondTB.BackColor = Color.IndianRed;
            }
        }
        public static void convertToSeconds()
        {
            totalInSeconds = (hour * 3600) + (minute * 60) + second;
        }
    }
}
