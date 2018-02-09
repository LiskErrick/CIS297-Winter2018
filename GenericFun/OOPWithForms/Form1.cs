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

        ActuallyRandom random;
        private int tickets;
        public Form1()
        {
            InitializeComponent();
            tickets = 0;
            random = new ActuallyRandom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checks to see if the sender that triggered the event is a control
            if ( sender == button2 )
            {
                // basically a Try Cast
                Button button = sender as Button;
                // if it didn't cast, we get null
                if ( button != null )
                {
                    button.Text = "You clicked me";
                }

                MessageBox.Show("YOU DID IT!");
                button1.Enabled = true;
                tickets = 0;
            }

            else
            {
                var numbersString = numbersTextBox.Text;

                var numbersSplit = numbersString.Split();

                if (numbersSplit.Length != 6)
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
                    tickets++;

                    if (tickets == 3)
                    {
                        button1.Enabled = false;
                    }

                }

            }

        }

        private void randomTicketButton_Click(object sender, EventArgs e)
        {
            var myTicket = new PowerBallTicket(random);

            myTicketLabel.Text = myTicket.ToString();
            tickets++;
        }
    }
}
