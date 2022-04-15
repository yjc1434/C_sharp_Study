using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_if실습과제_2번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    if (textBox2.Text != "")
                    {
                        double dData01 = double.Parse(textBox1.Text);
                        double dData02 = double.Parse(textBox2.Text);
                        double dData03 = dData02 * 3.28;
                        double dData04 = dData02 / 3.28;

                        if (textBox1.Text == "1")
                        {
                            textBox3.Text = "" + dData03 + "";
                            label7.Text = "feet";
                        }
                        else if (textBox1.Text == "2")
                        {
                            textBox3.Text = "" + dData04 + "";
                            label7.Text = "meter";
                        }
                    }
                    else
                    {
                        textBox2.Text = "환산할 수를 입력하세요!";
                    }
                }
                else
                {
                    textBox1.Text = "1 또는 2를 입력하세요!";
                }
            }
            catch
            {
                textBox3.Text = "입력 문자열의 형식의 잘못되었습니다.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
