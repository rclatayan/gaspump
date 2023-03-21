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
    public partial class gastype : Form
    {
        public gastype()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            premium premium = new premium();
            this.Hide();
            premium.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            unleaded unleaded = new unleaded();
            this.Hide();
            unleaded.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            diesel diesel = new diesel();
            this.Hide(); 
            diesel.ShowDialog();
        }
    }
}
