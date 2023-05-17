using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{   
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void replaceValue(String value)
        {
            if (result.Text == "0")
            {
                result.Text = result.Text.Replace(result.Text, value);
            }
            else
            {
                result.Text = result.Text + value;
            }
        }

        private void clearValue(bool clearAll)
        {
            if (clearAll == true)
            {
                result.Text = result.Text.Replace(result.Text, "0");
                history.Text = history.Text.Replace(history.Text, "");
            }
            else
            {
                result.Text = result.Text.Replace(result.Text, "0");
            }
        }

        private void addHistory(String value)
        {
            if (history.Text == "")
            {
                history.Text = result.Text + " " + value + " ";
            }
            else
            {
                history.Text = history.Text + " " + result.Text + " " + value + " ";
            }
            result.Text = result.Text.Replace(result.Text, "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            replaceValue("0");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            clearValue(false);
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            replaceValue("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            replaceValue("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            replaceValue("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            replaceValue("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            replaceValue("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            replaceValue("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            replaceValue("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            replaceValue("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            replaceValue("9");
        }

        private void history_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            clearValue(true);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            addHistory("+");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            addHistory("-");
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            addHistory("x");
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            addHistory("/");
        }
    }
}
