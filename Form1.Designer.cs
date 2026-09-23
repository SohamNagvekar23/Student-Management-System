namespace Student_Management_System
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpStudentDetails = new GroupBox();
            txtCourse = new TextBox();
            txtName = new TextBox();
            lblCourse = new Label();
            lblName = new Label();
            txtGpa = new TextBox();
            txtAge = new TextBox();
            lblGPA = new Label();
            lblAge = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnRecords = new Button();
            btnClose = new Button();
            grpStudentDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(409, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management System";
            // 
            // grpStudentDetails
            // 
            grpStudentDetails.Controls.Add(txtCourse);
            grpStudentDetails.Controls.Add(txtName);
            grpStudentDetails.Controls.Add(lblCourse);
            grpStudentDetails.Controls.Add(lblName);
            grpStudentDetails.Controls.Add(txtGpa);
            grpStudentDetails.Controls.Add(txtAge);
            grpStudentDetails.Controls.Add(lblGPA);
            grpStudentDetails.Controls.Add(lblAge);
            grpStudentDetails.Controls.Add(txtId);
            grpStudentDetails.Controls.Add(lblId);
            grpStudentDetails.Location = new Point(28, 81);
            grpStudentDetails.Name = "grpStudentDetails";
            grpStudentDetails.Size = new Size(710, 143);
            grpStudentDetails.TabIndex = 1;
            grpStudentDetails.TabStop = false;
            grpStudentDetails.Text = "Student Details";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(469, 64);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(194, 27);
            txtCourse.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(469, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 8;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(411, 67);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(57, 20);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "Course:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(411, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(116, 106);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(194, 27);
            txtGpa.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(116, 64);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(194, 27);
            txtAge.TabIndex = 4;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(28, 109);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(39, 20);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "GPA:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(28, 67);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(194, 27);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Student ID:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnAdd.Location = new Point(28, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonShadow;
            btnUpdate.Location = new Point(304, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 44);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.Location = new Point(567, 290);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 44);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = SystemColors.ButtonShadow;
            btnRecords.Location = new Point(28, 383);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(171, 44);
            btnRecords.TabIndex = 5;
            btnRecords.Text = "Student Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Desktop;
            btnClose.Location = new Point(656, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 39);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRecords);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpStudentDetails);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management System";
            grpStudentDetails.ResumeLayout(false);
            grpStudentDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpStudentDetails;
        private Label lblId;
        private Label lblName;
        private TextBox txtGpa;
        private TextBox txtAge;
        private Label lblGPA;
        private Label lblAge;
        private TextBox txtId;
        private TextBox txtCourse;
        private TextBox txtName;
        private Label lblCourse;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnRecords;
        private Button btnClose;
    }
}
