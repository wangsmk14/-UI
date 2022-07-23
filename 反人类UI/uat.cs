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
    public partial class uat : Form
    {
        Timer f1 = new Timer();
        public uat()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f1.Tick += new EventHandler(f1_Tick);
            f1.Interval = 30000;
            f1.Enabled = true;
        }

        void f1_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            button1.Enabled = true;
            f1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
       
        }
    }
}
