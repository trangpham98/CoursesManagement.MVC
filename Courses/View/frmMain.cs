﻿using Courses.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddCourses frmAdd = new frmAddCourses();
            this.Hide();
            frmAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListCourse frmList = new frmListCourse();
            this.Hide();
            frmList.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchCouses frmSearch = new frmSearchCouses();
            this.Hide();
            frmSearch.ShowDialog();
        }
    }
}
