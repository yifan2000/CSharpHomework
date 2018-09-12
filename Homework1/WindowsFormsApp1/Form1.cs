using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static int txtConvertToInt(string txt)//转换文本
        {
            int result = 0;
            bool f = int.TryParse(txt, out result);
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = txtConvertToInt(textBox1.Text);
            int num2 = txtConvertToInt(textBox2.Text);
            int num = num1 * num2;
            string numm = num.ToString();
            MessageBox.Show("The product is: " + numm);
        }
    }
}
