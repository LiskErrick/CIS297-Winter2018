namespace Yahtzee
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
            this.rollButton = new System.Windows.Forms.Button();
            this.die1 = new System.Windows.Forms.Label();
            this.die2 = new System.Windows.Forms.Label();
            this.die3 = new System.Windows.Forms.Label();
            this.die4 = new System.Windows.Forms.Label();
            this.die5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.onesScoreLabel = new System.Windows.Forms.Label();
            this.twosScoreLabel = new System.Windows.Forms.Label();
            this.threesScoreLabel = new System.Windows.Forms.Label();
            this.foursScoreLabel = new System.Windows.Forms.Label();
            this.fivesScoreLabel = new System.Windows.Forms.Label();
            this.sixesScoreLabel = new System.Windows.Forms.Label();
            this.holdDie1 = new System.Windows.Forms.CheckBox();
            this.holdDie2 = new System.Windows.Forms.CheckBox();
            this.holdDie3 = new System.Windows.Forms.CheckBox();
            this.holdDie4 = new System.Windows.Forms.CheckBox();
            this.holdDie5 = new System.Windows.Forms.CheckBox();
            this.upperBonusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(615, 485);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(389, 119);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // die1
            // 
            this.die1.AutoSize = true;
            this.die1.Location = new System.Drawing.Point(225, 176);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(0, 25);
            this.die1.TabIndex = 1;
            // 
            // die2
            // 
            this.die2.AutoSize = true;
            this.die2.Location = new System.Drawing.Point(432, 176);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(0, 25);
            this.die2.TabIndex = 2;
            // 
            // die3
            // 
            this.die3.AutoSize = true;
            this.die3.Location = new System.Drawing.Point(679, 176);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(0, 25);
            this.die3.TabIndex = 3;
            // 
            // die4
            // 
            this.die4.AutoSize = true;
            this.die4.Location = new System.Drawing.Point(882, 176);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(0, 25);
            this.die4.TabIndex = 4;
            // 
            // die5
            // 
            this.die5.AutoSize = true;
            this.die5.Location = new System.Drawing.Point(1092, 176);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(0, 25);
            this.die5.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1768, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Score Ones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1768, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Score Twos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1768, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Score Threes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1768, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Score Fours";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1768, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Score Fives";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1768, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "Score Sixes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1768, 446);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 37);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // onesScoreLabel
            // 
            this.onesScoreLabel.AutoSize = true;
            this.onesScoreLabel.Location = new System.Drawing.Point(1612, 149);
            this.onesScoreLabel.Name = "onesScoreLabel";
            this.onesScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.onesScoreLabel.TabIndex = 13;
            this.onesScoreLabel.Text = "label1";
            // 
            // twosScoreLabel
            // 
            this.twosScoreLabel.AutoSize = true;
            this.twosScoreLabel.Location = new System.Drawing.Point(1612, 187);
            this.twosScoreLabel.Name = "twosScoreLabel";
            this.twosScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.twosScoreLabel.TabIndex = 14;
            this.twosScoreLabel.Text = "label1";
            // 
            // threesScoreLabel
            // 
            this.threesScoreLabel.AutoSize = true;
            this.threesScoreLabel.Location = new System.Drawing.Point(1617, 235);
            this.threesScoreLabel.Name = "threesScoreLabel";
            this.threesScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.threesScoreLabel.TabIndex = 15;
            this.threesScoreLabel.Text = "label1";
            // 
            // foursScoreLabel
            // 
            this.foursScoreLabel.AutoSize = true;
            this.foursScoreLabel.Location = new System.Drawing.Point(1622, 278);
            this.foursScoreLabel.Name = "foursScoreLabel";
            this.foursScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.foursScoreLabel.TabIndex = 16;
            this.foursScoreLabel.Text = "label1";
            // 
            // fivesScoreLabel
            // 
            this.fivesScoreLabel.AutoSize = true;
            this.fivesScoreLabel.Location = new System.Drawing.Point(1627, 321);
            this.fivesScoreLabel.Name = "fivesScoreLabel";
            this.fivesScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.fivesScoreLabel.TabIndex = 17;
            this.fivesScoreLabel.Text = "label1";
            // 
            // sixesScoreLabel
            // 
            this.sixesScoreLabel.AutoSize = true;
            this.sixesScoreLabel.Location = new System.Drawing.Point(1622, 364);
            this.sixesScoreLabel.Name = "sixesScoreLabel";
            this.sixesScoreLabel.Size = new System.Drawing.Size(70, 25);
            this.sixesScoreLabel.TabIndex = 18;
            this.sixesScoreLabel.Text = "label1";
            // 
            // holdDie1
            // 
            this.holdDie1.AutoSize = true;
            this.holdDie1.Location = new System.Drawing.Point(230, 275);
            this.holdDie1.Name = "holdDie1";
            this.holdDie1.Size = new System.Drawing.Size(88, 29);
            this.holdDie1.TabIndex = 19;
            this.holdDie1.Text = "Hold";
            this.holdDie1.UseVisualStyleBackColor = true;
            this.holdDie1.CheckedChanged += new System.EventHandler(this.holdDie1_CheckedChanged);
            // 
            // holdDie2
            // 
            this.holdDie2.AutoSize = true;
            this.holdDie2.Location = new System.Drawing.Point(437, 278);
            this.holdDie2.Name = "holdDie2";
            this.holdDie2.Size = new System.Drawing.Size(88, 29);
            this.holdDie2.TabIndex = 20;
            this.holdDie2.Text = "Hold";
            this.holdDie2.UseVisualStyleBackColor = true;
            this.holdDie2.CheckedChanged += new System.EventHandler(this.holdDie2_CheckedChanged);
            // 
            // holdDie3
            // 
            this.holdDie3.AutoSize = true;
            this.holdDie3.Location = new System.Drawing.Point(684, 289);
            this.holdDie3.Name = "holdDie3";
            this.holdDie3.Size = new System.Drawing.Size(88, 29);
            this.holdDie3.TabIndex = 21;
            this.holdDie3.Text = "Hold";
            this.holdDie3.UseVisualStyleBackColor = true;
            this.holdDie3.CheckedChanged += new System.EventHandler(this.holdDie3_CheckedChanged);
            // 
            // holdDie4
            // 
            this.holdDie4.AutoSize = true;
            this.holdDie4.Location = new System.Drawing.Point(887, 277);
            this.holdDie4.Name = "holdDie4";
            this.holdDie4.Size = new System.Drawing.Size(88, 29);
            this.holdDie4.TabIndex = 22;
            this.holdDie4.Text = "Hold";
            this.holdDie4.UseVisualStyleBackColor = true;
            this.holdDie4.CheckedChanged += new System.EventHandler(this.holdDie4_CheckedChanged);
            // 
            // holdDie5
            // 
            this.holdDie5.AutoSize = true;
            this.holdDie5.Location = new System.Drawing.Point(1097, 267);
            this.holdDie5.Name = "holdDie5";
            this.holdDie5.Size = new System.Drawing.Size(88, 29);
            this.holdDie5.TabIndex = 23;
            this.holdDie5.Text = "Hold";
            this.holdDie5.UseVisualStyleBackColor = true;
            this.holdDie5.CheckedChanged += new System.EventHandler(this.holdDie5_CheckedChanged);
            // 
            // upperBonusLabel
            // 
            this.upperBonusLabel.AutoSize = true;
            this.upperBonusLabel.Location = new System.Drawing.Point(1622, 413);
            this.upperBonusLabel.Name = "upperBonusLabel";
            this.upperBonusLabel.Size = new System.Drawing.Size(0, 25);
            this.upperBonusLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2125, 817);
            this.Controls.Add(this.upperBonusLabel);
            this.Controls.Add(this.holdDie5);
            this.Controls.Add(this.holdDie4);
            this.Controls.Add(this.holdDie3);
            this.Controls.Add(this.holdDie2);
            this.Controls.Add(this.holdDie1);
            this.Controls.Add(this.sixesScoreLabel);
            this.Controls.Add(this.fivesScoreLabel);
            this.Controls.Add(this.foursScoreLabel);
            this.Controls.Add(this.threesScoreLabel);
            this.Controls.Add(this.twosScoreLabel);
            this.Controls.Add(this.onesScoreLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label die1;
        private System.Windows.Forms.Label die2;
        private System.Windows.Forms.Label die3;
        private System.Windows.Forms.Label die4;
        private System.Windows.Forms.Label die5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label onesScoreLabel;
        private System.Windows.Forms.Label twosScoreLabel;
        private System.Windows.Forms.Label threesScoreLabel;
        private System.Windows.Forms.Label foursScoreLabel;
        private System.Windows.Forms.Label fivesScoreLabel;
        private System.Windows.Forms.Label sixesScoreLabel;
        private System.Windows.Forms.CheckBox holdDie1;
        private System.Windows.Forms.CheckBox holdDie2;
        private System.Windows.Forms.CheckBox holdDie3;
        private System.Windows.Forms.CheckBox holdDie4;
        private System.Windows.Forms.CheckBox holdDie5;
        private System.Windows.Forms.Label upperBonusLabel;
    }
}

