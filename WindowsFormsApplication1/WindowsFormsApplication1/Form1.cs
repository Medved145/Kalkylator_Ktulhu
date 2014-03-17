using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
      public static double k=0, n1=0, e1=0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Калькулятор";
         }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button1.Text;
            }
            else
            {
                textBox1.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button2.Text;
            }
            else
            {
                textBox1.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button3.Text;
            }
            else
            {
                textBox1.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button4.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = string.Empty;
            label3.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button9.Text;
            }
            else
            {
                textBox1.Text += button9.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button16.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button12.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button8.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double x, y, otv;
            string x1 = textBox1.Text, y1 = textBox2.Text;
            switch (label1.Text)
            {
                case "+":
                    double.TryParse(x1, out x);//перевод данных в строке из char в переменную double;
                    double.TryParse(y1, out y);
                    otv = x + y;
                    label3.Text = otv.ToString();
                    break;
                case "-":
                    double.TryParse(x1, out x);
                    double.TryParse(y1, out y);
                    otv = x - y;
                    label3.Text = otv.ToString();
                    break;
                case "*":
                    double.TryParse(x1, out x);
                    double.TryParse(y1, out y);
                    otv = x * y;
                    label3.Text = otv.ToString();
                    break;
                case "/":
                    double.TryParse(x1, out x);
                    double.TryParse(y1, out y);
                    otv = x / y;
                    label3.Text = otv.ToString();
                    break;
                case "sin":
                    double.TryParse(x1, out y);
                    x = y * Math.PI / 180;
                    otv = Math.Sin(x);
                    label3.Text = otv.ToString();
                    break;
                case "cos":
                    double.TryParse(x1, out y);
                    x = y * Math.PI / 180;
                    otv = Math.Cos(x);
                    label3.Text = otv.ToString();
                    break;
                case "^":
                    double.TryParse(x1, out x);
                    double.TryParse(y1, out y);
                    otv = Math.Pow(x, y);
                    label3.Text = otv.ToString();
                    break;
                case "√":
                    double.TryParse(x1, out x);
                    double.TryParse(y1, out y);
                    double g = 1.0d / y;
                    otv = Math.Pow(x, g);
                    label3.Text = otv.ToString();
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
                label1.Text = button22.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button13.Text;
            }
            else
            {
                textBox1.Text += button13.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button10.Text;
            }
            else
            {
                textBox1.Text += button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button11.Text;
            }
            else
            {
                textBox1.Text += button11.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button5.Text;
            }
            else
            {
                textBox1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button6.Text;
            }
            else
            {
                textBox1.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button7.Text;
            }
            else
            {
                textBox1.Text += button7.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == button16.Text || label1.Text == button12.Text || label1.Text == button8.Text || label1.Text == button4.Text || label1.Text == button21.Text || label1.Text == button22.Text)
            {
                textBox2.Text += button15.Text;
            }
            else
            {
                textBox1.Text += button15.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) ;
            else
            {
                if (textBox2.Text == string.Empty && label1.Text != string.Empty)
                {
                    label1.Text = string.Empty;
                    label3.Text = string.Empty;
                }
                else
                {
                    if (label1.Text == string.Empty)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        label3.Text = string.Empty;
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                        label3.Text = string.Empty;
                    }

                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор версии 0.6.3.\nНаписанный на языке C#.\n\n\n©Пархоменко А. Все права защищены.", "О программе");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out k);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out n1);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double.TryParse(label3.Text, out e1);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label1.Text != string.Empty)
                textBox2.Text = k.ToString();
            else
                textBox1.Text = k.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (label1.Text != string.Empty)
                textBox2.Text = n1.ToString();
            else
                textBox1.Text = n1.ToString(); ;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (label1.Text != string.Empty)
                textBox2.Text = e1.ToString();
            else
                textBox1.Text = e1.ToString();
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mm = k.ToString();
            string mn = n1.ToString();
            string nn = e1.ToString();
            System.IO.File.WriteAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be1.txt", mm);
            System.IO.File.WriteAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be2.txt", mn);
            System.IO.File.WriteAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be3.txt", nn);
        }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mm = System.IO.File.ReadAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be1.txt");
            string mn = System.IO.File.ReadAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be2.txt");
            string nn = System.IO.File.ReadAllText(@"C:\Users\dns\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\SaveData\Be3.txt");
            double.TryParse(mm, out k);
            double.TryParse(mn, out n1);
            double.TryParse(nn, out e1);
        }
    }
}
