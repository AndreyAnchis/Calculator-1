using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        
            {
                int n;
                if (int.TryParse(textBoxCount.Text, out n))
                {
                    dataGridViewTable.ColumnCount = n;
                    dataGridViewTable.RowCount = 1;
                    for (int i = 0; i < n; i++)
                    {
                        dataGridViewTable.Columns[i].HeaderText = i.ToString();
                        dataGridViewTable.Columns[i].Width = 40;
                    }
                    buttonMaxSum.Enabled = true;
                    buttonMin.Enabled = true;
                    buttonMax.Enabled = true;
                }
                else
                MessageBox.Show("Неправильное кол елементов");
        }

        private void ButtonRand_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < dataGridViewTable.ColumnCount; i++)
             dataGridViewTable[i, 0].Value = random.Next(-20, 20);
             dataGridViewTable.ClearSelection();
             labelMaxSum.Visible = false;
             labelMin.Visible = false;
             labelMax.Visible = false;
        }

        private void ButtonMaxSum_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewTable.ColumnCount];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = int.Parse(dataGridViewTable[i, 0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int summa = int.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] + arr[i + 1] > summa)
                {
                    summa = arr[i] + arr[i + 1];
                    index = i;
                }
            dataGridViewTable.ClearSelection();
            dataGridViewTable[index, 0].Selected = true;
            dataGridViewTable[index + 1, 0].Selected = true;
            labelMaxSum.Text = "Максимальна сума сусідніх елементів = " + summa.ToString();
            labelMaxSum.Visible = true;
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            int indexmin = 0;
            for (int i = 0; i < dataGridViewTable.ColumnCount; i++)
            {
                if (min > Convert.ToInt32(dataGridViewTable[i, 0].Value))
                {
                    min = Convert.ToInt32(dataGridViewTable[i, 0].Value);
                    indexmin = i;
                }
            }
            dataGridViewTable.ClearSelection();
            dataGridViewTable[indexmin, 0].Selected = true;
            labelMin.Text = "Мінімальне значення = " + min.ToString();
            labelMin.Visible = true;
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            int indexmax = 0;
            for (int i = 0; i < dataGridViewTable.ColumnCount; i++)
            {
                if (max < Convert.ToInt32(dataGridViewTable[i, 0].Value))
                {
                    max = Convert.ToInt32(dataGridViewTable[i, 0].Value);
                        indexmax = i;
                }
            }
            dataGridViewTable.ClearSelection();
            dataGridViewTable[indexmax, 0].Selected = true;
            labelMax.Text = "Максимальне значення = " + max.ToString();
            labelMax.Visible = true;
        }
    }
}
