namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.GroupBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.picLizard = new System.Windows.Forms.PictureBox();
            this.picSpock = new System.Windows.Forms.PictureBox();
            this.lblGameType = new System.Windows.Forms.Label();
            this.btnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(7, 30);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(144, 43);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(463, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBox
            // 
            this.btnBox.Controls.Add(this.btnInstructions);
            this.btnBox.Controls.Add(this.btnPlayAgain);
            this.btnBox.Controls.Add(this.btnExit);
            this.btnBox.Controls.Add(this.btnNewGame);
            this.btnBox.Location = new System.Drawing.Point(106, 238);
            this.btnBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnBox.Name = "btnBox";
            this.btnBox.Padding = new System.Windows.Forms.Padding(0);
            this.btnBox.Size = new System.Drawing.Size(614, 86);
            this.btnBox.TabIndex = 2;
            this.btnBox.TabStop = false;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(311, 27);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(144, 43);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "&Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(159, 30);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(144, 43);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "&Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.White;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(74, 8);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(397, 77);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "label1";
            // 
            // picRock
            // 
            this.picRock.AccessibleName = "Rock";
            this.picRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRock.BackgroundImage")));
            this.picRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRock.Location = new System.Drawing.Point(12, 89);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(149, 146);
            this.picRock.TabIndex = 4;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picPaper
            // 
            this.picPaper.AccessibleName = "Paper";
            this.picPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaper.BackgroundImage")));
            this.picPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaper.Location = new System.Drawing.Point(167, 89);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(149, 146);
            this.picPaper.TabIndex = 5;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picScissors
            // 
            this.picScissors.AccessibleName = "Scissors";
            this.picScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picScissors.BackgroundImage")));
            this.picScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScissors.Location = new System.Drawing.Point(322, 89);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(149, 146);
            this.picScissors.TabIndex = 6;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.BackColor = System.Drawing.Color.White;
            this.lblRatio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRatio.Location = new System.Drawing.Point(527, 9);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(176, 23);
            this.lblRatio.TabIndex = 7;
            this.lblRatio.Text = "Wins: 0 Losses: 0 Ties: 0";
            // 
            // picLizard
            // 
            this.picLizard.AccessibleName = "Lizard";
            this.picLizard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLizard.BackgroundImage")));
            this.picLizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLizard.Location = new System.Drawing.Point(477, 89);
            this.picLizard.Name = "picLizard";
            this.picLizard.Size = new System.Drawing.Size(149, 146);
            this.picLizard.TabIndex = 8;
            this.picLizard.TabStop = false;
            this.picLizard.Click += new System.EventHandler(this.picLizard_Click);
            // 
            // picSpock
            // 
            this.picSpock.AccessibleName = "Spock";
            this.picSpock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSpock.BackgroundImage")));
            this.picSpock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpock.Location = new System.Drawing.Point(632, 89);
            this.picSpock.Name = "picSpock";
            this.picSpock.Size = new System.Drawing.Size(149, 146);
            this.picSpock.TabIndex = 9;
            this.picSpock.TabStop = false;
            this.picSpock.Click += new System.EventHandler(this.picSpock_Click);
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Location = new System.Drawing.Point(523, 44);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(67, 21);
            this.lblGameType.TabIndex = 10;
            this.lblGameType.Text = "Players: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(796, 329);
            this.Controls.Add(this.lblGameType);
            this.Controls.Add(this.picSpock);
            this.Controls.Add(this.picLizard);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Final_Load);
            this.btnBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox btnBox;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.PictureBox picLizard;
        private System.Windows.Forms.PictureBox picSpock;
        private System.Windows.Forms.Label lblGameType;
    }
}

