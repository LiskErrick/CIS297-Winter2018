namespace Registration
{
    partial class Sections
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSections = new System.Windows.Forms.ListBox();
            this.textBoxCourseFilter = new System.Windows.Forms.TextBox();
            this.buttonApplyCOurseFilter = new System.Windows.Forms.Button();
            this.listBoxFaculty = new System.Windows.Forms.ListBox();
            this.listBoxTerm = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(82, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 454);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Sections";
            // 
            // listBoxSections
            // 
            this.listBoxSections.FormattingEnabled = true;
            this.listBoxSections.ItemHeight = 25;
            this.listBoxSections.Location = new System.Drawing.Point(664, 167);
            this.listBoxSections.Name = "listBoxSections";
            this.listBoxSections.Size = new System.Drawing.Size(426, 429);
            this.listBoxSections.TabIndex = 3;
            // 
            // textBoxCourseFilter
            // 
            this.textBoxCourseFilter.Location = new System.Drawing.Point(170, 695);
            this.textBoxCourseFilter.Name = "textBoxCourseFilter";
            this.textBoxCourseFilter.Size = new System.Drawing.Size(227, 31);
            this.textBoxCourseFilter.TabIndex = 4;
            // 
            // buttonApplyCOurseFilter
            // 
            this.buttonApplyCOurseFilter.Location = new System.Drawing.Point(477, 702);
            this.buttonApplyCOurseFilter.Name = "buttonApplyCOurseFilter";
            this.buttonApplyCOurseFilter.Size = new System.Drawing.Size(175, 29);
            this.buttonApplyCOurseFilter.TabIndex = 5;
            this.buttonApplyCOurseFilter.Text = "Filter Courses";
            this.buttonApplyCOurseFilter.UseVisualStyleBackColor = true;
            this.buttonApplyCOurseFilter.Click += new System.EventHandler(this.buttonApplyCOurseFilter_Click);
            // 
            // listBoxFaculty
            // 
            this.listBoxFaculty.FormattingEnabled = true;
            this.listBoxFaculty.ItemHeight = 25;
            this.listBoxFaculty.Location = new System.Drawing.Point(1289, 182);
            this.listBoxFaculty.Name = "listBoxFaculty";
            this.listBoxFaculty.Size = new System.Drawing.Size(377, 429);
            this.listBoxFaculty.TabIndex = 6;
            // 
            // listBoxTerm
            // 
            this.listBoxTerm.FormattingEnabled = true;
            this.listBoxTerm.ItemHeight = 25;
            this.listBoxTerm.Items.AddRange(new object[] {
            "Winter-2018",
            "Summer-2018",
            "Fall-2018"});
            this.listBoxTerm.Location = new System.Drawing.Point(1795, 182);
            this.listBoxTerm.Name = "listBoxTerm";
            this.listBoxTerm.Size = new System.Drawing.Size(331, 454);
            this.listBoxTerm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1855, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Terms";
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.Location = new System.Drawing.Point(1329, 702);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(313, 73);
            this.buttonAddSection.TabIndex = 9;
            this.buttonAddSection.Text = "Add Section";
            this.buttonAddSection.UseVisualStyleBackColor = true;
            this.buttonAddSection.Click += new System.EventHandler(this.buttonAddSection_Click);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2472, 822);
            this.Controls.Add(this.buttonAddSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTerm);
            this.Controls.Add(this.listBoxFaculty);
            this.Controls.Add(this.buttonApplyCOurseFilter);
            this.Controls.Add(this.textBoxCourseFilter);
            this.Controls.Add(this.listBoxSections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Sections";
            this.Text = "Sections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSections;
        private System.Windows.Forms.TextBox textBoxCourseFilter;
        private System.Windows.Forms.Button buttonApplyCOurseFilter;
        private System.Windows.Forms.ListBox listBoxFaculty;
        private System.Windows.Forms.ListBox listBoxTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddSection;
    }
}