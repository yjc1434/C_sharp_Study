using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_7단원혼자해보기3번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = comboBox2.SelectedIndex;
            if (month == 1) // 2월달
            {
                if (comboBox1.SelectedIndex % 4 == 0) // 29일
                {
                    comboBox3.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboBox3.Items.Add(i.ToString());
                }
                else // 28일
                {
                    comboBox3.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboBox3.Items.Add(i.ToString());
                }
            }
            else if (month == 0 || month == 2 || month == 4 || month == 6 || month == 7 || month == 9 || month == 11)
            {
                comboBox3.Items.Clear();
                for (int i = 1; i <= 31; i++)
                    comboBox3.Items.Add(i.ToString());
            }
            else
            {
                comboBox3.Items.Clear();
                for (int i = 1; i <= 30; i++)
                    comboBox3.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            int genSec = 0;

            if (radioButton1.Checked)
            {
                gender = "남";
                genSec = 1;
            }
            if (radioButton2.Checked)
            {
                gender = "여";
                genSec = 1;
            }

            if (textBox1.Text == "")
            {
                label5.Text = "성명을 입력해주세요!";
            }
            else if (genSec != 1)
            {
                label5.Text = "성별을 선택해주세요!";
            }
            else
            {
                label5.Text = textBox1.Text + "님의 정보\n성별 : " + gender + "\n생년월일 : " + comboBox1.Text + " 년  " + comboBox2.Text + " 월  " + comboBox3.Text + " 일";
            }
        }
    }
}
