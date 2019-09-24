/*
 * Created by: Linh Ho
 * Created on: September 24th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pizza Cost
 * This program calculates the price of a pizza including all the hidden fees,
 * and displays the before and after tax
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostLinhH
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            
            InitializeComponent();
            picPizza.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, costBeforeTax, costAfterTax;

            // convert the diamter to a double
            diameter = double.Parse(txtDiameter.Text);

            // calculate the cost before and after tax

            costBeforeTax = (0.75 + 0.99 + 0.5 * diameter);

            costAfterTax = (0.75 + 0.99 + 0.5 * diameter) * 1.13;

            // display the cost in the label, rounded to 2 decimal places
            lblCostAnswer.Text = String.Format("${0:0.00}", costAfterTax);

            lblCostAnswer2.Text = String.Format("${0:0.00}", costBeforeTax);


        }
    }
}
