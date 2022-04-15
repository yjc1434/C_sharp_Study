using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_입력수까지의_소수_구하기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                uint iData01 = uint.Parse(textBox1.Text);
                int i,j;
                int cnt = 0;
                int cnt2 = 0;

                if (iData01 > 200)
                {
                    label3.Text = iData01 + " 를 입력하세요.";
                }
                else
                {
                    label3.Text = iData01 + " 까지 발견된 소수는 다음과 같습니다.\n\n";
                    for (i = 2 ;i <= iData01 ; i++)
                    {
                        for (j = 2;j <= i;j++)
                        {
                            if (i % j == 0)
                                break;
                        }
                        if (i == j)
                        {
                            label3.Text += i + " ,";
                            cnt ++;
                            if (cnt % 10 == 0)
                            {
                                label3.Text += "\n";
                            }
                        }
                    }
                    label3.Text = label3.Text.TrimEnd(',', ' ');
                }
                
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message + "\n2 ~ 200 사이의 수를 입력하세요!";
            }
        }
    }
}
