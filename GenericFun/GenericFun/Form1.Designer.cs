namespace GenericFun
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
            this.label = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.stringButton = new System.Windows.Forms.RadioButton();
            this.intsButton = new System.Windows.Forms.RadioButton();
            this.powerBallButton = new System.Windows.Forms.RadioButton();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(849, 240);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 25);
            this.label.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(1300, 240);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(373, 86);
            this.button.TabIndex = 1;
            this.button.Text = "Ordinary Button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.powerBallButton);
            this.GroupBox.Controls.Add(this.intsButton);
            this.GroupBox.Controls.Add(this.stringButton);
            this.GroupBox.Location = new System.Drawing.Point(141, 113);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(314, 337);
            this.GroupBox.TabIndex = 2;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Pick a type";
            // 
            // stringButton
            // 
            this.stringButton.AutoSize = true;
            this.stringButton.Location = new System.Drawing.Point(49, 84);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(110, 29);
            this.stringButton.TabIndex = 0;
            this.stringButton.TabStop = true;
            this.stringButton.Text = "Strings";
            this.stringButton.UseVisualStyleBackColor = true;
            // 
            // intsButton
            // 
            this.intsButton.AutoSize = true;
            this.intsButton.Location = new System.Drawing.Point(49, 156);
            this.intsButton.Name = "intsButton";
            this.intsButton.Size = new System.Drawing.Size(120, 29);
            this.intsButton.TabIndex = 1;
            this.intsButton.TabStop = true;
            this.intsButton.Text = "Integers";
            this.intsButton.UseVisualStyleBackColor = true;
            // 
            // powerBallButton
            // 
            this.powerBallButton.AutoSize = true;
            this.powerBallButton.Location = new System.Drawing.Point(49, 241);
            this.powerBallButton.Name = "powerBallButton";
            this.powerBallButton.Size = new System.Drawing.Size(139, 29);
            this.powerBallButton.TabIndex = 2;
            this.powerBallButton.TabStop = true;
            this.powerBallButton.Text = "PowerBall";
            this.powerBallButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2005, 612);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton intsButton;
        private System.Windows.Forms.RadioButton stringButton;
        private System.Windows.Forms.RadioButton powerBallButton;
    }
}

