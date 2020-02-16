using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab1_3
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
        private void execButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            List<String> numbers = new List<string>();
            foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
            {
                if (Validation.isInputValid(textBox.Text))
                {
                    numbers.Add(textBox.Text);
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                var count = Logic.FilterNumbers(numbers).Count;
                result.Text = count.ToString();
                if (count == 0)
                {
                    MessageBox.Show("Числа, удовлетворяющие критериям, отсутствуют");
                }
            }
            else
            {
                result.Text = "0";
            }
        }
        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Form form = Form.ActiveForm;
            form.Close();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
