using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_문자열형식지정하기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 12345;
            double dNum = 0.05;

            string str = String.Format("{0:C}이고, 재산순위 상위 {1:P1}", num, dNum);
            label3.Text = "귀하의 잔액은 " + str + "입니다.";

            string str2 = String.Format("{0:C}", num);
            label2.Text = "귀하의 잔액은 " + str2 + "입니다.";
        }
    }
}
