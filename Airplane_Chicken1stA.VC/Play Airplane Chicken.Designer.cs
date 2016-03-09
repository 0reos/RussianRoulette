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
            this.ShootAwayChoice = new System.Windows.Forms.GroupBox();
            this.rdoEggsOnGrass = new System.Windows.Forms.RadioButton();
            this.btnLayEggs = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.lbLayGrassCount = new System.Windows.Forms.Label();
            this.lbWinScore = new System.Windows.Forms.Label();
            this.lbLossScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWon = new System.Windows.Forms.Label();
            this.lbLost = new System.Windows.Forms.Label();
            this.pbOnRunway = new System.Windows.Forms.PictureBox();
            this.pbEnterRunway = new System.Windows.Forms.PictureBox();
            this.pbOnGrass = new System.Windows.Forms.PictureBox();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.ShootAwayChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnRunway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterRunway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnGrass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterRunway
            // 
            this.btnEnterRunway.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEnterRunway.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterRunway.Location = new System.Drawing.Point(9, 11);
            this.btnEnterRunway.Name = "btnEnterRunway";
            this.btnEnterRunway.Size = new System.Drawing.Size(146, 35);
            this.btnEnterRunway.TabIndex = 0;
            this.btnEnterRunway.Text = "Enter Runway ";
            this.btnEnterRunway.UseVisualStyleBackColor = false;
            this.btnEnterRunway.Click += new System.EventHandler(this.btnEnterRunway_Click);
            // 
            // rdoEggsRunway
            // 
            this.rdoEggsRunway.AutoSize = true;
            this.rdoEggsRunway.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEggsRunway.Location = new System.Drawing.Point(6, 19);
            this.rdoEggsRunway.Name = "rdoEggsRunway";
            this.rdoEggsRunway.Size = new System.Drawing.Size(124, 22);
            this.rdoEggsRunway.TabIndex = 1;
            this.rdoEggsRunway.TabStop = true;
            this.rdoEggsRunway.Text = "Eggs on Runway";
            this.rdoEggsRunway.UseVisualStyleBackColor = true;
            this.rdoEggsRunway.CheckedChanged += new System.EventHandler(this.rdoAllRadioButtons);
            // 
            // ShootAwayChoice
            // 
            this.ShootAwayChoice.BackColor = System.Drawing.Color.CadetBlue;
            this.ShootAwayChoice.Controls.Add(this.rdoEggsOnGrass);
            this.ShootAwayChoice.Controls.Add(this.rdoEggsRunway);
            this.ShootAwayChoice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAwayChoice.Location = new System.Drawing.Point(11, 59);
            this.ShootAwayChoice.Name = "ShootAwayChoice";
            this.ShootAwayChoice.Size = new System.Drawing.Size(144, 69);
            this.ShootAwayChoice.TabIndex = 3;
            this.ShootAwayChoice.TabStop = false;
            this.ShootAwayChoice.Text = "Lay";
            // 
            // rdoEggsOnGrass
            // 
            this.rdoEggsOnGrass.AutoSize = true;
            this.rdoEggsOnGrass.Location = new System.Drawing.Point(6, 42);
            this.rdoEggsOnGrass.Name = "rdoEggsOnGrass";
            this.rdoEggsOnGrass.Size = new System.Drawing.Size(109, 22);
            this.rdoEggsOnGrass.TabIndex = 2;
            this.rdoEggsOnGrass.TabStop = true;
            this.rdoEggsOnGrass.Text = "Eggs on Grass";
            this.rdoEggsOnGrass.UseVisualStyleBackColor = true;
            this.rdoEggsOnGrass.CheckedChanged += new System.EventHandler(this.rdoAllRadioButtons);
            // 
            // btnLayEggs
            // 
            this.btnLayEggs.BackColor = System.Drawing.Color.Chocolate;
            this.btnLayEggs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayEggs.Location = new System.Drawing.Point(12, 154);
            this.btnLayEggs.Name = "btnLayEggs";
            this.btnLayEggs.Size = new System.Drawing.Size(143, 28);
            this.btnLayEggs.TabIndex = 3;
            this.btnLayEggs.Text = "Lay Eggs ";
            this.btnLayEggs.UseVisualStyleBackColor = false;
            this.btnLayEggs.Click += new System.EventHandler(this.btnLayEggs_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlayAgain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(11, 251);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(104, 28);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again ";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Chocolate;
            this.btnExitToMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitToMenu.Location = new System.Drawing.Point(11, 303);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(104, 26);
            this.btnExitToMenu.TabIndex = 6;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // lbLayGrassCount
            // 
            this.lbLayGrassCount.AutoSize = true;
            this.lbLayGrassCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLayGrassCount.Location = new System.Drawing.Point(13, 134);
            this.lbLayGrassCount.Name = "lbLayGrassCount";
            this.lbLayGrassCount.Size = new System.Drawing.Size(14, 15);
            this.lbLayGrassCount.TabIndex = 7;
            this.lbLayGrassCount.Text = "2";
            // 
            // lbWinScore
            // 
            this.lbWinScore.AutoSize = true;
            this.lbWinScore.BackColor = System.Drawing.Color.Transparent;
            this.lbWinScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWinScore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinScore.Location = new System.Drawing.Point(49, 208);
            this.lbWinScore.Name = "lbWinScore";
            this.lbWinScore.Size = new System.Drawing.Size(2, 17);
            this.lbWinScore.TabIndex = 8;
            // 
            // lbLossScore
            // 
            this.lbLossScore.AutoSize = true;
            this.lbLossScore.BackColor = System.Drawing.Color.Transparent;
            this.lbLossScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLossScore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLossScore.Location = new System.Drawing.Point(49, 229);
            this.lbLossScore.Name = "lbLossScore";
            this.lbLossScore.Size = new System.Drawing.Size(2, 17);
            this.lbLossScore.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
            // 
            // lbWon
            // 
            this.lbWon.AutoSize = true;
            this.lbWon.BackColor = System.Drawing.Color.Transparent;
            this.lbWon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWon.Location = new System.Drawing.Point(12, 208);
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
            this.lbLost.Location = new System.Drawing.Point(12, 229);
            this.lbLost.Name = "lbLost";
            this.lbLost.Size = new System.Drawing.Size(34, 15);
            this.lbLost.TabIndex = 12;
            this.lbLost.Text = "Lost:";
            // 
            // pbOnRunway
            // 
            this.pbOnRunway.BackColor = System.Drawing.Color.Transparent;
            this.pbOnRunway.Location = new System.Drawing.Point(346, 444);
            this.pbOnRunway.Name = "pbOnRunway";
            this.pbOnRunway.Size = new System.Drawing.Size(87, 106);
            this.pbOnRunway.TabIndex = 13;
            this.pbOnRunway.TabStop = false;
            // 
            // pbEnterRunway
            // 
            this.pbEnterRunway.BackColor = System.Drawing.Color.Transparent;
            this.pbEnterRunway.Location = new System.Drawing.Point(669, 444);
            this.pbEnterRunway.Name = "pbEnterRunway";
            this.pbEnterRunway.Size = new System.Drawing.Size(88, 106);
            this.pbEnterRunway.TabIndex = 14;
            this.pbEnterRunway.TabStop = false;
            // 
            // pbOnGrass
            // 
            this.pbOnGrass.BackColor = System.Drawing.Color.Transparent;
            this.pbOnGrass.Location = new System.Drawing.Point(7, 373);
            this.pbOnGrass.Name = "pbOnGrass";
            this.pbOnGrass.Size = new System.Drawing.Size(80, 96);
            this.pbOnGrass.TabIndex = 15;
            this.pbOnGrass.TabStop = false;
            // 
            // btnClearScores
            // 
            this.btnClearScores.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearScores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScores.Location = new System.Drawing.Point(11, 277);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(104, 27);
            this.btnClearScores.TabIndex = 4;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = false;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // Play_Airplane_Chicken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airplane_Chicken1stA.VC.ResourceFile._768x576;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 562);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.pbOnGrass);
            this.Controls.Add(this.pbEnterRunway);
            this.Controls.Add(this.pbOnRunway);
            this.Controls.Add(this.lbLost);
            this.Controls.Add(this.lbWon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLossScore);
            this.Controls.Add(this.lbWinScore);
            this.Controls.Add(this.lbLayGrassCount);
            this.Controls.Add(this.btnExitToMenu);
            this.Controls.Add(this.btnEnterRunway);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnLayEggs);
            this.Controls.Add(this.ShootAwayChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play_Airplane_Chicken";
            this.Text = "Play_Airplane_Chicken";
            this.Load += new System.EventHandler(this.Play_Airplane_Chicken_Load);
            this.ShootAwayChoice.ResumeLayout(false);
            this.ShootAwayChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnRunway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterRunway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnGrass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterRunway;
        private System.Windows.Forms.RadioButton rdoEggsRunway;
        private System.Windows.Forms.GroupBox ShootAwayChoice;
        private System.Windows.Forms.Button btnLayEggs;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.RadioButton rdoEggsOnGrass;
        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Label lbLayGrassCount;
        private System.Windows.Forms.Label lbWinScore;
        private System.Windows.Forms.Label lbLossScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWon;
        private System.Windows.Forms.Label lbLost;
        private System.Windows.Forms.PictureBox pbOnRunway;
        private System.Windows.Forms.PictureBox pbEnterRunway;
        private System.Windows.Forms.PictureBox pbOnGrass;
        private System.Windows.Forms.Button btnClearScores;
    }
}