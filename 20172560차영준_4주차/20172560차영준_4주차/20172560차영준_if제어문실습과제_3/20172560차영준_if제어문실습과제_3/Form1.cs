using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_if제어문실습과제_3
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
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);

                if (textBox3.Text == ">")
                {
                    bool bData = iData01 > iData02;
                    label1.Text = iData01 + " > " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == ">=")
                {
                    bool bData = iData01 >= iData02;
                    label1.Text = iData01 + " >= " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == "==")
                {
                    bool bData = iData01 == iData02;
                    label1.Text = iData01 + " == " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == "<=")
                {
                    bool bData = iData01 <= iData02;
                    label1.Text = iData01 + " <= " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == "<")
                {
                    bool bData = iData01 < iData02;
                    label1.Text = iData01 + " < " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == "!=")
                {
                    bool bData = iData01 < iData02;
                    label1.Text = iData01 + " != " + iData02 + " 의 결과는 " + bData;
                }
                else if (textBox3.Text == "")
                {
                    label1.Text = "Operator에 관계연산자 하나를입력하세요!";
                }
                else
                    label1.Text = "\"" + textBox3.Text + "\"" + "는 올바른 관계연산자가 아님\n" + "올바른 관계연산자를 입력하세요!";
            }
            catch
            {
            if (textBox1.Text == "")
                    label1.Text = "숫자1에 정수를 입력하세요.";
            else if (textBox2.Text == "")
                    label1.Text = "숫자2에 정수를 입력하세요.";
            else
                    label1.Text = "입력 문자열의 형식이 잘못되었습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            textBox2.Text = "3";
            textBox3.Text = "";
            label1.Text = "결과가 나오는 곳 입니다!";
        }
    }
}