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
            double a, b, c, d;
            double x1, x2;
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);

            double k;
            k = Class2.KVRIV(a, b, c, out d, out x1, out x2);

            Discrim.Visible = true;

            if (k == 0) {
                Discrim.Text = Convert.ToString(d);
                MessageBox.Show("Коренів немає");
               
            }
            else if (k == 2) {
                textBoxX1.Text = Convert.ToString(x1);
                textBoxX2.Text = Convert.ToString(x2);
                Discrim.Text = Convert.ToString(d);
                labelX1.Visible = true;
                textBoxX1.Visible = true;
                labelX2.Visible = true;
                textBoxX2.Visible = true;
                
            }
            else if (k == 1) {
                textBoxX1.Text = Convert.ToString(x1);
                Discrim.Text = Convert.ToString(d);
                labelX1.Visible = true;
                textBoxX1.Visible = true;
                labelX2.Visible = false;
                textBoxX2.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelX1.Visible = false;
            textBoxX1.Visible = false;
            labelX2.Visible = false;
            textBoxX2.Visible = false;
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
