using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        string option = string.Empty;
        double inOne = 0;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out inOne);
            result = inOne / .79 ;
            textBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out inOne);
            result = (inOne * 1.8) + 32;
            textBox2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out inOne);
            result = inOne / 12;
            textBox2.Text = result.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
