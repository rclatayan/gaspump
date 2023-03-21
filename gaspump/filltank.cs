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
    public partial class filltank : Form
    {
        public filltank()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = (progressBar1.Value + "%");
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = "Filling fuel to your tank..";
            }
            else
            {
                label2.Text = "Tank has been filled!";
                timer1.Stop();
                receipt receipt = new receipt();
                this.Hide();
                receipt.ShowDialog();
            }
        }

        private void filltank_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
