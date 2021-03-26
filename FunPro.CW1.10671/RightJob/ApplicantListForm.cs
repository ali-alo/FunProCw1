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
    public partial class ApplicantListForm : Form
    {
        public ApplicantListForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ApplicantListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            // empty the search field
            tbxSearch.Text = "";
        }

        public void LoadData()
        {
            // nullify the data first, and after that get all the applicants using RightJob.DAL classes
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new ApplicantList().GetAllApplicants();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // if the user did not select an attribute to sort by
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else
                    selectedAttribute = ByAttribute.Score;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new ApplicantList().Sort(selectedAttribute);
            }
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
                dgv.DataSource = new ApplicantList().Search(tbxSearch.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ApplicantEditForm();
            form.CreateNewApplicant();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Select an applicant");
            else
            {
                var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantEditForm().UpdateApplicant(a);
            }
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Select an applicant who is going for a test");
            else
            {
                var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new TakeTestForm().LoadForm(a);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantManager().Delete(a.Id);
                LoadData();
            }
        }
    }
}
