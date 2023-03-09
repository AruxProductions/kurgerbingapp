using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waltuh
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }
        Point lastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bk.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
