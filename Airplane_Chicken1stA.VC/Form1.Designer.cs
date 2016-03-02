namespace Airplane_Chicken1stA.VC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbChicken = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PbChicken)).BeginInit();
            this.SuspendLayout();
            // 
            // PbChicken
            // 
            this.PbChicken.BackColor = System.Drawing.Color.Transparent;
            this.PbChicken.BackgroundImage = global::Airplane_Chicken1stA.VC.ResourceFile.MiniChicken2;
            this.PbChicken.Location = new System.Drawing.Point(348, 444);
            this.PbChicken.Name = "PbChicken";
            this.PbChicken.Size = new System.Drawing.Size(86, 108);
            this.PbChicken.TabIndex = 0;
            this.PbChicken.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Chocolate;
            this.Title.Location = new System.Drawing.Point(198, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(361, 59);
            this.Title.TabIndex = 1;
            this.Title.Text = "Airplane Chicken";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(306, 89);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(148, 36);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Airplane_Chicken1stA.VC.ResourceFile._768x576;
            this.ClientSize = new System.Drawing.Size(762, 573);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PbChicken);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Airplane Chicken";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbChicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbChicken;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnPlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

