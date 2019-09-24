namespace PizzaCostLinhH
{
    partial class frmPizzaCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaCost));
            this.lblDiameter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostAnswer = new System.Windows.Forms.Label();
            this.lblCost2 = new System.Windows.Forms.Label();
            this.lblCostAnswer2 = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(63, 125);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(522, 31);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches):";
            this.lblDiameter.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(241, 195);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(239, 54);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiameter.Location = new System.Drawing.Point(591, 128);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(123, 31);
            this.txtDiameter.TabIndex = 2;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(88, 350);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(270, 25);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "The cost (including tax) is: ";
            // 
            // lblCostAnswer
            // 
            this.lblCostAnswer.AutoSize = true;
            this.lblCostAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAnswer.Location = new System.Drawing.Point(364, 350);
            this.lblCostAnswer.Name = "lblCostAnswer";
            this.lblCostAnswer.Size = new System.Drawing.Size(24, 25);
            this.lblCostAnswer.TabIndex = 4;
            this.lblCostAnswer.Text = "?";
            // 
            // lblCost2
            // 
            this.lblCost2.AutoSize = true;
            this.lblCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost2.Location = new System.Drawing.Point(88, 302);
            this.lblCost2.Name = "lblCost2";
            this.lblCost2.Size = new System.Drawing.Size(306, 25);
            this.lblCost2.TabIndex = 5;
            this.lblCost2.Text = "The cost (not including tax) is: ";
            // 
            // lblCostAnswer2
            // 
            this.lblCostAnswer2.AutoSize = true;
            this.lblCostAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAnswer2.Location = new System.Drawing.Point(400, 302);
            this.lblCostAnswer2.Name = "lblCostAnswer2";
            this.lblCostAnswer2.Size = new System.Drawing.Size(24, 25);
            this.lblCostAnswer2.TabIndex = 6;
            this.lblCostAnswer2.Text = "?";
            // 
            // picPizza
            // 
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(522, 195);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(225, 221);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 7;
            this.picPizza.TabStop = false;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.lblCostAnswer2);
            this.Controls.Add(this.lblCost2);
            this.Controls.Add(this.lblCostAnswer);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by Linh H";
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostAnswer;
        private System.Windows.Forms.Label lblCost2;
        private System.Windows.Forms.Label lblCostAnswer2;
        private System.Windows.Forms.PictureBox picPizza;
    }
}

