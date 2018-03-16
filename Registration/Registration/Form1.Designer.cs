namespace Registration
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
            this.CourseLabel = new System.Windows.Forms.Label();
            this.courseDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.courseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(274, 169);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(98, 25);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Courses:";
            // 
            // courseDepartmentTextBox
            // 
            this.courseDepartmentTextBox.Location = new System.Drawing.Point(68, 121);
            this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
            this.courseDepartmentTextBox.Size = new System.Drawing.Size(123, 31);
            this.courseDepartmentTextBox.TabIndex = 1;
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.addCourseButton);
            this.courseGroupBox.Controls.Add(this.label3);
            this.courseGroupBox.Controls.Add(this.courseNameTextBox);
            this.courseGroupBox.Controls.Add(this.label2);
            this.courseGroupBox.Controls.Add(this.courseCodeTextBox);
            this.courseGroupBox.Controls.Add(this.label1);
            this.courseGroupBox.Controls.Add(this.courseDepartmentTextBox);
            this.courseGroupBox.Location = new System.Drawing.Point(599, 300);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(959, 506);
            this.courseGroupBox.TabIndex = 2;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Add A New Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.Location = new System.Drawing.Point(248, 121);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(123, 31);
            this.courseCodeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(424, 121);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(123, 31);
            this.courseNameTextBox.TabIndex = 5;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(686, 93);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(204, 82);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2143, 916);
            this.Controls.Add(this.courseGroupBox);
            this.Controls.Add(this.CourseLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.courseGroupBox.ResumeLayout(false);
            this.courseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.TextBox courseDepartmentTextBox;
        private System.Windows.Forms.GroupBox courseGroupBox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseCodeTextBox;
        private System.Windows.Forms.Label label1;
    }
}

