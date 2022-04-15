using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_4장혼자해보기1번
{
    public partial class Form1 : Form
    {
        double dData01 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 += dData02;
                label1.Text = dData01.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 -= dData02;
                label1.Text = dData01.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 *= dData02;
                label1.Text = dData01.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 /= dData02;
                label1.Text = dData01.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dData01 = 0;
            textBox1.Text = "";
            label1.Text = dData01.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
