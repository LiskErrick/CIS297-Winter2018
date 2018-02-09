using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPWithForms;

namespace GenericFun
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ( stringButton.Checked )
            {
                Sortable<string> items = new Sortable<string>();
                items.Add("Eric");
                items.Add("Chris");
                items.Add("Heba");
                items.Add("Sohil");
                items.Add("Matt");

                label.Text = items.ToString();
            }
            else if ( intsButton.Checked )
            {
                Sortable<int> items = new Sortable<int>();
                items.Add(42);
                items.Add(7);
                items.Add(14);
                items.Add(15);
                items.Add(27);

                label.Text = items.ToString();
            }
            else if ( powerBallButton.Checked )
            {
                Sortable<PowerBallTicket> items = new Sortable<PowerBallTicket>();
                ActuallyRandom random = new ActuallyRandom();
                items.Add(new PowerBallTicket(random));
                items.Add(new PowerBallTicket(random));
                items.Add(new PowerBallTicket(random));
                items.Add(new PowerBallTicket(random));
                items.Add(new PowerBallTicket(random));

                label.Text = items.ToString();
            }
        }
    }
}
