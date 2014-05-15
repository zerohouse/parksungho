using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iotest
{

    public partial class Form1 : Form
    {
        string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           toolStripStatusLabel1.Text = "open";
           if (openFileDialog1.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
           {
               string str = openFileDialog1.FileName;
               filepath = str+".iotest.txt";
               toolStripStatusLabel1.Text = str;
               string result = FileRead(str);
               textBox1.Text = result;
           }


        }


        public string FileRead(string file)
        {
            string zzz = "";
            StreamReader r = new StreamReader(file, Encoding.GetEncoding("euc-kr"));

            while (r.Peek() != -1)
            {
                zzz = zzz + "\r\n" + r.ReadLine();

            }

            return zzz;
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {

                StreamWriter sw = new StreamWriter(filepath, false, Encoding.GetEncoding("euc-kr"));
                sw.Write(textBox1.Text);
                sw.Close();
                toolStripStatusLabel1.Text = filepath;
            
        }

 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }




}
