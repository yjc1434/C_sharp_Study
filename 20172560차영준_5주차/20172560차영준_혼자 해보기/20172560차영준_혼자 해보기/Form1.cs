﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_혼자_해보기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "결과가 나오는 곳입니다!";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                uint iData01 = uint.Parse(textBox1.Text);

                double dData01 = 1;
                
                for (int i = 1; i <= iData01 ; i++)
                {
                    dData01 = dData01 * i;
                }
                label3.Text = iData01 + " ! = " + dData01 + " 입니다.";

                if (dData01 == double.PositiveInfinity)
                {
                    label3.Text = iData01 + " ! = Infinity 입니다.";
                }
            }
            catch
            {
                label3.Text = "잘못된 입력입니다!";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
