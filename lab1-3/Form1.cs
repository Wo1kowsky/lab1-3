using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (TextBox textBox in groupBox1.Controls.OfType<TextBox>())
            {
                if (!Validation.IsLengthValid(textBox.Text) && !Validation.IsPositiveInteger(textBox.Text))
                {
                    MessageBox.Show("Invalid input");
                    break;
                }
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
