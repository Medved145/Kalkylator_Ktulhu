using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calkulator.BinaryOperations;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BinaryCalculate(object sender, EventArgs e)
        {
            double first, second;
            double.TryParse(textBox1.Text, out first);
            double.TryParse(textBox2.Text, out second);
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation(((Button)sender).Text);
            textBox3.Text = calculator.Calculate(first, second);
        }
    }
}
