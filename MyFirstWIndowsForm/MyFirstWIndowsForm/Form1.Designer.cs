namespace MyFirstWIndowsForm
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
            this.clickMeButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.rightOrWrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(1048, 277);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(393, 243);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Answer";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(277, 357);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(237, 63);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "1 + 1 = ?";
            // 
            // answerBox
            // 
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(562, 354);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(374, 68);
            this.answerBox.TabIndex = 2;
            this.answerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerBox_KeyPress);
            // 
            // rightOrWrongLabel
            // 
            this.rightOrWrongLabel.AutoSize = true;
            this.rightOrWrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOrWrongLabel.Location = new System.Drawing.Point(627, 126);
            this.rightOrWrongLabel.Name = "rightOrWrongLabel";
            this.rightOrWrongLabel.Size = new System.Drawing.Size(0, 63);
            this.rightOrWrongLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 1088);
            this.Controls.Add(this.rightOrWrongLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.clickMeButton);
            this.Name = "Form1";
            this.Text = "My First App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMeButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label rightOrWrongLabel;
    }
}

