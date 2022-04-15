using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_4장혼자해보기3번
{
    public partial class Form1 : Form
    {
        double dData01 = 0;
        int cnt = 0;
        string result = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 += dData02;
                result += " + " + dData02;
                cnt++;
                label2.Text = "계산 결과 : " + dData01;
                label1.Text = "수행단계 : " + result;
                label3.Text = "계산 수행 횟수 " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                label2.Text = "계산 결과 : " + ex.Message;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 -= dData02;
                result += " - " + dData02;
                cnt++;
                label2.Text = "계산 결과 : " + dData01;
                label1.Text = "수행단계 : " + result;
                label3.Text = "계산 수행 횟수 " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                label2.Text = "계산 결과 : " + ex.Message;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 *= dData02;
                result += " * " + dData02;
                cnt++;
                label2.Text = "계산 결과 : " + dData01;
                label1.Text = "수행단계 : " + result;
                label3.Text = "계산 수행 횟수 " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                label2.Text = "계산 결과 : " + ex.Message;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double dData02 = double.Parse(textBox1.Text);
                dData01 /= dData02;
                result += " / " + dData02;
                cnt++;
                label2.Text = "계산 결과 : " + dData01;
                label1.Text = "수행단계 : " + result;
                label3.Text = "계산 수행 횟수 " + cnt;
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                label2.Text = "계산 결과 : " + ex.Message;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = "계산 결과 : ";
            label1.Text = "수행단계 : ";
            label3.Text = "계산 수행 횟수 ";
            textBox1.Text = "";
            result = "0";
            dData01 = 0;
        }
    }
}
