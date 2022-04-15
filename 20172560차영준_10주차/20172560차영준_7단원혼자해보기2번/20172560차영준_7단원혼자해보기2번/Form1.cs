using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_7단원혼자해보기2번
{
    public partial class Form1 : Form
    {
        CheckBox[] Mgr;

        public Form1()
        {
            InitializeComponent();

            Mgr = new CheckBox[10];
            Mgr[0] = checkBox1;
            Mgr[1] = checkBox2;
            Mgr[2] = checkBox3;
            Mgr[3] = checkBox4;
            Mgr[4] = checkBox5;
            Mgr[5] = checkBox6;
            Mgr[6] = checkBox7;
            Mgr[7] = checkBox8;
            Mgr[8] = checkBox9;
            Mgr[9] = checkBox10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random ranNum = new System.Random();

            for (int i = 0; i < 10; i++)
            {
                Mgr[i].Text = ranNum.Next(1, 99).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                double TempSum = 0;
                int cnt = 0;
                double result = 0.0;


                listBox1.Items.Add("각 체크박스의 숫자들");
                listBox1.Items.Add("---------------------");

                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add("checkBox" + (i + 1) + " = " + Mgr[i].Text);
                }
                listBox2.Items.Add("선택된 체크박스의 숫자들");
                listBox2.Items.Add("---------------------");

                for (int i = 0; i < 10; i++)
                {
                    if (Mgr[i].Checked)
                    {
                        TempSum += double.Parse(Mgr[i].Text);
                        cnt++;
                        listBox2.Items.Add("checkBox" + (i + 1) + " = " + Mgr[i].Text);
                    }
                }
                listBox2.Items.Add("---------------------");
                listBox2.Items.Add("");
                listBox2.Items.Add("선택된 체크박스의 숫자합계");
                listBox2.Items.Add("---------------------");
                listBox2.Items.Add("숫자합계 ->" + TempSum);
                listBox2.Items.Add("---------------------");
                listBox2.Items.Add("");
                listBox2.Items.Add("선택된 체크박스의 숫자의 평균");
                listBox2.Items.Add("---------------------");
                result = TempSum / cnt;
                listBox2.Items.Add("숫자평균 ->" + result);

            }
            catch (Exception ex)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Mgr[i].Checked)
                    {
                        listBox2.Items.Add("checkBox" + (i + 1) + " = " + Mgr[i].Text);
                    }
                }
                listBox2.Items.Add("---------------------");
                listBox2.Items.Add("");
                listBox2.Items.Add("선택된 체크박스의 숫자합계");
  
                MessageBox.Show("숫자 바꾸기를 먼저하세요!\n" + ex.Message);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (Mgr[i].Checked)
                {
                    Mgr[i].Checked = false;
                }
                Mgr[i].Text = "checkBox" + (i + 1);
            }
            this.Form1_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("");
            listBox2.Items.Add("1) 10개짜리 체크박스 배열 만들기");
            listBox2.Items.Add("");
            listBox2.Items.Add("   CheckBox[] checkBoxMgr;");
            listBox2.Items.Add("  checkBoxMgr = new CheckBox[10];");
            listBox2.Items.Add("   TextBook Page258 참고");
            listBox2.Items.Add("");
            listBox2.Items.Add("2) 반복문을 이용 각각의 체크박스에 랜덤숫자 넣기");
            listBox2.Items.Add("");
            listBox2.Items.Add("  for (int i = 0;i < 10;i++)");
            listBox2.Items.Add("   checkBoxMgr[i].Text = ranNum.Next(1,99).ToString();");
            listBox2.Items.Add("");
            listBox2.Items.Add("3) 반복문을 이용 선택된 체크박스의 숫자 더하기");
            listBox2.Items.Add("");
            listBox2.Items.Add("  for (int i = 0;i < 10;i++)");
            listBox2.Items.Add("   if (checkBoxMgr[i].Checked)");
            listBox2.Items.Add("      TempSum += int.Parse(checkBoxMgr[i].Text);");
            listBox2.Items.Add("");
            listBox2.Items.Add("4) 초기화시 반복문이용 체크박스의 선택 해제");
            listBox2.Items.Add("");
            listBox2.Items.Add("  for (int i = 0;i < 10;i++)");
            listBox2.Items.Add("   if (checkBoxMgr[i].Checked)");
            listBox2.Items.Add("    checkBoxMgr[i].Checked = false;");
        }
    }
}
