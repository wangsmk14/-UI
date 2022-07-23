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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        int s, m, h;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fff=new Form2();
            fff.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            register frf = new register();
            frf.Show();
            this.Hide();
        }

        private void start_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Tick += new EventHandler(t_Tick);
            t.Interval = 1000;
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            //row new NotImplementedException();
            s++;
            if (s == 60) { m++; MessageBox.Show(m.ToString()+"分钟了"); }
            if (m == 60) { h++; }

        }
    }
}
