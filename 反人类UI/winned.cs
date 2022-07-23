using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 反人类UI
{
    public partial class winned : Form
    {
        public winned()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start ffff = new start();
            ffff.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            register ffff = new register();
            ffff.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            start ffff = new start();
            ffff.Close();
            this.Close();
        }
    }
}
