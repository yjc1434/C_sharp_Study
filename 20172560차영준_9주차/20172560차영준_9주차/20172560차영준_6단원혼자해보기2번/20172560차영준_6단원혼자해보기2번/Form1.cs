using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_6단원혼자해보기2번
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
            int[] inum = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string idata01 = textBox1.Text;
            if (idata01.IndexOf("-") >= 0)
            {
                label3.Text = "-빼고 입력해주세요";
            }
            else if (idata01.Length != 13)
            {
                label3.Text = "정확히 입력해주세요";
            }
            else
            {
                int Z = 0;
                int Y = 0;
                for (int i = 0; i < idata01.Length; i++)
                {
                    inum[i] = int.Parse(idata01.Substring(i, 1));
                }
                for (int j = 0; j < 8; j++)
                {
                    Y += inum[j] * (j + 2);
                }
                for (int j = 8; j < 12; j++)
                {
                    Y += inum[j] * (j - 6);
                }
                Z = (11 - (Y % 11)) % 10;
                if (Z == inum[12])
                {
                    label3.Text = "올바른 주민번호입니다.";
                }
                else
                {
                    label3.Text = "정확히 입력해 주세요";
                }
                }
            }
            catch
            {
                label3.Text = "정확히 입력해 주세요";
            }
        }
    }
}
