using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_과제2번
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int dData01 = int.Parse(textBox1.Text);
                    int dData02 = int.Parse(textBox2.Text);
                    int dData03 = dData01 / dData02;
                    int dData04 = dData01 % dData02;
                    label2.Text = + dData01 + " 나누기" + dData02 + " 의 몫은 " + dData03 + " 이고 나머지는 " + dData04 + " 입니다.";
               }
                catch (Exception ex)
                {
                    label2.Text = ex.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "결과가 표시되는 곳입니다!";
            textBox1.Text = "5";
            textBox2.Text = "2";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
