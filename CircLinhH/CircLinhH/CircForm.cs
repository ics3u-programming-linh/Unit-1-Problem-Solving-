/*
 * Created by: Linh Ho
 * Created on: September 19th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference of a Circle
 * This program...calculates the circumference of a circle
 * using the given input from the user entered in the 
 * textbox
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

namespace CircLinhH
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();

            // hide the circumference labels
            this.lblStateCircumference.Hide();
            this.lblCircumferenceAnswer.Hide();
        }

        private void FrmCirc_Load(object sender, EventArgs e)
        {

        }

        private void LblRadius_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring constants
            const double PI = 3.14;

            // declaring variables
            double circumference, radius;


            // convert the string from each text box to a double 
            radius = double.Parse(txtRadius.Text);

            // calculate the radius of the circle
            circumference = 2 * PI * radius;


            // insert the circumference into their respective answers
            this.lblCircumferenceAnswer.Text = Convert.ToString(circumference) + " cm ";

            // display the circumference labels
            this.lblCircumferenceAnswer.Show();
            this.lblStateCircumference.Show();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
