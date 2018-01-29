namespace WindowsFormsApplication1
{
    partial class LoadGameType
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
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(30, 25);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(95, 36);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Single Player";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Location = new System.Drawing.Point(131, 25);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(95, 36);
            this.btnTwoPlayer.TabIndex = 1;
            this.btnTwoPlayer.Text = "Two Player";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like to play single player or two player?";
            // 
            // LoadGameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(281, 74);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnSingle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadGameType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single or Two Player";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadGameType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Label label1;
    }
}