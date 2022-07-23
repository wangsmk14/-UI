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
    public partial class nr : Form
    {
        public nr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = System.DateTime.Now.ToString("y");
            int b = 0,c=0;
            a = a.Substring(0,4);
            b = int.Parse(a);
            try
            {
                c = int.Parse(comboBox1.Text);
                int d=b-c;
                if (numericUpDown1.Value == d || numericUpDown1.Value - 1 == d || numericUpDown1.Value + 1 == d)
                {
                    if (textBox3.Text + textBox2.Text == textBox1.Text)
                    {
                        if ((comboBox4.Text == "先生" && comboBox5.Text == "男") || (comboBox4.Text == "女士" && comboBox5.Text == "女"))
                        {
                            rop f3 = new rop();
                            f3.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的名称");
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的年龄");
                }
            }
            catch 
            {
                MessageBox.Show("请输入正确的年龄");
            }
        }

        private void nr_Load(object sender, EventArgs e)
        {
            for (int y = 1900; y < 2023; y++) comboBox1.Items.Add(y.ToString());
            for (int y = 1; y < 13; y++) comboBox3.Items.Add(y.ToString());
        }

        private void comboBox3_ClientSizeChanged(object sender, EventArgs e)
        {
            
            if (comboBox3.Text == "1" || comboBox3.Text == "3" || comboBox3.Text == "5" || comboBox3.Text == "7" || comboBox3.Text == "8" || comboBox3.Text == "10" || comboBox3.Text == "12")
            {
                comboBox2.Items.Clear();
                for (int y = 1; y < 32; y++) comboBox2.Items.Add(y.ToString());
            }
            else if (comboBox3.Text == "4" || comboBox3.Text == "6" || comboBox3.Text == "9" || comboBox3.Text == "11")
            {
                comboBox2.Items.Clear();
                for (int y = 1; y < 31; y++) comboBox2.Items.Add(y.ToString());
            }
            else
            {
                try
                {
                    int a = int.Parse(comboBox1.Text);
                    if (a % 100 == 0)
                    {
                        if (a % 400 == 0)
                        {
                            comboBox2.Items.Clear();
                            for (int y = 1; y < 30; y++) comboBox2.Items.Add(y.ToString());
                        }
                        else
                        {
                            comboBox2.Items.Clear();
                            for (int y = 1; y < 29; y++) comboBox2.Items.Add(y.ToString());
                        }
                    }
                    else
                    {
                        if (a % 4 == 0)
                        {
                            comboBox2.Items.Clear();
                            for (int y = 1; y < 30; y++) comboBox2.Items.Add(y.ToString());
                        }
                        else
                        {
                            comboBox2.Items.Clear();
                            for (int y = 1; y < 29; y++) comboBox2.Items.Add(y.ToString());
                        }
                    }
                }
                catch { }
            }
        }
    }
}
