using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        RegistrationDatabase database;
        public Form1()
        {
            InitializeComponent();
            database = new RegistrationDatabase();
            UpdateCourseListLabel();
            UpdateComboBox();

        }

        private void UpdateComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = database.Courses.Local;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Id";
            comboBox1.Refresh();
        }

        private void UpdateCourseListLabel()
        {
            CourseLabel.Text = "";
            foreach( var course in database.Courses )
            {
                CourseLabel.Text += $"{course.Department} {course.Code} - {course.Name}{Environment.NewLine}";
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course()
            {
                Department = courseDepartmentTextBox.Text,
                Name = courseNameTextBox.Text,
                Code = courseCodeTextBox.Text,
                Credits = 3
            };
            database.Courses.Add(newCourse);

            // should always try catch when doing database SaveChanges
            try
            {
                database.SaveChanges();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString());
                database.Dispose();
                database = new RegistrationDatabase();
            }

            UpdateCourseListLabel();
            UpdateComboBox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var course = comboBox1.SelectedItem as Course;

            // ?. is basically the same as
            if (course != null)
            {
                course.Id.ToString();
            }
            else
            {
                comboBoxLabel.Text = null;
            }
            // 

            comboBoxLabel.Text = course?.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sectionsForm = new Sections(database);
            sectionsForm.Show();
        }
    }
}
