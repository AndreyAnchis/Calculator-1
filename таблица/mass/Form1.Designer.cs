namespace mass
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonRand = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonMaxSum = new System.Windows.Forms.Button();
            this.labelMaxSum = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол. елем.";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(198, 19);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(93, 22);
            this.buttonCount.TabIndex = 1;
            this.buttonCount.Text = "OK";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(297, 19);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(96, 22);
            this.buttonRand.TabIndex = 2;
            this.buttonRand.Text = "Random";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.ButtonRand_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(85, 21);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(97, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(16, 66);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(376, 126);
            this.dataGridViewTable.TabIndex = 4;
            // 
            // buttonMaxSum
            // 
            this.buttonMaxSum.Enabled = false;
            this.buttonMaxSum.Location = new System.Drawing.Point(18, 214);
            this.buttonMaxSum.Name = "buttonMaxSum";
            this.buttonMaxSum.Size = new System.Drawing.Size(88, 21);
            this.buttonMaxSum.TabIndex = 5;
            this.buttonMaxSum.Text = "MaxSum";
            this.buttonMaxSum.UseVisualStyleBackColor = true;
            this.buttonMaxSum.Click += new System.EventHandler(this.ButtonMaxSum_Click);
            // 
            // labelMaxSum
            // 
            this.labelMaxSum.AutoSize = true;
            this.labelMaxSum.Location = new System.Drawing.Point(139, 216);
            this.labelMaxSum.Name = "labelMaxSum";
            this.labelMaxSum.Size = new System.Drawing.Size(63, 13);
            this.labelMaxSum.TabIndex = 6;
            this.labelMaxSum.Text = "Max Sum = ";
            // 
            // buttonMin
            // 
            this.buttonMin.Enabled = false;
            this.buttonMin.Location = new System.Drawing.Point(18, 241);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(88, 22);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Enabled = false;
            this.buttonMax.Location = new System.Drawing.Point(18, 268);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(88, 23);
            this.buttonMax.TabIndex = 8;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(147, 246);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(36, 13);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "Min = ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(147, 273);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(39, 13);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Max = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 310);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.labelMaxSum);
            this.Controls.Add(this.buttonMaxSum);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonMaxSum;
        private System.Windows.Forms.Label labelMaxSum;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
    }
}

