namespace LeagueOfLegendsLinh
{
    partial class frmLeagueOfLegends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuLeagueOfLegends = new System.Windows.Forms.MenuStrip();
            this.mniLeagueOfLegends = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGraves = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHecarim = new System.Windows.Forms.ToolStripMenuItem();
            this.mniVi = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKaisa = new System.Windows.Forms.ToolStripMenuItem();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.mnuLeagueOfLegends.SuspendLayout();
            this.grbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuLeagueOfLegends
            // 
            this.mnuLeagueOfLegends.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLeagueOfLegends});
            this.mnuLeagueOfLegends.Location = new System.Drawing.Point(0, 0);
            this.mnuLeagueOfLegends.Name = "mnuLeagueOfLegends";
            this.mnuLeagueOfLegends.Size = new System.Drawing.Size(800, 24);
            this.mnuLeagueOfLegends.TabIndex = 0;
            this.mnuLeagueOfLegends.Text = "League of Legends";
            // 
            // mniLeagueOfLegends
            // 
            this.mniLeagueOfLegends.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGraves,
            this.mniKaisa,
            this.mniHecarim,
            this.mniVi});
            this.mniLeagueOfLegends.Name = "mniLeagueOfLegends";
            this.mniLeagueOfLegends.Size = new System.Drawing.Size(118, 20);
            this.mniLeagueOfLegends.Text = "League of Legends";
            // 
            // mniGraves
            // 
            this.mniGraves.Name = "mniGraves";
            this.mniGraves.Size = new System.Drawing.Size(180, 22);
            this.mniGraves.Text = "Graves";
            this.mniGraves.Click += new System.EventHandler(this.MniGraves_Click);
            // 
            // mniHecarim
            // 
            this.mniHecarim.Name = "mniHecarim";
            this.mniHecarim.Size = new System.Drawing.Size(180, 22);
            this.mniHecarim.Text = "Hecarim";
            this.mniHecarim.Click += new System.EventHandler(this.HecarimToolStripMenuItem_Click);
            // 
            // mniVi
            // 
            this.mniVi.Name = "mniVi";
            this.mniVi.Size = new System.Drawing.Size(180, 22);
            this.mniVi.Text = "Vi";
            this.mniVi.Click += new System.EventHandler(this.ViToolStripMenuItem_Click);
            // 
            // mniKaisa
            // 
            this.mniKaisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mniKaisa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniKaisa.Name = "mniKaisa";
            this.mniKaisa.Size = new System.Drawing.Size(180, 22);
            this.mniKaisa.Text = "Kaisa";
            this.mniKaisa.Click += new System.EventHandler(this.KaisaToolStripMenuItem_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.lblType);
            this.grbList.Controls.Add(this.lblCharacter);
            this.grbList.Location = new System.Drawing.Point(45, 107);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(408, 243);
            this.grbList.TabIndex = 1;
            this.grbList.TabStop = false;
            this.grbList.Text = "Favourites";
            this.grbList.Enter += new System.EventHandler(this.GrbList_Enter);
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("RomanT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(26, 46);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(310, 91);
            this.lblCharacter.TabIndex = 2;
            this.lblCharacter.Text = "Graves";
            this.lblCharacter.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(47, 137);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(163, 57);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Melee";
            this.lblType.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // frmLeagueOfLegends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.mnuLeagueOfLegends);
            this.MainMenuStrip = this.mnuLeagueOfLegends;
            this.Name = "frmLeagueOfLegends";
            this.Text = "League of Legends by Linh H";
            this.Load += new System.EventHandler(this.FrmLeagueOfLegends_Load);
            this.mnuLeagueOfLegends.ResumeLayout(false);
            this.mnuLeagueOfLegends.PerformLayout();
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuLeagueOfLegends;
        private System.Windows.Forms.ToolStripMenuItem mniLeagueOfLegends;
        private System.Windows.Forms.ToolStripMenuItem mniGraves;
        private System.Windows.Forms.ToolStripMenuItem mniKaisa;
        private System.Windows.Forms.ToolStripMenuItem mniHecarim;
        private System.Windows.Forms.ToolStripMenuItem mniVi;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblType;
    }
}

