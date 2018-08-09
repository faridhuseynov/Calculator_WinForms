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
        List<string> number = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            var btn=sender as Button;
            number.Add(btn.Text);
            textBox.Text=number.;
            textBox.Show();
        }

       
    }
}
