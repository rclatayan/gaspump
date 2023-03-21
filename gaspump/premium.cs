using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaspump
{
    public partial class premium : Form
    {
        public premium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1;
            textBox1.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 2;
            textBox1.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 3;
            textBox1.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 4;
            textBox1.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 5;
            textBox1.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 6;
            textBox1.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 7;
            textBox1.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 8;
            textBox1.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 9;
            textBox1.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 0;
            textBox1.Text += number;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToString();
            double liter;
            double price = 60.25;
            double amount;

            liter = Convert.ToDouble(textBox2.Text);
            amount = liter * price;
            textBox3.Text = amount.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            gastype gastype = new gastype();
            this.Hide();
            gastype.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            card card = new card();
            this.Hide();
            card.ShowDialog();
        }
    }
}
