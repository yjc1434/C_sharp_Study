using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_과제1_배열출력하기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iarr = new int[100];
            int i;
            int cnt = 0;

            label1.Text = "";

            for (i = 0 ;i < iarr.Length; i++)
            {
                iarr[i] = i + 1;
            }
            foreach (int num in iarr)
            {
                cnt++;
                label1.Text += num + " ";
                if (cnt == 10)
                {
                    label1.Text += "\n";
                    cnt = 0;
                }
            }
        }
    }
}
