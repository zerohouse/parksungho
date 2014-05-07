using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int h, m ,s, ss, stopwatch, timer = 0;
        int type;
        public Form1()
        {

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (type == 1)
            {
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
                s = DateTime.Now.Second;
                label1.Text = h + ":" + m + ":" + s;
            }

            if (type == 2)
            {
                stopwatch++;
                h = stopwatch / 36000;
                m = stopwatch/600 % 60;
                s = stopwatch/ 10 %60;
                ss = stopwatch %10 ;
                label1.Text = h + ":" + m + ":" + s + ":" + ss;
            }
            if (type==3&&timer!=0)
            {
                label1.Text = timer/10 + ":" + timer%10;
                timer--;
                if (timer == 0)
                {
                    label1.Text = "끝";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (type == 3)
            {
                timer = Convert.ToInt32(textBox1.Text)*10;
            }
            timer1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
