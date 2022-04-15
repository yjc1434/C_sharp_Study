using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_구분자로문자열분리
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "홍길동,이순신;임꺽정 세종대왕";
            string str2 = ";, ";
            string[] str3;
            string[] str4;

            str3 = str1.Split(str2.ToCharArray());
            str4 = str1.Split(str2.ToCharArray(),3);

            label4.Text = str3[0];
            label5.Text = str3[1];
            label6.Text = str3[2];
            label7.Text = str3[3];

            label8.Text = str4[0];
            label9.Text = str4[1];
            label10.Text = str4[2];

        }
    }
}
