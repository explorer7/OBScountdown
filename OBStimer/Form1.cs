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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                button1.Text = "Stop";
                timer1.Enabled = false;
            }
            else if (timer1.Enabled == false)
            {
                button1.Text = "Start";
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = timer1.
        }
    }
}
