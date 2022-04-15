using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_switch실습과제_4
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
                int iData01 = int.Parse(textBox3.Text);
                int iData02 = int.Parse(textBox2.Text);
                string sData01 = textBox1.Text;

                if (textBox1.Text == "")
                {
                    label5.Text = "문자열의 길이는 1자여야 합니다";
                }
                else
                {
                    switch (sData01)
                    {
                        case "A":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 더하기 값은 -> " + (iData01 + iData02) + " 입니다.";
                            break;
                        case "a":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 더하기 값은 -> " + (iData01 + iData02) + " 입니다.";
                            break;
                        case "S":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 빼기 값은 -> " + (iData01 - iData02) + " 입니다.";
                            break;
                        case "s":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 빼기 값은 -> " + (iData01 - iData02) + " 입니다.";
                            break;
                        case "M":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 곱하기 값은 -> " + (iData01 * iData02) + " 입니다.";
                            break;
                        case "m":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 곱하기 값은 -> " + (iData01 * iData02) + " 입니다.";
                            break;
                        case "D":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 나누기 값은 -> " + (iData01 / iData02) + " 입니다.";
                            break;
                        case "d":
                            label5.Text = "숫자 : \"" + iData01 + "\" 와 숫자 : \"" + iData02 + "\" 의 나누기 값은 -> " + (iData01 / iData02) + " 입니다.";
                            break;
                        default:
                            label5.Text = "Operation textBox에 문자 A, S, M, D 중 하나를 입력하세요!";
                            break;
                    }
                }
            }
            catch
            {
                label5.Text = "입력 문자열의 형식이 잘못되었습니다.";
            }
        }
    }
}
