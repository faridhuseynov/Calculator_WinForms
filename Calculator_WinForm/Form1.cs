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
            if (_operator.Length > 1)
            {
                string num = number.ToString(); ;
                if (_operator[0].ToString() == "+")
                    result += Int32.Parse(num);
                else if (_operator[0].ToString() == "-")
                    result -= Int32.Parse(num);
                else if (_operator[0].ToString() == "*")
                    result *= Int32.Parse(num);
                else if (_operator[0].ToString() == "/")
                {
                    if (num != "0")
                        result /= Int32.Parse(num);
                    else
                    {
                        textBox.Text = "Division to 0 is prohibited!";
                        textBox.Show();
                        textBox.Text.Remove(0);
                        _operator.Clear();
                    }
                }
                _operator.Remove(0, 1);
            }
            _operator.Append(btn.Text);
            number.Clear();
        }
        private void OnEqualClick(object sender, EventArgs e)
        {
            string num = number.ToString(); ;
            if (_operator[0].ToString() == "+")
                result += Int32.Parse(num);
            else if (_operator[0].ToString() == "-")
                result -= Int32.Parse(num);
            else if (_operator[0].ToString() == "*")
                result *= Int32.Parse(num);
            else if (_operator[0].ToString() == "/")
            {
                if (num != "0")
                    result /= Int32.Parse(num);
                else
                {
                    textBox.Text = "Division to 0 is prohibited!";
                    textBox.Show();
                    textBox.Text.Remove(0);
                    _operator.Clear();
                }
            }
            _operator.Remove(0, 1);
            number.Clear();
            textBox.Text = result.ToString();
            textBox.Show();
        }
    }
}
