using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPWithForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numbersString = numbersTextBox.Text;

            var numbersSplit = numbersString.Split();

            if ( numbersSplit.Length != 6 )
            {
                myTicketLabel.Text = "Please enter 6 numbers separated by spaces";
            }
            else
            {
                int[] numbers = new int[6];

                for (int index = 0; index < numbersSplit.Length; index++)
                {
                    numbers[index] = Int32.Parse(numbersSplit[index]);
                }

                var myTicket = new PowerBallTicket(numbers);

                myTicketLabel.Text = myTicket.ToString();
            }
            
        }
    }
}
