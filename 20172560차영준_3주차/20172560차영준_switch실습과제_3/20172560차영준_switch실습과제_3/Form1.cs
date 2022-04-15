using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_switch실습과제_3
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
                char cData = char.Parse(textBox1.Text);

                if (cData >= 'a' && cData <= 'z')
                {
                    switch (cData)
                    {
                        case 'a':
                            label3.Text = "\"a\" is a vowel";
                            break;
                        case 'e':
                            label3.Text = "\"e\" is a vowel";
                            break;
                        case 'i':
                            label3.Text = "\"i\" is a vowel";
                            break;
                        case 'o':
                            label3.Text = "\"o\" is a vowel";
                            break;
                        case 'u':
                            label3.Text = "\"u\" is a vowel";
                            break;
                        default:
                            label3.Text = "\"" + cData + "\" is a consonant";
                            break;
                    }
                }
                else
                {
                    label3.Text = "\"" + cData + "\"을 입력하였습니다!\n영문 알파벳을 다시 입력하세요!";
                }
            }
            catch
            {
                label3.Text = "문자열의 길이는 1자여야 합니다.";
            }
        }
    }
}