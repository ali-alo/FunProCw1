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
    public partial class TestEditForm : Form
    {
        public TestEditForm()
        {
            InitializeComponent();
        }

        public TestName Test { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewTest()
        {
            Mode = FormMode.CreateNew;
            Test = new TestName();
            // do not let this form escape the parent form
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void ShowTestInControls()
        {
            tbxName.Text = Test.Name;
            tbxQ1.Text = Test.Question1;
            tbxA1.Text = Test.Answer1;
            tbxQ2.Text = Test.Question2;
            tbxA2.Text = Test.Answer2;
            tbxQ3.Text = Test.Question3;
            tbxA3.Text = Test.Answer3;
        }

        private void GrabUserInput()
        {
            Test.Name = tbxName.Text;
            Test.Question1 = tbxQ1.Text;
            Test.Answer1 = tbxA1.Text;
            Test.Question2 = tbxQ2.Text;
            Test.Answer2 = tbxA2.Text;
            Test.Question3 = tbxQ3.Text;
            Test.Answer3 = tbxA3.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new TestManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Test);
                else
                    manager.Update(Test);

                // to refresh database right away
                MyForms.GetForm<TestListForm>().LoadData();
                MessageBox.Show("Saved");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateTest(DAL.TestName test)
        {
            Mode = FormMode.Update;
            Test = test;
            ShowTestInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
