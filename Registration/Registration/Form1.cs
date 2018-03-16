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
            }

            UpdateCourseListLabel();
            
        }
    }
}
