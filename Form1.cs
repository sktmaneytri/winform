using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // innitialize
            textBox1.Text = "0";
            textBox2.Text = "0";
            OptionBox.SelectedIndex = 0; //choose the first one
            this.ActiveControl = textBox1;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //find the value of box 1 and box 2
            double a, b;
            double t = 0;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            switch(OptionBox.SelectedIndex)
            {
                case 0: t = a + b; break;
                case 1: t = a - b; break;
                case 2: t = a * b; break;
                case 3:  if(b != 0) t = a  / b; break;
            }
            ResultBox.Text = t.ToString();
        }
    }
}
