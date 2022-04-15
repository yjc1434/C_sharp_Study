using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_3장_반복문_실습과제_2번
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
                uint iData01 = uint.Parse(textBox1.Text);
                uint iData02 = uint.Parse(textBox2.Text);
                uint i;
                double sum = 0;
                double multi = 1;

                if (iData01 < iData02 )
                {
                    label4.Text = "증가값은 최대값보다 작은 수를 입력하세요!";
                }
                else
                {
                    for (i = 1; i <= iData01 ; i += iData02)
                    {
                        sum += i;
                        multi *= i;
                    }
                    label4.Text = "1 부터 입력된 최대값 : " + iData01 + " 까지 증가값 : " + iData02 + " 로 반복한 결과\n\n<< i 의 더하기 합계 값 : " + sum + " >>\n\n<< i의 곱하기 합계 값 : " + multi + " >>";
                }
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message + "\n다시 입력하세요!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "결과가 나오는 곳입니다!";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
