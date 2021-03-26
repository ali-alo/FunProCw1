using RightJob.DAL;
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

        private void createTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTest();
        }

        private void newApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ApplicantEditForm();
            form.CreateNewApplicant();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To take test please select an applicant who is going for a test \n\nAfter that on the right-bottom corner press on 'Take Test' button.");
            MyForms.GetForm<ApplicantListForm>().Show();

        }
    }
}
