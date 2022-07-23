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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"https://www.bilibili.com/video/BV1uT4y1P7CX");
        }
    }
}
