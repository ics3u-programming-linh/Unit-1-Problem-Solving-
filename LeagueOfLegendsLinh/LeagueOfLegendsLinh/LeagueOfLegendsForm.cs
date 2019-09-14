using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsLinh
{
    public partial class frmLeagueOfLegends : Form
    {
        public frmLeagueOfLegends()
        {
            InitializeComponent();
        }

        private void FrmLeagueOfLegends_Load(object sender, EventArgs e)
        {

        }

        private void GrbList_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void KaisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the character text to Kaisa
            this.lblCharacter.Text = " Kaisa ";

            // change the type of fighter to Fighter
            this.lblType.Text = " Fighter";

        }

        private void MniGraves_Click(object sender, EventArgs e)
        {
            // change the character text to Graves
            lblCharacter.Text = " Graves ";

            // change the character type of fighter to Melee
            lblType.Text = " Melee ";

            // change the font
            lblCharacter.Font = new Font("Source Sans Pro", 40F);
        }

        private void HecarimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the character text to Hecarim
            this.lblCharacter.Text = " Hecarim ";

            // change the character type of fighter to Melee
            this.lblType.Text = " Melee ";
        }

        private void ViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the character text to Vi
            this.lblCharacter.Text = " Vi ";

            // change the character type of fighter to Fighter
            this.lblType.Text = " Ranged ";
        }
    }
}
