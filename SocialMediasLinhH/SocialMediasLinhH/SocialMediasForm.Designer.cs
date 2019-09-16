namespace SocialMediasLinhH
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniSocialMedias = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInstagram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSnapchat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFacebook = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTwitter = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSocialMedias = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblSocialMedia = new System.Windows.Forms.Label();
            this.grbSocialMedias = new System.Windows.Forms.GroupBox();
            this.picSocialMedia = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grbSocialMedias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocialMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSocialMedias});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniSocialMedias
            // 
            this.mniSocialMedias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniInstagram,
            this.mniSnapchat,
            this.mniFacebook,
            this.mniTwitter});
            this.mniSocialMedias.Name = "mniSocialMedias";
            this.mniSocialMedias.Size = new System.Drawing.Size(91, 20);
            this.mniSocialMedias.Text = "Social Medias";
            // 
            // mniInstagram
            // 
            this.mniInstagram.Name = "mniInstagram";
            this.mniInstagram.Size = new System.Drawing.Size(127, 22);
            this.mniInstagram.Text = "Instagram";
            this.mniInstagram.Click += new System.EventHandler(this.MniInstagram_Click);
            // 
            // mniSnapchat
            // 
            this.mniSnapchat.Name = "mniSnapchat";
            this.mniSnapchat.Size = new System.Drawing.Size(127, 22);
            this.mniSnapchat.Text = "Snapchat";
            this.mniSnapchat.Click += new System.EventHandler(this.MniSnapchat_Click);
            // 
            // mniFacebook
            // 
            this.mniFacebook.Name = "mniFacebook";
            this.mniFacebook.Size = new System.Drawing.Size(127, 22);
            this.mniFacebook.Text = "Facebook";
            this.mniFacebook.Click += new System.EventHandler(this.MniFacebook_Click);
            // 
            // mniTwitter
            // 
            this.mniTwitter.Name = "mniTwitter";
            this.mniTwitter.Size = new System.Drawing.Size(127, 22);
            this.mniTwitter.Text = "Twitter";
            this.mniTwitter.Click += new System.EventHandler(this.MniTwitter_Click);
            // 
            // lblSocialMedias
            // 
            this.lblSocialMedias.AutoSize = true;
            this.lblSocialMedias.Location = new System.Drawing.Point(153, 83);
            this.lblSocialMedias.Name = "lblSocialMedias";
            this.lblSocialMedias.Size = new System.Drawing.Size(0, 13);
            this.lblSocialMedias.TabIndex = 0;
            this.lblSocialMedias.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(166, 138);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(232, 33);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Amount of Users";
            this.lblUsers.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblSocialMedia
            // 
            this.lblSocialMedia.AutoSize = true;
            this.lblSocialMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocialMedia.Location = new System.Drawing.Point(94, 83);
            this.lblSocialMedia.Name = "lblSocialMedia";
            this.lblSocialMedia.Size = new System.Drawing.Size(322, 55);
            this.lblSocialMedia.TabIndex = 2;
            this.lblSocialMedia.Text = "Social Medias";
            this.lblSocialMedia.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // grbSocialMedias
            // 
            this.grbSocialMedias.Controls.Add(this.picSocialMedia);
            this.grbSocialMedias.Controls.Add(this.lblSocialMedia);
            this.grbSocialMedias.Controls.Add(this.lblUsers);
            this.grbSocialMedias.Controls.Add(this.lblSocialMedias);
            this.grbSocialMedias.Location = new System.Drawing.Point(66, 75);
            this.grbSocialMedias.Name = "grbSocialMedias";
            this.grbSocialMedias.Size = new System.Drawing.Size(760, 288);
            this.grbSocialMedias.TabIndex = 1;
            this.grbSocialMedias.TabStop = false;
            this.grbSocialMedias.Text = "Social Platform";
            this.grbSocialMedias.Enter += new System.EventHandler(this.GrbSocialMedias_Enter);
            // 
            // picSocialMedia
            // 
            this.picSocialMedia.Image = global::SocialMediasLinhH.Properties.Resources.dl;
            this.picSocialMedia.Location = new System.Drawing.Point(422, 54);
            this.picSocialMedia.Name = "picSocialMedia";
            this.picSocialMedia.Size = new System.Drawing.Size(286, 168);
            this.picSocialMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSocialMedia.TabIndex = 3;
            this.picSocialMedia.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSocialMedias);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Social Medias by Linh H";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbSocialMedias.ResumeLayout(false);
            this.grbSocialMedias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSocialMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniSocialMedias;
        private System.Windows.Forms.ToolStripMenuItem mniInstagram;
        private System.Windows.Forms.ToolStripMenuItem mniSnapchat;
        private System.Windows.Forms.ToolStripMenuItem mniFacebook;
        private System.Windows.Forms.ToolStripMenuItem mniTwitter;
        private System.Windows.Forms.Label lblSocialMedias;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblSocialMedia;
        private System.Windows.Forms.GroupBox grbSocialMedias;
        private System.Windows.Forms.PictureBox picSocialMedia;
    }
}

