using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            c = 2.4 * MathLib.Class1.MOD((MathLib.Class1.SCR(x, 2) + b) / a) +
                (a - b) * MathLib.Class1.SCR(MathLib.Class1.SIN(a - b), 2) +
                MathLib.Class1.SCR(10, -2) * (x - b);
            textBoxResult.Text = Convert.ToString(c);
                
        }
    }
}
