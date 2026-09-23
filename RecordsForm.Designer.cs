namespace Student_Management_System
{
    partial class RecordsForm
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
            dgvStudents = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colGpa = new DataGridViewTextBoxColumn();
            lblRecords = new Label();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.HighlightText;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colAge, colCourse, colGpa });
            dgvStudents.Location = new Point(61, 130);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 30;
            dgvStudents.Size = new Size(681, 305);
            dgvStudents.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // colAge
            // 
            colAge.HeaderText = "Age";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            colAge.Width = 125;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "Course";
            colCourse.MinimumWidth = 6;
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            colCourse.Width = 125;
            // 
            // colGpa
            // 
            colGpa.HeaderText = "GPA";
            colGpa.MinimumWidth = 6;
            colGpa.Name = "colGpa";
            colGpa.ReadOnly = true;
            colGpa.Width = 125;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(12, 9);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(235, 41);
            lblRecords.TabIndex = 1;
            lblRecords.Text = "Student Records";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(61, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 55);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(41, 62);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(172, 31);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Student:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(219, 66);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter ID";
            txtSearch.Size = new Size(198, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.Location = new Point(449, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 33);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Desktop;
            btnClose.Location = new Point(711, 503);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 39);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // RecordsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 554);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(lblRecords);
            Controls.Add(dgvStudents);
            Name = "RecordsForm";
            Text = "Student Records";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colGpa;
        private Label lblRecords;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClose;
    }
}