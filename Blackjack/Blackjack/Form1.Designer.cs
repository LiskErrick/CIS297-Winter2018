namespace Blackjack
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
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHit = new System.Windows.Forms.Button();
            this.playerStandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(100, 60);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(0, 25);
            this.dealerLabel.TabIndex = 0;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(926, 146);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 25);
            this.playerLabel.TabIndex = 1;
            // 
            // playerHit
            // 
            this.playerHit.Location = new System.Drawing.Point(79, 543);
            this.playerHit.Name = "playerHit";
            this.playerHit.Size = new System.Drawing.Size(175, 81);
            this.playerHit.TabIndex = 2;
            this.playerHit.Text = "Hit";
            this.playerHit.UseVisualStyleBackColor = true;
            // 
            // playerStandButton
            // 
            this.playerStandButton.Location = new System.Drawing.Point(287, 543);
            this.playerStandButton.Name = "playerStandButton";
            this.playerStandButton.Size = new System.Drawing.Size(169, 81);
            this.playerStandButton.TabIndex = 3;
            this.playerStandButton.Text = "Stand";
            this.playerStandButton.UseVisualStyleBackColor = true;
            this.playerStandButton.Click += new System.EventHandler(this.playerStandButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 842);
            this.Controls.Add(this.playerStandButton);
            this.Controls.Add(this.playerHit);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button playerHit;
        private System.Windows.Forms.Button playerStandButton;
    }
}

