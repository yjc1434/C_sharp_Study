using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_합과곱
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long sum = 0;
                long sum1 = 1;
                long i;

                uint iData01 = uint.Parse(textBox1.Text);
                uint iData02 = uint.Parse(textBox2.Text);

                if (iData01<= 0)
                {
                    label4.Text = "시작값은 0보다 큰 값이여야 합니다!";
                }
                else if (iData01 > 20)
                {
                    label4.Text = "마지막값은 20보다 큰 값이여야 합니다!";
                }
                else
                {
                    for (i = iData01; i <= iData02; i++)
                    {
                        sum = sum + i;
                        sum1 = sum1 * i;

                    }
                    label4.Text = iData01 + " 부터 " + iData02 + "까지의 합은 " + sum + "\n 곱은 " + sum1 + " 입니다.";
                }
            }
            catch (Exception ex)
            {
                if (textBox1.Text == "")
                {
                    label4.Text = "시작값을 입력하세요!";
                }
                else if (textBox2.Text == "")
                {
                    label4.Text = "마지막값을 입력하세요!";
                }
                else
                {
                    label4.Text = ex.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
