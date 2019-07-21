using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b, x, c=0;
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            x = Convert.ToDouble(textBoxX.Text);
            c = Class1.RiV(a, b, x);

            textBoxResult.Text = Convert.ToString(c);
                
        }
    }
}
