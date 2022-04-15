using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_iArray
{
    public partial class Form1 : Form
    {
        int[] iarr = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < iarr.Length; i++)
            {
                iarr[i] = 0;
            }
            label1.Text = "배열값 초기화 완료!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Random ranNum = new System.Random();

            for (int i = 0; i < iarr.Length; i++)
            {
                iarr[i] = ranNum.Next(1, 10);
            }
            label1.Text = "배열값 바꾸기 완료!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            foreach (int num1 in iarr)
            {
                label1.Text += num1 + ",";
            }
            label1.Text = label1.Text.TrimEnd(',', ' ');
        }
    }
}
