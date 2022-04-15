using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_특정범위사이의구구단출력
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
                int iData02 = int.Parse(textBox2.Text);
                int i, j;

                if(iData01 > 1 && iData01 < 10)
                {
                    if (iData02 > 1 && iData02 < 10)
                    {
                        label4.Text = "구구단 " + iData01 + "부터 " + iData02 + "단 까지 입니다!\n\n";

                        for (i = iData01;i<=iData02;i++)
                        {
                            for (j = 2;j<=9;j++)
                            {
                                label4.Text += i + " * " + j + " = " + i * j + "\n";
                            }
                            label4.Text += "\n";
                        }
                    }
                    else
                    {
                        label4.Text = "2와 9사이의 수를 입력하세요!";
                    }
                }
                else
                {
                    label4.Text = "2와 9사이의 수를 입력하세요!";
                }
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
