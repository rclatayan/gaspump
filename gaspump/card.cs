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
    public partial class card : Form
    {
        public card()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filltank filltank = new filltank();
            this.Hide();
            filltank.ShowDialog();
        }
    }
}
