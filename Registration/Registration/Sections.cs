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
    public partial class Sections : Form
    {
        RegistrationDatabase database;
        public Sections(RegistrationDatabase database)
        {
            InitializeComponent();
            this.database = database;
            
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = database.Courses.ToList();
            listBox1.DisplayMember = "DisplayName";
            listBox1.ValueMember = "Id";
            listBox1.Refresh();

            listBoxSections.DataSource = null;
            listBoxSections.DataSource = database.Sections.ToList();
            listBoxSections.DisplayMember = "DisplayField";
            listBoxSections.ValueMember = "Id";
            listBoxSections.Refresh();

            listBoxFaculty.DataSource = null;
            listBoxFaculty.DataSource = database.Faculties.ToList();
            listBoxFaculty.DisplayMember = "Name";
            listBoxFaculty.ValueMember = "Id";
            listBoxFaculty.Refresh();
        }

        private void buttonApplyCOurseFilter_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = database.Courses.Where( course => 
            // it's a little hard to do case insentive comparisons here, using ToUpper() might work
                course.Code.ToUpper().Contains( textBoxCourseFilter.Text.ToUpper() ) ||
                course.Name.ToUpper().Contains(textBoxCourseFilter.Text.ToUpper()) ||
                course.Department.ToUpper().Contains(textBoxCourseFilter.Text.ToUpper()) ).ToList();
            listBox1.DisplayMember = "DisplayName";
            listBox1.ValueMember = "Id";
            listBox1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var course = listBox1.SelectedItem as Course;

            if (course != null)
            {
                listBoxSections.DataSource = null;
                listBoxSections.DataSource = database.Sections.Local.Where(section => section.Course == course).ToList();
                listBoxSections.DisplayMember = "DisplayField";
                listBoxSections.ValueMember = "Id";
                listBoxSections.Refresh();
            }
        }

        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            var course = listBox1.SelectedItem as Course;
            var faculty = listBoxFaculty.SelectedItem as Faculty;


            if (course != null && faculty != null)
            {
                var newSection = new Section()
                {
                    Course = course,
                    Faculty = faculty,
                    Term = listBoxTerm.SelectedItem.ToString()
                };

                database.Sections.Add(newSection);

                // should always try catch when doing database SaveChanges
                try
                {
                    database.SaveChanges();
                    RefreshListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    database.Sections.Remove(newSection);
                }

                
            }

        }
    }
}
