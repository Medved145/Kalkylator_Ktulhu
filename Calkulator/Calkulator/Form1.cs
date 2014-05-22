using System;
using System.Linq;
using System.Windows.Forms;
using Calkulator.BinaryOperations;
using Calkulator.SingleOperations;
using Calkulator.SortingOperations;

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
            try
            {
                double first = Convert.ToDouble(textBox1.Text); 
                double second = Convert.ToDouble(textBox2.Text);
                IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation(((Button) sender).Text);
                textBox3.Text = calculator.Calculate(first, second).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SingleCalculate(object sender, EventArgs e)
        {
            try
            {
                double first=Convert.ToDouble(textBox1.Text);
                ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation(((Button) sender).Text);
                textBox3.Text = calculator.Calculate(first).ToString() + "°";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SortingSort(object sender, EventArgs e)
        {
            try
            {
                string[] mass = textBox1.Text.Split(' ');
                int[] array = mass.Select(m => Convert.ToInt32(m)).ToArray();
                ISortingOperation sort = SortingOperationFactory.CreateSortingOperation(((Button) sender).Text);
                textBox3.Text = string.Join(" ", sort.Sort(array));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

    }
}
