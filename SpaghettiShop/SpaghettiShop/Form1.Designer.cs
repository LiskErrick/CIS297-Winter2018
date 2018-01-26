namespace SpaghettiShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.spaghettiButton = new System.Windows.Forms.RadioButton();
            this.mostaccioliButton = new System.Windows.Forms.RadioButton();
            this.AngelHairButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alfredoButton = new System.Windows.Forms.RadioButton();
            this.meatButton = new System.Windows.Forms.RadioButton();
            this.squidInkButton = new System.Windows.Forms.RadioButton();
            this.houseRedButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.shrimpButton = new System.Windows.Forms.CheckBox();
            this.meatballButton = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chickenButton = new System.Windows.Forms.CheckBox();
            this.garlicButton = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIck a type of noodle";
            // 
            // spaghettiButton
            // 
            this.spaghettiButton.AutoSize = true;
            this.spaghettiButton.Location = new System.Drawing.Point(49, 55);
            this.spaghettiButton.Name = "spaghettiButton";
            this.spaghettiButton.Size = new System.Drawing.Size(140, 29);
            this.spaghettiButton.TabIndex = 1;
            this.spaghettiButton.TabStop = true;
            this.spaghettiButton.Text = "Spaghetti:";
            this.spaghettiButton.UseVisualStyleBackColor = true;
            this.spaghettiButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // mostaccioliButton
            // 
            this.mostaccioliButton.AutoSize = true;
            this.mostaccioliButton.Location = new System.Drawing.Point(49, 126);
            this.mostaccioliButton.Name = "mostaccioliButton";
            this.mostaccioliButton.Size = new System.Drawing.Size(211, 29);
            this.mostaccioliButton.TabIndex = 2;
            this.mostaccioliButton.TabStop = true;
            this.mostaccioliButton.Text = "Mostaccioli $3.50";
            this.mostaccioliButton.UseVisualStyleBackColor = true;
            this.mostaccioliButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // AngelHairButton
            // 
            this.AngelHairButton.AutoSize = true;
            this.AngelHairButton.Location = new System.Drawing.Point(49, 205);
            this.AngelHairButton.Name = "AngelHairButton";
            this.AngelHairButton.Size = new System.Drawing.Size(209, 29);
            this.AngelHairButton.TabIndex = 3;
            this.AngelHairButton.TabStop = true;
            this.AngelHairButton.Text = "Angel Hair: $2.50";
            this.AngelHairButton.UseVisualStyleBackColor = true;
            this.AngelHairButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(546, 776);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(301, 63);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spaghettiButton);
            this.groupBox1.Controls.Add(this.mostaccioliButton);
            this.groupBox1.Controls.Add(this.AngelHairButton);
            this.groupBox1.Location = new System.Drawing.Point(55, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 386);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Noodles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pick a sauce";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alfredoButton);
            this.groupBox2.Controls.Add(this.meatButton);
            this.groupBox2.Controls.Add(this.squidInkButton);
            this.groupBox2.Controls.Add(this.houseRedButton);
            this.groupBox2.Location = new System.Drawing.Point(685, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 340);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sauce";
            // 
            // alfredoButton
            // 
            this.alfredoButton.AutoSize = true;
            this.alfredoButton.Location = new System.Drawing.Point(27, 230);
            this.alfredoButton.Name = "alfredoButton";
            this.alfredoButton.Size = new System.Drawing.Size(171, 29);
            this.alfredoButton.TabIndex = 3;
            this.alfredoButton.TabStop = true;
            this.alfredoButton.Text = "Alfredo $1.50";
            this.alfredoButton.UseVisualStyleBackColor = true;
            this.alfredoButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // meatButton
            // 
            this.meatButton.AutoSize = true;
            this.meatButton.Location = new System.Drawing.Point(27, 171);
            this.meatButton.Name = "meatButton";
            this.meatButton.Size = new System.Drawing.Size(151, 29);
            this.meatButton.TabIndex = 2;
            this.meatButton.TabStop = true;
            this.meatButton.Text = "Meat $2.00";
            this.meatButton.UseVisualStyleBackColor = true;
            this.meatButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // squidInkButton
            // 
            this.squidInkButton.AutoSize = true;
            this.squidInkButton.Location = new System.Drawing.Point(27, 107);
            this.squidInkButton.Name = "squidInkButton";
            this.squidInkButton.Size = new System.Drawing.Size(192, 29);
            this.squidInkButton.TabIndex = 1;
            this.squidInkButton.TabStop = true;
            this.squidInkButton.Text = "Squid Ink $5.00";
            this.squidInkButton.UseVisualStyleBackColor = true;
            this.squidInkButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // houseRedButton
            // 
            this.houseRedButton.AutoSize = true;
            this.houseRedButton.Location = new System.Drawing.Point(27, 42);
            this.houseRedButton.Name = "houseRedButton";
            this.houseRedButton.Size = new System.Drawing.Size(210, 29);
            this.houseRedButton.TabIndex = 0;
            this.houseRedButton.TabStop = true;
            this.houseRedButton.Text = "House Red $1.00";
            this.houseRedButton.UseVisualStyleBackColor = true;
            this.houseRedButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1188, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 63);
            this.label3.TabIndex = 8;
            this.label3.Text = "Other Stuff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.shrimpButton);
            this.groupBox3.Controls.Add(this.meatballButton);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.chickenButton);
            this.groupBox3.Controls.Add(this.garlicButton);
            this.groupBox3.Location = new System.Drawing.Point(1208, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 541);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // shrimpButton
            // 
            this.shrimpButton.AutoSize = true;
            this.shrimpButton.Location = new System.Drawing.Point(23, 296);
            this.shrimpButton.Name = "shrimpButton";
            this.shrimpButton.Size = new System.Drawing.Size(171, 29);
            this.shrimpButton.TabIndex = 4;
            this.shrimpButton.Text = "Shrimp $3.00";
            this.shrimpButton.UseVisualStyleBackColor = true;
            this.shrimpButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // meatballButton
            // 
            this.meatballButton.AutoSize = true;
            this.meatballButton.Location = new System.Drawing.Point(23, 229);
            this.meatballButton.Name = "meatballButton";
            this.meatballButton.Size = new System.Drawing.Size(188, 29);
            this.meatballButton.TabIndex = 3;
            this.meatballButton.Text = "MeatBall $2.00";
            this.meatballButton.UseVisualStyleBackColor = true;
            this.meatballButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Basil $.00";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // chickenButton
            // 
            this.chickenButton.AutoSize = true;
            this.chickenButton.Location = new System.Drawing.Point(23, 106);
            this.chickenButton.Name = "chickenButton";
            this.chickenButton.Size = new System.Drawing.Size(182, 29);
            this.chickenButton.TabIndex = 1;
            this.chickenButton.Text = "Chicken $1.00";
            this.chickenButton.UseVisualStyleBackColor = true;
            this.chickenButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // garlicButton
            // 
            this.garlicButton.AutoSize = true;
            this.garlicButton.Location = new System.Drawing.Point(23, 42);
            this.garlicButton.Name = "garlicButton";
            this.garlicButton.Size = new System.Drawing.Size(148, 29);
            this.garlicButton.TabIndex = 0;
            this.garlicButton.Text = "Garlic $.50";
            this.garlicButton.UseVisualStyleBackColor = true;
            this.garlicButton.CheckedChanged += new System.EventHandler(this.updatePriceLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 1108);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Spaghetti Spectacular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton spaghettiButton;
        private System.Windows.Forms.RadioButton mostaccioliButton;
        private System.Windows.Forms.RadioButton AngelHairButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton alfredoButton;
        private System.Windows.Forms.RadioButton meatButton;
        private System.Windows.Forms.RadioButton squidInkButton;
        private System.Windows.Forms.RadioButton houseRedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox shrimpButton;
        private System.Windows.Forms.CheckBox meatballButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chickenButton;
        private System.Windows.Forms.CheckBox garlicButton;
    }
}

