using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_Switch실습과제_3
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
                string sData01 = textBox1.Text;

                switch (textBox1.Text)
                {
                    case "byte":
                        label1.Text = "byte의 허용값은" + byte.MinValue + "~" + byte.MaxValue + "입니다!";
                        break;
                    case "short":
                        label1.Text = "short의 허용값은" + short.MinValue + "~" + short.MaxValue + "입니다!";
                        break;
                    case "int":
                        label1.Text = "int의 허용값은" + int.MinValue + "~" + int.MaxValue + "입니다!";
                        break;
                    case "long":
                        label1.Text = "long의 허용값은" + long.MinValue + "~" + long.MaxValue + "입니다!";
                        break;
                    case "sbyte":
                        label1.Text = "sbyte의 허용값은" + sbyte.MinValue + "~" + sbyte.MaxValue + "입니다!";
                        break;
                    case "ushort":
                        label1.Text = "ushort의 허용값은" + ushort.MinValue + "~" + ushort.MaxValue + "입니다!";
                        break;
                    case "uint":
                        label1.Text = "uint의 허용값은" + uint.MinValue + "~" + uint.MaxValue + "입니다!";
                        break;
                    case "ulong":
                        label1.Text = "ulong의 허용값은" + ulong.MinValue + "~" + ulong.MaxValue + "입니다!";
                        break;
                    case "float":
                        label1.Text = "float의 허용값은" + float.MinValue + "~" + float.MaxValue + "입니다!";
                        break;
                    case "double":
                        label1.Text = "double의 허용값은" + double.MinValue + "~" + double.MaxValue + "입니다!";
                        break;
                    case "":
                        label1.Text = "10가지 Data Type 중 하나만 입력 하세요!";
                        break;
                    default:
                        label1.Text = "\"" + sData01 + "\"는 알수없는 Data Type 입니다!";
                        break;
                }
            }
            catch
            {
                label1.Text = "10가지 Data Type 중 하나만 입력 하세요!";
            }
        }
    }
}
