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
    public partial class TakeTestForm : Form
    {
        public TakeTestForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }
        public TestName Test { get; set; }
        
        // to access particular instance of class
        private int id;

        public void LoadForm(Applicant applicant)
        {
            Applicant = applicant;
            lblName.Text = applicant.Name;
            ComboboxAddTests(applicant);
            MdiParent = MyForms.GetForm<ParentForm>();
        }

        private void ComboboxAddTests(Applicant applicant)
        {
            // split tests taken using comma and space, excluding first empty entry
            var TestsApplicantHasTaken = applicant.TestsTaken.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            var tests = new TestManager().GetAll();

            // if applicant has taken all tests already, do not even show the form
            if (TestsApplicantHasTaken.Length - tests.Count == 0)
            {
                MessageBox.Show("Applicant has taken all tests");
                Close();
            }
            // if the applicant hasn't taken any test yet
            else if (TestsApplicantHasTaken.Length == 0)
            {
                foreach (var test in tests)
                {
                    cbxTest.Items.Add(test);
                }
                Show();
            }
            // if the applicat has taken some tests, but not all
            else if (tests.Count - TestsApplicantHasTaken.Length > 0)
            {
                foreach (var test in tests)
                {
                    int i = 0;
                    if (test.Name == TestsApplicantHasTaken[i])
                    {
                         i++;
                    }
                    else
                    {
                        cbxTest.Items.Add(test);
                    }
                }
                Show();
            }
        }

        private void FillLabels(TestName Test)
        {
            lblQuestion1.Text = Test.Question1;
            lblQuestion2.Text = Test.Question2;
            lblQuestion3.Text = Test.Question3;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // updating Score of the applicant
            var score = 0;
            if(tbxAnswer1.Text == Test.Answer1)
            {
                Applicant.Score += 1;
                score += 1;
            }

            if (tbxAnswer2.Text == Test.Answer2)
            {
                Applicant.Score += 1;
                score += 1;
            }

            if (tbxAnswer3.Text == Test.Answer3)
            {
                Applicant.Score += 1;
                score += 1;
            }

            // UI message
            MessageBox.Show($"Thank you for participating! You score {score} out of 3");

            // updating tests taken by the applicant
            Applicant.TestsTaken += $", {Test.Name}";

            // saving updates to the database
            new ApplicantManager().Update(Applicant);

            MyForms.GetForm<ApplicantListForm>().Show();
            Close();
        }

        private void cbxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // identify an id of the selected test
                foreach (var test in new TestManager().GetAll())
                {
                    if (test.Name == cbxTest.SelectedItem.ToString())
                    {
                        id = test.Id;
                        break;
                    }
                }

                // get selected test from the database
                Test = new TestManager().GetById(id);

                // show questions
                FillLabels(Test);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
