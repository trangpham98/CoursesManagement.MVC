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
    public partial class frmAddCourses : Form
    {
        public frmAddCourses()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCode.Text = "";
            tbxName.Text = "";
            tbxCredit.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseController courseController = new CourseController();
            var message = courseController.Insert(tbxCode.Text, tbxName.Text, tbxCredit.Text);
            MessageBox.Show(message);
        }

        private void frmAddCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
