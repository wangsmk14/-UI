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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty&&textBox3.Text!=string.Empty&&comboBox1.Text!="other")
            {
                if (checkBox1.Checked!=true)
                {
                   // MessageBox.Show("注册成功");
                    likes f2=new likes();
                    f2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请先同意用户协议");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uat f2 = new uat();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "用户名";
            textBox2.Text = "密码";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
