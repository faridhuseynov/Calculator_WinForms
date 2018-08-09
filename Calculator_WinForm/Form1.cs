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
            var btn=sender as Button;
            number.Append(btn.Text);
            textBox.Text += btn.Text;
            textBox.Show();
        }

        private void OnOperatorClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (_operator.Length != 0)
                _operator.Clear();
            _operator.Append(btn.Text);

            number.Clear();
        }
    }
}
