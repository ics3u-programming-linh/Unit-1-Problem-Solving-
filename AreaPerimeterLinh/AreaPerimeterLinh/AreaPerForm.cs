/*
 * Created by: Linh Ho
 * Created on: September 17th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Area and Perimeter
 * This program...calculates the area and perimeter when users input their length and width.
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

namespace AreaPerimeterLinh
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();

            // hide the perimeter and answer labels until the user clicks on the calculate button
            this.lblPerimeter.Hide();
            this.lblPerimeterAnswer.Hide();
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
        }

        private void LblLength_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, perimeter, area;

            // convert the string fro each text box to a double 
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtLength.Text);

            // calculate the area and the perimeter
            area = length * width;
            perimeter = length + length + width + width;

            // insert the area and the perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters ";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " meters ";

            // display the perimeter and area labels with their respective answers
            this.lblPerimeter.Show();
            this.lblPerimeterAnswer.Show();
            this.lblArea.Show();
            this.lblAreaAnswer.Show();

        }
    }
}
