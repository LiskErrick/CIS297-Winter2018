namespace Project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            this.deductionButton = new System.Windows.Forms.Button();
            this.deductionsLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.taxDisplayLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(324, 150);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(463, 31);
            this.incomeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter an income from W2";
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(838, 145);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(162, 71);
            this.addIncomeButton.TabIndex = 2;
            this.addIncomeButton.Text = "Add Income to Total";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Location = new System.Drawing.Point(1048, 153);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(171, 25);
            this.totalIncomeLabel.TabIndex = 3;
            this.totalIncomeLabel.Text = "Total Income: $0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a deduction";
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.Location = new System.Drawing.Point(324, 278);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.Size = new System.Drawing.Size(463, 31);
            this.deductionTextBox.TabIndex = 5;
            // 
            // deductionButton
            // 
            this.deductionButton.Location = new System.Drawing.Point(838, 267);
            this.deductionButton.Name = "deductionButton";
            this.deductionButton.Size = new System.Drawing.Size(162, 71);
            this.deductionButton.TabIndex = 6;
            this.deductionButton.Text = "Add Income to Total";
            this.deductionButton.UseVisualStyleBackColor = true;
            this.deductionButton.Click += new System.EventHandler(this.deductionButton_Click);
            // 
            // deductionsLabel
            // 
            this.deductionsLabel.AutoSize = true;
            this.deductionsLabel.Location = new System.Drawing.Point(1048, 278);
            this.deductionsLabel.Name = "deductionsLabel";
            this.deductionsLabel.Size = new System.Drawing.Size(210, 25);
            this.deductionsLabel.TabIndex = 7;
            this.deductionsLabel.Text = "Total Deductions: $0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(324, 381);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(444, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Check to use standard deduction $12,700";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // taxDisplayLabel
            // 
            this.taxDisplayLabel.AutoSize = true;
            this.taxDisplayLabel.Location = new System.Drawing.Point(1492, 156);
            this.taxDisplayLabel.Name = "taxDisplayLabel";
            this.taxDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.taxDisplayLabel.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(445, 522);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(431, 115);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "I owe how much?!?!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1972, 816);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.taxDisplayLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.deductionsLabel);
            this.Controls.Add(this.deductionButton);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalIncomeLabel);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deductionTextBox;
        private System.Windows.Forms.Button deductionButton;
        private System.Windows.Forms.Label deductionsLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label taxDisplayLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

