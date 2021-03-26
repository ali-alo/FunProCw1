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
    public partial class TestListForm : Form
    {
        public TestListForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void TestListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            // nullify the data first, and after that get all the applicants using RightJob.DAL classes
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new TestList().GetAllTests();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // if the input is empty or contains only spaces
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Cannot search for the empy records");
            else
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new TestList().Search(tbxSearch.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTest();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a test");
            else
            {
                var t = (TestName)dgv.SelectedRows[0].DataBoundItem;
                new TestEditForm().UpdateTest(t);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a test");
            else
            {
                var t = (TestName)dgv.SelectedRows[0].DataBoundItem;
                new TestManager().Delete(t.Id);
                LoadData();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadData();
            // empty the search field
            tbxSearch.Text = "";
        }
    }
}
