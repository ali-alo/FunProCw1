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
    public partial class ApplicantEditForm : Form
    {
        public ApplicantEditForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public FormMode Mode { get; set; }

        private void ApplicantEditForm_Load(object sender, EventArgs e)
        {
            // get all tests from the database
            var tests = new TestList().GetAllTests();
            // add name of each test to the checkedListBox
            foreach (var test in tests)
            {
                CheckedListBoxAddItems(test.Name);
            }
        }

        public void CreateNewApplicant()
        {
            Mode = FormMode.CreateNew;
            Applicant = new Applicant();
            // do not let this form escape the parent form
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            Mode = FormMode.Update;
            Applicant = applicant;
            ShowTestInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        // to add items to the checkedListBox
        private int CheckedListBoxAddItems(object item)
        {
            return checkbxTests.Items.Add(item);
        }

        private void ShowTestInControls()
        {
            // wihtout Show() program throws an error. FormLoad executes after this method, that's why we need to invoke Load event
            Show();
            tbxName.Text = Applicant.Name;
            nudScore.Value = Applicant.Score;

            // split tests taken using comma and space
            var TestsApplicantHasTaken = Applicant.TestsTaken.Split(new char[] { ',', ' ' });

            var tests = new TestList().GetAllTests();
            // loop through each test 
            for (var i = 0; i < tests.Count; i++)
            {
                // checks if the applicant has already taken a particular test
                if(TestsApplicantHasTaken.Contains(checkbxTests.Items[i].ToString()))
                {
                    // if yes, check this test
                    checkbxTests.SetItemChecked(i, true);
                }
            }
            
        }

        private void GrabUserInput()
        {
            Applicant.Name = tbxName.Text;
            Applicant.Score = Convert.ToInt32(nudScore.Value);

            // initialize an empy list 
            List<string> testsTaken = new List<string>();

            // now add all to the TestsTaken column
            foreach (string test in checkbxTests.CheckedItems)
            {
                testsTaken.Add(test);
            }

            // comma separator
            Applicant.TestsTaken = String.Join(", ", testsTaken);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new ApplicantManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Applicant);
                else
                    manager.Update(Applicant);

                // to refresh database right away
                MyForms.GetForm<ApplicantListForm>().LoadData();
                MessageBox.Show("Saved");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
