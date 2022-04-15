using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string ivar02 = textBox2.Text;
                string ivar03 = textBox3.Text;
                label6.Text = "유선 : " + ivar02 + "\n무선 : " + ivar03 + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string ivar = textBox1.Text;
                string ivar01 = textBox4.Text;
                label5.Text = "성명 : " + ivar + "\n학번 : " + ivar01 + "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                label5.Text = "";
                label6.Text = "";
            }
        }
    }
}
