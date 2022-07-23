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
    public partial class rop : Form
    {
        public rop()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true&&checkBox2.Checked == true&&checkBox3.Checked == true&&checkBox4.Checked == true)
            {
                winned ff = new winned();
                ff.Show();
                this.Close();
            }
        }
    }
}
