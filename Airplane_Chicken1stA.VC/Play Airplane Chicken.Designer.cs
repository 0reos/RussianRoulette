namespace Airplane_Chicken1stA.VC
{
    partial class Play_Airplane_Chicken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play_Airplane_Chicken));
            this.btnEnterRunway = new System.Windows.Forms.Button();
            this.rdoEggsRunway = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEggsOnGrass = new System.Windows.Forms.RadioButton();
            this.btnLayEggs = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.lbCountGrass = new System.Windows.Forms.Label();
            this.lbWinScore = new System.Windows.Forms.Label();
            this.lbLossScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWon = new System.Windows.Forms.Label();
            this.lbLost = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterRunway
            // 
            this.btnEnterRunway.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterRunway.Location = new System.Drawing.Point(12, 22);
            this.btnEnterRunway.Name = "btnEnterRunway";
            this.btnEnterRunway.Size = new System.Drawing.Size(125, 51);
            this.btnEnterRunway.TabIndex = 0;
            this.btnEnterRunway.Text = "Enter Runway (Spin chambers)";
            this.btnEnterRunway.UseVisualStyleBackColor = true;
            this.btnEnterRunway.Click += new System.EventHandler(this.btnEnterRunway_Click);
            // 
            // rdoEggsRunway
            // 
            this.rdoEggsRunway.AutoSize = true;
            this.rdoEggsRunway.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEggsRunway.Location = new System.Drawing.Point(16, 24);
            this.rdoEggsRunway.Name = "rdoEggsRunway";
            this.rdoEggsRunway.Size = new System.Drawing.Size(124, 22);
            this.rdoEggsRunway.TabIndex = 1;
            this.rdoEggsRunway.TabStop = true;
            this.rdoEggsRunway.Text = "Eggs on Runway";
            this.rdoEggsRunway.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdoEggsOnGrass);
            this.groupBox1.Controls.Add(this.rdoEggsRunway);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lay";
            // 
            // rdoEggsOnGrass
            // 
            this.rdoEggsOnGrass.AutoSize = true;
            this.rdoEggsOnGrass.Location = new System.Drawing.Point(16, 50);
            this.rdoEggsOnGrass.Name = "rdoEggsOnGrass";
            this.rdoEggsOnGrass.Size = new System.Drawing.Size(109, 22);
            this.rdoEggsOnGrass.TabIndex = 2;
            this.rdoEggsOnGrass.TabStop = true;
            this.rdoEggsOnGrass.Text = "Eggs on Grass";
            this.rdoEggsOnGrass.UseVisualStyleBackColor = true;
            // 
            // btnLayEggs
            // 
            this.btnLayEggs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayEggs.Location = new System.Drawing.Point(12, 177);
            this.btnLayEggs.Name = "btnLayEggs";
            this.btnLayEggs.Size = new System.Drawing.Size(148, 28);
            this.btnLayEggs.TabIndex = 4;
            this.btnLayEggs.Text = "Lay Eggs (Fire)";
            this.btnLayEggs.UseVisualStyleBackColor = true;
            this.btnLayEggs.Click += new System.EventHandler(this.btnLayEggs_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 279);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(104, 46);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again (Reset Game)";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitToMenu.Location = new System.Drawing.Point(12, 331);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(104, 26);
            this.btnExitToMenu.TabIndex = 6;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = true;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // lbCountGrass
            // 
            this.lbCountGrass.AutoSize = true;
            this.lbCountGrass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountGrass.Location = new System.Drawing.Point(13, 158);
            this.lbCountGrass.Name = "lbCountGrass";
            this.lbCountGrass.Size = new System.Drawing.Size(79, 15);
            this.lbCountGrass.TabIndex = 7;
            this.lbCountGrass.Text = "lbCountGrass";
            // 
            // lbWinScore
            // 
            this.lbWinScore.AutoSize = true;
            this.lbWinScore.BackColor = System.Drawing.Color.DarkGray;
            this.lbWinScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWinScore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinScore.Location = new System.Drawing.Point(49, 234);
            this.lbWinScore.Name = "lbWinScore";
            this.lbWinScore.Size = new System.Drawing.Size(2, 17);
            this.lbWinScore.TabIndex = 8;
            // 
            // lbLossScore
            // 
            this.lbLossScore.AutoSize = true;
            this.lbLossScore.BackColor = System.Drawing.Color.DarkGray;
            this.lbLossScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLossScore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLossScore.Location = new System.Drawing.Point(49, 255);
            this.lbLossScore.Name = "lbLossScore";
            this.lbLossScore.Size = new System.Drawing.Size(2, 17);
            this.lbLossScore.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score";
            // 
            // lbWon
            // 
            this.lbWon.AutoSize = true;
            this.lbWon.BackColor = System.Drawing.Color.Transparent;
            this.lbWon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWon.Location = new System.Drawing.Point(12, 234);
            this.lbWon.Name = "lbWon";
            this.lbWon.Size = new System.Drawing.Size(36, 15);
            this.lbWon.TabIndex = 11;
            this.lbWon.Text = "Won:";
            // 
            // lbLost
            // 
            this.lbLost.AutoSize = true;
            this.lbLost.BackColor = System.Drawing.Color.Transparent;
            this.lbLost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLost.Location = new System.Drawing.Point(12, 255);
            this.lbLost.Name = "lbLost";
            this.lbLost.Size = new System.Drawing.Size(34, 15);
            this.lbLost.TabIndex = 12;
            this.lbLost.Text = "Lost:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Airplane_Chicken1stA.VC.ResourceFile.ChickenLayingGrass_Fixed;
            this.pictureBox4.Location = new System.Drawing.Point(341, 404);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 119);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 377);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 87);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // Play_Airplane_Chicken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airplane_Chicken1stA.VC.ResourceFile._768x576;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 562);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbLost);
            this.Controls.Add(this.lbWon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLossScore);
            this.Controls.Add(this.lbWinScore);
            this.Controls.Add(this.lbCountGrass);
            this.Controls.Add(this.btnExitToMenu);
            this.Controls.Add(this.btnEnterRunway);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnLayEggs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play_Airplane_Chicken";
            this.Text = "Play_Airplane_Chicken";
            this.Load += new System.EventHandler(this.Play_Airplane_Chicken_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterRunway;
        private System.Windows.Forms.RadioButton rdoEggsRunway;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLayEggs;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.RadioButton rdoEggsOnGrass;
        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Label lbCountGrass;
        private System.Windows.Forms.Label lbWinScore;
        private System.Windows.Forms.Label lbLossScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWon;
        private System.Windows.Forms.Label lbLost;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}