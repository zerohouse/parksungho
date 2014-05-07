using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int init = 1;

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += new KeyEventHandler(enter);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";


        }
        private void enter(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                if (init==1)
                {
                    init = 2;
                    if (radioButton1.Checked)
                    {
                        textBox2.Text = radioButton1.Text + " : " + textBox1.Text;
                        radioButton2.Checked = true;
                        textBox1.Text = "";
                    }
                    else if (radioButton2.Checked)
                    {
                        textBox2.Text = radioButton2.Text + " : " + textBox1.Text;
                        radioButton1.Checked = true;
                        textBox1.Text = "";
                    }



                }
                else { 
                    if (radioButton1.Checked)
                    {
                    textBox2.Text = textBox2.Text + "\r\n" + radioButton1.Text +  " : " + textBox1.Text;
                    radioButton2.Checked = true;
                    textBox1.Text = "";
                    }
                    else if (radioButton2.Checked)
                    {
                    textBox2.Text = textBox2.Text + "\r\n" + radioButton2.Text + " : " + textBox1.Text;
                    radioButton1.Checked = true;
                    textBox1.Text = "";
                    }
                }
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
