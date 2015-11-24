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

        public static int hour, minute, second, temp, temp2, total;
        public static string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void hourTB_TextChanged(object sender, EventArgs e)
        {
            hour = Convert.ToInt32(hourTB.Text);
        }

        private void minuteTB_TextChanged(object sender, EventArgs e)
        {
            minute = Convert.ToInt32(minuteTB.Text);
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
            second = Convert.ToInt32(secondTB.Text);
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
            if (total >= 0) { 
                total -= 1;
                temp = total % 3600;
                temp2 = total / 3600;
                hourTB.Text = Convert.ToString(temp2);
                text += Convert.ToString(temp2);
                text += " : ";
                temp2 = temp / 60;
                minuteTB.Text = Convert.ToString(temp2);
                text += Convert.ToString(temp2);
                text += " : ";
                temp = temp % 60;
                secondTB.Text = Convert.ToString(temp);
                text += Convert.ToString(temp);
                System.IO.File.WriteAllText(@"countdown.txt", text);
                text = "";
            } else
            {
                hourTB.BackColor = Color.IndianRed;
                minuteTB.BackColor = Color.IndianRed;
                secondTB.BackColor = Color.IndianRed;
            }
        }
        public static void convertToSeconds()
        {
            total = (hour * 3600) + (minute * 60) + second;
        }
    }
}
