﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_7장실습예제3번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iPrice = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("선택차종:");

            if (radioButton1.Checked)
            {
                listBox1.Items.Add("          승용차");
                iPrice = iPrice + 100;
                label5.Image = Properties.Resources.car_1;
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add("          트럭");
                iPrice = iPrice + 80;
                label5.Image = Properties.Resources.car_2;
            }
            else if (radioButton3.Checked)
            {
                listBox1.Items.Add("          봉고차");
                iPrice = iPrice + 50;
                label5.Image = Properties.Resources.car_3;
            }
            listBox1.Items.Add("-----------");
            listBox1.Items.Add("선택옵션:");
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("          썬루프");
                iPrice = iPrice + 1;
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add("          GPS");
                iPrice = iPrice + 3;
            }
            if (checkBox3.Checked)
            {
                listBox1.Items.Add("          에어백");
                iPrice = iPrice + 10;
            }
            if (checkBox4.Checked)
            {
                listBox1.Items.Add("          자동온도조절장치");
                iPrice = iPrice + 2;
            }
            if (checkBox5.Checked)
            {
                listBox1.Items.Add("          도난방지시스템");
                iPrice = iPrice + 2;
            }
            listBox1.Items.Add("-----------");
            listBox1.Items.Add("결재방법:");
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("          일시불");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("          무통장입금");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("          신용카드");
            }
            listBox1.Items.Add("-----------");
            listBox1.Items.Add("견적금액:" + iPrice + "만원");
            label6.Text = "견적가 : "+ iPrice +"만원";
        }
    }
}
