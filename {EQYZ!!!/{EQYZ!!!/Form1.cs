using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EQYZ___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            z = x + y;
            textBox3.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            z = x - y;
            textBox3.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            z = x * y;
            textBox3.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            z = x / y;
            textBox3.Text = z.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string x1, y1;
            x1 = textBox1.Text;
            y1 = textBox2.Text;
            double.TryParse(x1, out x);
            double.TryParse(y1, out y);
            z = Math.Pow(x, y);
            textBox3.Text = z.ToString();
        }
    }
}
