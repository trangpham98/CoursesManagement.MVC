using Courses.Controller;
using System;
using System.Windows.Forms;

namespace Courses.View
{
    public partial class frmSearchCouses : Form
    {
        public frmSearchCouses()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CourseController courseController = new CourseController();
            var course = courseController.Search(tbxCode.Text);
            if (course == null)
            { 
                MessageBox.Show("Cannot find course fron Code"); 
            }
            else
            {
                tbxCode.Text = course.Code;
                tbxName.Text = course.Name;
                tbxCredit.Text = course.Credit.ToString();
            }
        }

        private void frmSearchCouses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
