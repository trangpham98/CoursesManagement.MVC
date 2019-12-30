using Courses.Controller;
using Courses.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.View
{
    public partial class frmListCourse : Form
    {
        public frmListCourse()
        {
            InitializeComponent();
        }

        private void frmListCourse_Load(object sender, EventArgs e)
        {
            CourseController courseController = new CourseController();
            rtxLstCourse.Text = courseController.GetCourses(); ;
        }

        private void frmListCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
