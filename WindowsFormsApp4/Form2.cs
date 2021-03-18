using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*)|*.*|iMAGE Files(*.bmp; *.png; *.jpg)| *.bmp; *.png; *.jpg";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {
                    guna2TextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.Title = "Select picture";
            picture.Filter = "JPG Files(' *.jpg ')|*.*|PNG Files(*.png)| *.png||";
            if (picture.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(picture.FileName))
                {
                    guna2CirclePictureBox1.Load( picture.FileName);
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(guna2TextBox1);
                }
            }
        }
    }
}
