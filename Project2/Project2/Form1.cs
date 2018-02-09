using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        private double grossIncome;
        private double totalDeductions;

        public Form1()
        {
            InitializeComponent();
            grossIncome = 0;
        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            double income = 0;
            if ( Double.TryParse(incomeTextBox.Text, out income) )
            {
                grossIncome += income;
                totalIncomeLabel.Text = $"Total Income: ${grossIncome}";
            }
            else
            {
                incomeTextBox.Text = "PLease enter a valid numeric number";
            }
        }

        private void deductionButton_Click(object sender, EventArgs e)
        {
            double deduction = 0;
            if (Double.TryParse(deductionTextBox.Text, out deduction))
            {
                totalDeductions += deduction;
                UpdateDeductionLabel();
            }
            else
            {
                deductionTextBox.Text = "PLease enter a valid numeric number";
            }
        }

        private void UpdateDeductionLabel()
        {
            deductionsLabel.Text = $"Total Deductions: ${totalDeductions}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked )
            {
                totalDeductions = 12700;
                UpdateDeductionLabel();
            }
            else
            {
                totalDeductions = 0;
                UpdateDeductionLabel();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var taxCalculator = new TaxCalculator(grossIncome, totalDeductions);
            taxDisplayLabel.Text = $"Taxes owed at 10%: ${taxCalculator.TaxesAt10Percent}";
            taxDisplayLabel.Text += $"\nTaxes owed at 15%: ${taxCalculator.TaxesAt15Percent}";
            // keep on copy pasting

        }
    }
}
