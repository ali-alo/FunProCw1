namespace RightJob
{
    partial class TakeTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicant Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(199, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(21, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Question 1";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion1.Location = new System.Drawing.Point(51, 195);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(149, 20);
            this.lblQuestion1.TabIndex = 4;
            this.lblQuestion1.Text = "question 1 description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Question 2";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion2.Location = new System.Drawing.Point(51, 338);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(149, 20);
            this.lblQuestion2.TabIndex = 6;
            this.lblQuestion2.Text = "question 2 description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Question 3";
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion3.Location = new System.Drawing.Point(51, 468);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(149, 20);
            this.lblQuestion3.TabIndex = 8;
            this.lblQuestion3.Text = "question 3 description";
            // 
            // cbxTest
            // 
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Location = new System.Drawing.Point(118, 84);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(180, 28);
            this.cbxTest.TabIndex = 9;
            this.cbxTest.SelectedIndexChanged += new System.EventHandler(this.cbxTest_SelectedIndexChanged);
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Location = new System.Drawing.Point(73, 235);
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.Size = new System.Drawing.Size(256, 27);
            this.tbxAnswer1.TabIndex = 10;
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Location = new System.Drawing.Point(73, 374);
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.Size = new System.Drawing.Size(256, 27);
            this.tbxAnswer2.TabIndex = 11;
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Location = new System.Drawing.Point(73, 505);
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.Size = new System.Drawing.Size(256, 27);
            this.tbxAnswer3.TabIndex = 12;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(133, 557);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 38);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 617);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.tbxAnswer3);
            this.Controls.Add(this.tbxAnswer2);
            this.Controls.Add(this.tbxAnswer1);
            this.Controls.Add(this.cbxTest);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TakeTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Good luck with the test!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.TextBox tbxAnswer1;
        private System.Windows.Forms.TextBox tbxAnswer2;
        private System.Windows.Forms.TextBox tbxAnswer3;
        private System.Windows.Forms.Button btnFinish;
    }
}