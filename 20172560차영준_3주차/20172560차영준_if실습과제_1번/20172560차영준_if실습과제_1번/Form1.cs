using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_if실습과제_1번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                
                if(iData01 >= 100)
                {
                    textBox2.Text = "100보다 큰수를 입력했습니다!";
                }
                else if(iData01 >= 50)
                {
                    textBox2.Text = "50과 100사이 수를 입력했습니다!";
                }
                else if(iData01 >= 10)
                {
                    textBox2.Text = "50과 10사이 수를 입력했습니다!";
                }
                else if(iData01 >= 0)
                {
                    textBox2.Text = "10과 0사이 수를 입력했습니다!";
                }
                else
                {
                    textBox2.Text = "0보다 작은수를 입력했습니다!";
                }
            }
            catch
            {
                textBox2.Text = "입력 문자열의 형식이 잘못되었습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
