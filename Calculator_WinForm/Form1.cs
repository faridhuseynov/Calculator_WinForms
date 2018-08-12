using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        bool firstentry = false;
        StringBuilder number = new StringBuilder();
        StringBuilder _operator = new StringBuilder();
        int result = 0;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            number.Append(btn.Text);
            textBox.Text += btn.Text;
            textBox.Show();
        }
        private void CalculationFunction(int num, string operate)
        {
            if (operate == "+")
                result += num;
            else if (operate == "-")
                result -= num;
            else if (operate == "*")
                result *= num;
            else if (operate == "/")
            {
                if (num != 0)
                    result /= num;
                else
                {
                    textBox.Text = "Division to 0 is prohibited!";
                    textBox.Show();
                    textBox.Text.Remove(0);
                    _operator.Clear();
                    return;
                }
            }
            _operator.Remove(0, 1);
        }
        private void OnOperatorClick(object sender, EventArgs e)
        {
            if (firstentry == false)
            {
                if (textBox.Text != "")
                    result = Int32.Parse(textBox.Text);
                firstentry = true;
            }
            var btn = sender as Button;
            textBox.Text += btn.Text;
            textBox.Show();
            _operator.Append(btn.Text);
            if (_operator.Length > 1)
                CalculationFunction(Int32.Parse(number.ToString()), _operator[0].ToString());
            number.Clear();
        }
        private void OnEqualClick(object sender, EventArgs e)
        {
            CalculationFunction(Int32.Parse(number.ToString()), _operator[0].ToString());
            number.Clear();
            textBox.Text = result.ToString();
            textBox.Show();
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            result = 0;
            firstentry = false;
            textBox.Text=textBox.Text.Remove(0);
            textBox.Show();
        }
        private void OnBackspaceClick(object sender, EventArgs e)
        {
            textBox.Text=textBox.Text.Remove(textBox.TextLength-1);
            number.Remove(number.Length - 1, 1);
            textBox.Show();
        }
    }
}
