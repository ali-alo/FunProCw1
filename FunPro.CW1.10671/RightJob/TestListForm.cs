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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
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
    }
}
