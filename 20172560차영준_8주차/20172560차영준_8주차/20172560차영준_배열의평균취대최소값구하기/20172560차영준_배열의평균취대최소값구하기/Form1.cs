using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_배열의평균취대최소값구하기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iarr = new int[10];
            System.Random ranNum = new System.Random();
            int cnt = 0;

            label1.Text = "";

            for (int i = 0; i < iarr.Length; i++)
            {
                iarr[i] = ranNum.Next(1, 100);
            }

            int MaxV = 0;
            int MinV = iarr[0];
            double sum = 0;

            for (int i = 0; i < iarr.Length; i++)
            {
                cnt++;
                label1.Text += "iArr[" + i + "] = " + iarr[i] + "           ";
                if(cnt == 2)
                {
                    label1.Text += "\n";
                    cnt = 0;
                }
                if (MaxV < iarr[i])
                {
                    MaxV = iarr[i];
                }
                if (MinV > iarr[i])
                {
                    MinV = iarr[i];
                }
                sum += iarr[i];
            }
            label2.Text = "배열값의 최대는 " + MaxV + "\n\n배열값의 최소는 " + MinV + "\n\n10개 원소 배열값의 평균은 " + (sum / 10);
        }
    }
}
