namespace OOPWithForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.myTicketLabel = new System.Windows.Forms.Label();
            this.winningTIcketLabel = new System.Windows.Forms.Label();
            this.numbersTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 166);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spend $2 on a PowerBall ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myTicketLabel
            // 
            this.myTicketLabel.AutoSize = true;
            this.myTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTicketLabel.Location = new System.Drawing.Point(719, 407);
            this.myTicketLabel.Name = "myTicketLabel";
            this.myTicketLabel.Size = new System.Drawing.Size(0, 37);
            this.myTicketLabel.TabIndex = 1;
            // 
            // winningTIcketLabel
            // 
            this.winningTIcketLabel.AutoSize = true;
            this.winningTIcketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningTIcketLabel.Location = new System.Drawing.Point(1104, 407);
            this.winningTIcketLabel.Name = "winningTIcketLabel";
            this.winningTIcketLabel.Size = new System.Drawing.Size(0, 37);
            this.winningTIcketLabel.TabIndex = 2;
            // 
            // numbersTextBox
            // 
            this.numbersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersTextBox.Location = new System.Drawing.Point(685, 116);
            this.numbersTextBox.Name = "numbersTextBox";
            this.numbersTextBox.Size = new System.Drawing.Size(537, 44);
            this.numbersTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 226);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 816);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numbersTextBox);
            this.Controls.Add(this.winningTIcketLabel);
            this.Controls.Add(this.myTicketLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pretend to lose money";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label myTicketLabel;
        private System.Windows.Forms.Label winningTIcketLabel;
        private System.Windows.Forms.TextBox numbersTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

