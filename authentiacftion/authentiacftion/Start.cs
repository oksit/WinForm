using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authentiacftion
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Form1 fr2 = new Form1();
            fr2.Show();
            this.Hide();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }
    }
}
