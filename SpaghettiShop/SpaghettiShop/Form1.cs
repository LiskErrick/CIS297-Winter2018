using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaghettiShop
{
    public partial class Form1 : Form
    {
        private double pastaCost;
        private double sauceCost;
        private double otherCost;

        public Form1()
        {
            InitializeComponent();
            pastaCost = 0;
            sauceCost = 0;
            otherCost = 0;
        }

        private void updatePriceLabel(object sender, EventArgs e)
        {
            otherCost = 0;
            if (spaghettiButton.Checked)
            {
                pastaCost = 3;
            }
            else if (mostaccioliButton.Checked)
            {
                pastaCost = 3.5;
            }
            else if ( AngelHairButton.Checked )
            {
                pastaCost = 2.5;
            }

            if ( houseRedButton.Checked )
            {
                sauceCost = 1;
            }
            else if ( squidInkButton.Checked )
            {
                sauceCost = 5;
            }
            else if ( meatballButton.Checked )
            {
                sauceCost = 2;
            }
            else if ( alfredoButton.Checked)
            {
                sauceCost = 1.5;
            }

            if (garlicButton.Checked)
            {
                otherCost += .50;
            }

            if (chickenButton.Checked)
            {
                otherCost += 1;
            }
     
            if (meatballButton.Checked)
            {
                otherCost += 2;
            }
        
            if (shrimpButton.Checked)
            {
                otherCost += 3;
            }

            totalLabel.Text = $"Total Cost: ${pastaCost+sauceCost+otherCost}";
        }
    }
}
