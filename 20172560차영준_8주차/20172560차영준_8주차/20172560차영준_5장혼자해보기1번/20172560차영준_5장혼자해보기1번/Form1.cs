using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_5장혼자해보기1번
{
    public partial class Form1 : Form
    {
        int win = 0;
        int lose = 0;
        int draw = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Random ranNum = new System.Random();
                int cpu = ranNum.Next(1, 4);
                int user = 0;
                string result = "";
                string result2 = "";
                if (textBox1.Text != "")
                {
                    if (textBox1.Text == "가위" || textBox1.Text == "보" || textBox1.Text == "바위")
                    {
                        if (cpu == 1)
                        {
                            result = "가위";
                        }
                        if (cpu == 2)
                        {
                            result = "바위";
                        }
                        if (cpu == 3)
                        {
                            result = "보";
                        }

                        if (textBox1.Text == "가위")
                        {
                            user = 1;
                        }
                        if (textBox1.Text == "바위")
                        {
                            user = 2;
                        }
                        if (textBox1.Text == "보")
                        {
                            user = 3;
                        }
                        if (cpu == user)
                        {
                            result2 = "무승부";
                            draw++;
                        }
                        if (cpu == 1 && user == 2)
                        {
                            result2 = "User 승";
                            win++;
                        }
                        if (cpu == 1 && user == 3)
                        {
                            result2 = "User 패";
                            lose++;
                        }
                        if (cpu == 2 && user == 1)
                        {
                            result2 = "User 승";
                            win++;
                        }
                        if (cpu == 2 && user == 3)
                        {
                            result2 = "User 패";
                            lose++;
                        }
                        if (cpu == 3 && user == 1)
                        {
                            result2 = "User 승";
                            win++;
                        }
                        if (cpu == 3 && user == 2)
                        {
                            result2 = "User 패";
                            lose++;
                        }
                        label2.Text = "User 는 ->" + textBox1.Text + "\nSystem 은 ->" + result + "\n결과는 -> " + result2;
                        label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        textBox1.Text = "";
                    }
                    else
                    {
                        lose++;
                        label2.Text = "입력값이 '가위, 바위, 보'\n중 하나가 아니어서 패 처리합니다.";
                        label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                        textBox1.Text = "";
                    }

                    
                }
                else
                {
                    lose++;
                    label2.Text = "입력값이 '가위, 바위, 보'\n중 하나가 아니어서 패 처리합니다.";
                    label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                    textBox1.Text = "";
                }
            }
            catch
            {
                lose++;
                label2.Text = "입력값이 '가위, 바위, 보'\n중 하나가 아니어서 패 처리합니다.";
                label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
                textBox1.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
