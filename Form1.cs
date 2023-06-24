using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imageviewer
{
    public partial class Form1 : Form
    {
        int p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[0]);
                p = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p < openFileDialog1.FileNames.Length - 1)
            {
                p++;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[p]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p > 0)//ax aval nabashim
            {
                p--;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[p]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = openFileDialog1.FileNames.Length - 1;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[p]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[0]);
            p = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
