﻿using RightJob.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightJob
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void allApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ApplicantListForm>().Show();
        }

        private void allTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<TestListForm>().Show();

        }
    }
}
