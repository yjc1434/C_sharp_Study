using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20172560차영준_7단원혼자해보기1번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Image = Properties.Resources.자동차_사진_1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Image = Properties.Resources.자동차_사진_2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Image = Properties.Resources.자동차_사진_3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Image = Properties.Resources.자동차_사진_4;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label1.Image = Properties.Resources.자동차_사진_5;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label1.Image = Properties.Resources.자동차_사진_6;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
