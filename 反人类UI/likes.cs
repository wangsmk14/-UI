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
    public partial class likes : Form
    {
        public likes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void likes_Load(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            byte a = 0;
            if (checkBox1.Checked == true) a++;
            if (checkBox2.Checked == true) a++;
            if (checkBox3.Checked == true) a++;
            if (checkBox4.Checked == true) a++;
            if (checkBox5.Checked == true) a++;
            if (checkBox6.Checked == true) a++;
            if (checkBox7.Checked == true) a++;
            if (checkBox8.Checked == true) a++;
            if (checkBox10.Checked == true) a++;
            if (checkBox11.Checked == true) a++;
            if (checkBox12.Checked == true) a++;
            if (checkBox13.Checked == true) a++;
            if (checkBox14.Checked == true) a++;
            if (checkBox15.Checked == true) a++;
            if (checkBox16.Checked == true) a++;
            if (checkBox17.Checked == true) a++;
            if (checkBox18.Checked == true) a++;
            if (checkBox19.Checked == true) a++;
            if (checkBox20.Checked == true) a++;
            if (checkBox22.Checked == true) a++;
            if (checkBox23.Checked == true) a++;
            if (checkBox24.Checked == true) a++;
            if (checkBox25.Checked == true) a++;
            if (checkBox26.Checked == true) a++;
            if (checkBox27.Checked == true) a++;
            if (checkBox28.Checked == true) a++;
            if (checkBox29.Checked == true) a++;
            if (checkBox30.Checked == true) a++;
            //分隔
            if (a == 3)
            {
                nr f4 = new nr();
                f4.Show();
                this.Close();
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Title = "请选择你的头像";
            op.Filter = "图像文件(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(op.FileName);
                Image image = Image.FromFile(path, true);
                ImageList il = new ImageList();
                il.Images.Add(image);
                button1.Image=il.Images[0];
            }
        }


    }
}
