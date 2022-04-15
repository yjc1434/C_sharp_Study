using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_4장실습예제3번
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dData01 = 0;

            try
            {
                int iData01 = int.Parse (textBox1.Text);
                if (iData01 < 50000)
                {
                    for (int i = 1; i <= iData01; i++)
                    {
                        dData01 += i;
                    }
                    cnt++;
                    label2.Text = "합 : " + dData01;
                }
                else
                {
                    label2.Text = "1~50000 사이의 수만 입력해 주세요";
                }
                label3.Text = "프로그램 실행 후 현재까지 이용 횟수 : " + cnt + "회";
            }
            catch
            {
                label2.Text = "결과에 이상이 있습니다";
            }
        }
    }
}
