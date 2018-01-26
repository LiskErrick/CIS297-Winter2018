using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWIndowsForm
{
    public partial class Form1 : Form
    {
        private int result;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            result = 2;
            random = new Random();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            HandleButtonOrEnter();
        }

        private void HandleButtonOrEnter()
        {
            string answer = answerBox.Text;


            // old way
            // int answerAsInt = Int32.Parse(answer);

            int answerAsInt;

            // out answerAsInt will set the value of answerAsInt for use inside the block
            if ( Int32.TryParse(answer, out answerAsInt) )
            {
                if (answerAsInt == result)
                {
                    rightOrWrongLabel.Text = "Correct!";
                    int firstNumber = random.Next(20);
                    int secondNumber = random.Next(20);
                    result = firstNumber + secondNumber;
                    questionLabel.Text = $"{firstNumber} + {secondNumber}"
                        + " = ?";

                    // could also do
                    //questionLabel.Text = firstNumber.ToString() + " + " + secondNumber.ToString()
                    //    + " = ?";

                    // blank out the answer box
                    answerBox.Text = string.Empty;

                    // brings the cursor back to the answerBox so I can type
                    answerBox.Focus();
                }
                else
                {
                    rightOrWrongLabel.Text = "Wrong! Try again!";
                }

            }
            else
            {
                rightOrWrongLabel.Text = "Please enter a valid number";
                answerBox.Text = string.Empty;
            }
            
        }

        private void answerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://stackoverflow.com/questions/3558814/net-textbox-handling-the-enter-key
            if (e.KeyChar == (char)Keys.Return)
            {
                HandleButtonOrEnter();
            }
        }
    }
}
