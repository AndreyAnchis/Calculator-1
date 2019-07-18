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

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Solve_Click(object sender, EventArgs e)
        {
            double a, b, c, d=0;
            double x1=0, x2=0;
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);
            d = MathLib.Class1.SCR(b, 2) - 4 * a * c;
            Discrim.Text = Convert.ToString(d);
            if (d > 0)
            {
                x1 = (-b + MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                x2 = (-b - MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                textBoxX1.Text = Convert.ToString(x1);
                textBoxX2.Text = Convert.ToString(x2);
                labelX1.Visible = true;
                textBoxX1.Visible = true;
                labelX2.Visible = true;
                textBoxX2.Visible = true;
            }
            else if (d == 0)
            {
                x1 = (-b + MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                textBoxX1.Text = Convert.ToString(x1);
                labelX1.Visible = true;
                textBoxX1.Visible = true;

            }
            else if (d < 0) {
                MessageBox.Show("Вы испугали деда");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelX1.Visible = false;
            textBoxX1.Visible = false;
            labelX2.Visible = false;
            textBoxX2.Visible = false;
        }
    }
}
