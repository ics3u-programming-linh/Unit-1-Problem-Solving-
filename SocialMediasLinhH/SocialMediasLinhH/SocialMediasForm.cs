/*
 * Created by: Linh Ho
 * Created on: September 16th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Social Medias
 * This program displays a social media, user count
 * and an image of their logo
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

namespace SocialMediasLinhH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GrbSocialMedias_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MniInstagram_Click(object sender, EventArgs e)
        {
            // Change text to Instagram
            lblSocialMedia.Text = "Instagram";

            // Change the amount of users
            lblUsers.Text = "800 Million";

            // Change the font
            lblSocialMedia.Font = new Font("Impact", 40);

            // Change the position of Instagram
            lblSocialMedia.Location = new Point(94,65);

            // Change the background image to Instagram
            picSocialMedia.Image = Properties.Resources.Instagram;
        }

        private void MniSnapchat_Click(object sender, EventArgs e)
        {
            // Change text to Snapchat
            lblSocialMedia.Text = "Snapchat";

            // Change the amount of users
            lblUsers.Text = "188 Million";

            // Change the font
            lblSocialMedia.Font = new Font("MV Boli", 40);

            // Change the position of Snapchat
            lblSocialMedia.Location = new Point(94, 65);

            // Change the background image to Snapchat
            picSocialMedia.Image = Properties.Resources.Snapchat;
        }

        private void MniFacebook_Click(object sender, EventArgs e)
        {
            // Change text to Facebook
            lblSocialMedia.Text = "Facebook";

            // Change the amount of users
            lblUsers.Text = "360 Million";

            // Change the font
            lblSocialMedia.Font = new Font("Arial", 40);

            // Change the position of Facebook
            lblSocialMedia.Location = new Point(94, 65);

            // Change the background image to Facebook
            picSocialMedia.Image = Properties.Resources.facebook;
        }

        private void MniTwitter_Click(object sender, EventArgs e)
        {
            // Change text to Twitter
            lblSocialMedia.Text = "Twitter";

            // Change the amount of users
            lblUsers.Text = "321 Million";

            // Change the font
            lblSocialMedia.Font = new Font("Sitka Text", 40);

            // Change the position of Twitter
            lblSocialMedia.Location = new Point(94, 65);

            // Change the background image to Twitter
            picSocialMedia.Image = Properties.Resources.twitter;
        }
    }
}
