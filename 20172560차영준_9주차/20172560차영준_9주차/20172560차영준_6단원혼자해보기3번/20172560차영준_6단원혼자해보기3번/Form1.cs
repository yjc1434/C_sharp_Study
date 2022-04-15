using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_6단원혼자해보기3번
{
    public partial class Form1 : Form
    {
        string[] sUwords;
        public Form1()
        {
            InitializeComponent();
            sUwords = new string[4];
            sUwords[0] = "바보";
            sUwords[1] = "메롱";
            sUwords[2] = "님아";
            sUwords[3] = "8억";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sAll = textBox1.Text;

            string temp1 = "";
            string temp2 = "";

            foreach (string one in sUwords)
            {
                int a = sAll.IndexOf(one);
                while (a >= 0)
                {
                    if (a >= 0)
                    {
                        temp1 = sAll.Substring(0, sAll.IndexOf(one)); // 0부터 금지어까지 자름
                        temp2 = sAll.Substring(sAll.IndexOf(one) + one.Length); // 금지어부터 금지어 길이까지 짜름;
                        sAll = temp1 + "(금지어) " + temp2;
                        textBox1.Text = sAll;
                    }
                    a = sAll.IndexOf(one);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

            string t1 = "";
            string t2 = "";

            foreach (string c in sUwords)
            {
                int d = a.IndexOf(c);
                while (d >= 0)
                {
                    if (d >= 0)
                    {
                        if(d >= 0)
                        {
                            t1 = a.Substring(0, a.IndexOf(c));
                            t2 = a.Substring(a.IndexOf(c) + c.Length);
                            a = t1 + " (금지어)" + t2;
                            textBox1.Text = a;
                        }
                        d = a.IndexOf(c);
                    }
                }
            }
        }
    }
}
