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
            this.scoreThreeOfAKind = new System.Windows.Forms.Button();
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
            this.scoreFourOfAKind = new System.Windows.Forms.Button();
            this.scoreFullHouse = new System.Windows.Forms.Button();
            this.scoreSmallStraight = new System.Windows.Forms.Button();
            this.scoreLargeStraight = new System.Windows.Forms.Button();
            this.scoreYahtzee = new System.Windows.Forms.Button();
            this.scoreChance = new System.Windows.Forms.Button();
            this.threeOfAKindLabel = new System.Windows.Forms.Label();
            this.fourOfAKindLabel = new System.Windows.Forms.Label();
            this.fullHouseLabel = new System.Windows.Forms.Label();
            this.smallStraightLabel = new System.Windows.Forms.Label();
            this.largeStraightLabel = new System.Windows.Forms.Label();
            this.yahtzeeLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
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
            this.button1.Size = new System.Drawing.Size(243, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Score Ones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1768, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Score Twos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1768, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Score Threes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1768, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Score Fours";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1768, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Score Fives";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1768, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "Score Sixes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // scoreThreeOfAKind
            // 
            this.scoreThreeOfAKind.Location = new System.Drawing.Point(1768, 446);
            this.scoreThreeOfAKind.Name = "scoreThreeOfAKind";
            this.scoreThreeOfAKind.Size = new System.Drawing.Size(243, 37);
            this.scoreThreeOfAKind.TabIndex = 12;
            this.scoreThreeOfAKind.Text = "Score Three of a kind";
            this.scoreThreeOfAKind.UseVisualStyleBackColor = true;
            this.scoreThreeOfAKind.Click += new System.EventHandler(this.scoreThreeOfAKind_Click);
            // 
            // onesScoreLabel
            // 
            this.onesScoreLabel.AutoSize = true;
            this.onesScoreLabel.Location = new System.Drawing.Point(1585, 149);
            this.onesScoreLabel.Name = "onesScoreLabel";
            this.onesScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.onesScoreLabel.TabIndex = 13;
            // 
            // twosScoreLabel
            // 
            this.twosScoreLabel.AutoSize = true;
            this.twosScoreLabel.Location = new System.Drawing.Point(1585, 187);
            this.twosScoreLabel.Name = "twosScoreLabel";
            this.twosScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.twosScoreLabel.TabIndex = 14;
            // 
            // threesScoreLabel
            // 
            this.threesScoreLabel.AutoSize = true;
            this.threesScoreLabel.Location = new System.Drawing.Point(1585, 235);
            this.threesScoreLabel.Name = "threesScoreLabel";
            this.threesScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.threesScoreLabel.TabIndex = 15;
            // 
            // foursScoreLabel
            // 
            this.foursScoreLabel.AutoSize = true;
            this.foursScoreLabel.Location = new System.Drawing.Point(1585, 278);
            this.foursScoreLabel.Name = "foursScoreLabel";
            this.foursScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.foursScoreLabel.TabIndex = 16;
            // 
            // fivesScoreLabel
            // 
            this.fivesScoreLabel.AutoSize = true;
            this.fivesScoreLabel.Location = new System.Drawing.Point(1585, 321);
            this.fivesScoreLabel.Name = "fivesScoreLabel";
            this.fivesScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.fivesScoreLabel.TabIndex = 17;
            // 
            // sixesScoreLabel
            // 
            this.sixesScoreLabel.AutoSize = true;
            this.sixesScoreLabel.Location = new System.Drawing.Point(1585, 364);
            this.sixesScoreLabel.Name = "sixesScoreLabel";
            this.sixesScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.sixesScoreLabel.TabIndex = 18;
            // 
            // holdDie1
            // 
            this.holdDie1.AutoSize = true;
            this.holdDie1.Location = new System.Drawing.Point(230, 267);
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
            this.holdDie2.Location = new System.Drawing.Point(437, 267);
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
            this.holdDie3.Location = new System.Drawing.Point(684, 267);
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
            this.holdDie4.Location = new System.Drawing.Point(887, 267);
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
            this.upperBonusLabel.Location = new System.Drawing.Point(1585, 407);
            this.upperBonusLabel.Name = "upperBonusLabel";
            this.upperBonusLabel.Size = new System.Drawing.Size(161, 25);
            this.upperBonusLabel.TabIndex = 24;
            this.upperBonusLabel.Text = "Upper Bonus: 0";
            // 
            // scoreFourOfAKind
            // 
            this.scoreFourOfAKind.Location = new System.Drawing.Point(1768, 489);
            this.scoreFourOfAKind.Name = "scoreFourOfAKind";
            this.scoreFourOfAKind.Size = new System.Drawing.Size(243, 37);
            this.scoreFourOfAKind.TabIndex = 25;
            this.scoreFourOfAKind.Text = "Score Four of a kind";
            this.scoreFourOfAKind.UseVisualStyleBackColor = true;
            this.scoreFourOfAKind.Click += new System.EventHandler(this.scoreFourOfAKind_Click);
            // 
            // scoreFullHouse
            // 
            this.scoreFullHouse.Location = new System.Drawing.Point(1768, 532);
            this.scoreFullHouse.Name = "scoreFullHouse";
            this.scoreFullHouse.Size = new System.Drawing.Size(243, 37);
            this.scoreFullHouse.TabIndex = 26;
            this.scoreFullHouse.Text = "Score Full House";
            this.scoreFullHouse.UseVisualStyleBackColor = true;
            this.scoreFullHouse.Click += new System.EventHandler(this.scoreFullHouse_Click);
            // 
            // scoreSmallStraight
            // 
            this.scoreSmallStraight.Location = new System.Drawing.Point(1768, 575);
            this.scoreSmallStraight.Name = "scoreSmallStraight";
            this.scoreSmallStraight.Size = new System.Drawing.Size(243, 37);
            this.scoreSmallStraight.TabIndex = 27;
            this.scoreSmallStraight.Text = "Score Small Straight";
            this.scoreSmallStraight.UseVisualStyleBackColor = true;
            this.scoreSmallStraight.Click += new System.EventHandler(this.scoreSmallStraight_Click);
            // 
            // scoreLargeStraight
            // 
            this.scoreLargeStraight.Location = new System.Drawing.Point(1768, 618);
            this.scoreLargeStraight.Name = "scoreLargeStraight";
            this.scoreLargeStraight.Size = new System.Drawing.Size(243, 37);
            this.scoreLargeStraight.TabIndex = 28;
            this.scoreLargeStraight.Text = "Score Large Straight";
            this.scoreLargeStraight.UseVisualStyleBackColor = true;
            this.scoreLargeStraight.Click += new System.EventHandler(this.scoreLargeStraight_Click);
            // 
            // scoreYahtzee
            // 
            this.scoreYahtzee.Location = new System.Drawing.Point(1768, 661);
            this.scoreYahtzee.Name = "scoreYahtzee";
            this.scoreYahtzee.Size = new System.Drawing.Size(243, 37);
            this.scoreYahtzee.TabIndex = 29;
            this.scoreYahtzee.Text = "Score Yahtzee";
            this.scoreYahtzee.UseVisualStyleBackColor = true;
            this.scoreYahtzee.Click += new System.EventHandler(this.scoreYahtzee_Click);
            // 
            // scoreChance
            // 
            this.scoreChance.Location = new System.Drawing.Point(1768, 704);
            this.scoreChance.Name = "scoreChance";
            this.scoreChance.Size = new System.Drawing.Size(243, 37);
            this.scoreChance.TabIndex = 30;
            this.scoreChance.Text = "Score Chance";
            this.scoreChance.UseVisualStyleBackColor = true;
            this.scoreChance.Click += new System.EventHandler(this.scoreChance_Click);
            // 
            // threeOfAKindLabel
            // 
            this.threeOfAKindLabel.AutoSize = true;
            this.threeOfAKindLabel.Location = new System.Drawing.Point(1585, 446);
            this.threeOfAKindLabel.Name = "threeOfAKindLabel";
            this.threeOfAKindLabel.Size = new System.Drawing.Size(0, 25);
            this.threeOfAKindLabel.TabIndex = 31;
            // 
            // fourOfAKindLabel
            // 
            this.fourOfAKindLabel.AutoSize = true;
            this.fourOfAKindLabel.Location = new System.Drawing.Point(1585, 489);
            this.fourOfAKindLabel.Name = "fourOfAKindLabel";
            this.fourOfAKindLabel.Size = new System.Drawing.Size(0, 25);
            this.fourOfAKindLabel.TabIndex = 32;
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.AutoSize = true;
            this.fullHouseLabel.Location = new System.Drawing.Point(1585, 532);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(0, 25);
            this.fullHouseLabel.TabIndex = 33;
            // 
            // smallStraightLabel
            // 
            this.smallStraightLabel.AutoSize = true;
            this.smallStraightLabel.Location = new System.Drawing.Point(1585, 581);
            this.smallStraightLabel.Name = "smallStraightLabel";
            this.smallStraightLabel.Size = new System.Drawing.Size(0, 25);
            this.smallStraightLabel.TabIndex = 34;
            // 
            // largeStraightLabel
            // 
            this.largeStraightLabel.AutoSize = true;
            this.largeStraightLabel.Location = new System.Drawing.Point(1585, 618);
            this.largeStraightLabel.Name = "largeStraightLabel";
            this.largeStraightLabel.Size = new System.Drawing.Size(0, 25);
            this.largeStraightLabel.TabIndex = 35;
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.AutoSize = true;
            this.yahtzeeLabel.Location = new System.Drawing.Point(1585, 667);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(0, 25);
            this.yahtzeeLabel.TabIndex = 36;
            // 
            // chanceLabel
            // 
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Location = new System.Drawing.Point(1585, 710);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(0, 25);
            this.chanceLabel.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2125, 817);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.yahtzeeLabel);
            this.Controls.Add(this.largeStraightLabel);
            this.Controls.Add(this.smallStraightLabel);
            this.Controls.Add(this.fullHouseLabel);
            this.Controls.Add(this.fourOfAKindLabel);
            this.Controls.Add(this.threeOfAKindLabel);
            this.Controls.Add(this.scoreChance);
            this.Controls.Add(this.scoreYahtzee);
            this.Controls.Add(this.scoreLargeStraight);
            this.Controls.Add(this.scoreSmallStraight);
            this.Controls.Add(this.scoreFullHouse);
            this.Controls.Add(this.scoreFourOfAKind);
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
            this.Controls.Add(this.scoreThreeOfAKind);
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
        private System.Windows.Forms.Button scoreThreeOfAKind;
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
        private System.Windows.Forms.Button scoreFourOfAKind;
        private System.Windows.Forms.Button scoreFullHouse;
        private System.Windows.Forms.Button scoreSmallStraight;
        private System.Windows.Forms.Button scoreLargeStraight;
        private System.Windows.Forms.Button scoreYahtzee;
        private System.Windows.Forms.Button scoreChance;
        private System.Windows.Forms.Label threeOfAKindLabel;
        private System.Windows.Forms.Label fourOfAKindLabel;
        private System.Windows.Forms.Label fullHouseLabel;
        private System.Windows.Forms.Label smallStraightLabel;
        private System.Windows.Forms.Label largeStraightLabel;
        private System.Windows.Forms.Label yahtzeeLabel;
        private System.Windows.Forms.Label chanceLabel;
    }
}

