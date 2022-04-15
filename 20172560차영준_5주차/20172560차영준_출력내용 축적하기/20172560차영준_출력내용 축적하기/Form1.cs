using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_출력내용_축적하기
{
    public partial class Form1 : Form
    {
        string error1 = "1과 20사이의 정수를 입력하세요!";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int i;

                if (iData01 > 20 || iData01 < 1)
                {
                    label3.Text = error1.ToString();
                }
                else
                {
                    label3.Text = "수행된 i 의 값 : ";

                    for (i = 1; i <= iData01; i++)
                    {
                        label3.Text += i + ", ";

                        if (i == 6 || i == 13)
                        {
                            label3.Text += "\n\n                      ";
                        }
                    }
                    label3.Text = label3.Text.TrimEnd(' ', ',');
                }
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message + "\n" + error1;
            }
        }
    }
}
