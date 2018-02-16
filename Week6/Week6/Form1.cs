using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6
{
    public partial class Form1 : Form
    {
        FileReader reader;
        public Form1()
        {
            InitializeComponent();
            // use keyword to be able to make a variable use the default
            pickRandom(third: 1, first: 2, fourth: 3);
            reader = new FileReader();
        }

        public int pickRandom(int first = 0, int second = 0, int third = 0, int fourth = 0)
        {
            var random = new Random();
            var index = random.Next(4);
            var numbers = new int[] { first, second, third, fourth };

            return numbers[index];
        }

        public Tuple<int,int> AddAndSubtract( int first, int second)
        {
            return new Tuple<int,int>(first + second, first - second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = reader.ReadFile();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            reader.WriteFile(textBox1.Text);
        }
    }
}
