using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_실습예제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = int.Parse(textBox3.Text);
                int iData04 = (iData01 + iData02 + iData03) / 3;

                string sData01 = "";
                
                if (iData04 >= 90)
                {
                    sData01 = "수";
                }
                else if (iData04 >= 80)
                {
                    sData01 = "우";
                }
                else if (iData04 >= 70)
                {
                    sData01 = "미";
                }
                else if (iData04 >= 60)
                {
                    sData01 = "양";
                }
                else
                {
                    sData01 = "가";
                }
                label4.Text = "평균 : " + iData04 + ", 성적 : " + sData01;
            }
            catch
            {
                label4.Text = "결과에 이상이 있습니다.";
            }
        }
    }
}
