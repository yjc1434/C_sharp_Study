using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ivar01 = int.Parse(textBox1.Text);
                label1.Text = "결과는 " + ivar01 + " 입니다.";
            }           
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double ivar02 = double.Parse(textBox1.Text);
                    label1.Text = "결과는 " + ivar02 + " 입니다.";
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int ivar03 = int.Parse(textBox1.Text);
                    label1.Text = "결과는 " + ivar03 + " + 332 = " + ivar03 + "332 입니다.";
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
            }
        }
    }
}
