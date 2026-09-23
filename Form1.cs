namespace Student_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please enter the Student ID.");
                txtId.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the student's name.");
                txtName.Focus();
                return;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Please enter the student's age.");
                txtAge.Focus();
                return;
            }
            if (txtCourse.Text == "")
            {
                MessageBox.Show("Please enter the course.");
                txtCourse.Focus();
                return;
            }
            if (txtGpa.Text == "")
            {
                MessageBox.Show("Please enter the GPA.");
                txtGpa.Focus();
                return;
            }
            Student student = new Student();
            student.Id = txtId.Text;
            student.Name = txtName.Text;
            student.Age = txtAge.Text;
            student.Course = txtCourse.Text;
            student.Gpa = txtGpa.Text;
            StudentData.students.Add(student);
            StudentData.SaveData();
            MessageBox.Show("Student added successfully.");
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            txtGpa.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StudentData.students.Count; i++)
            {
                if (StudentData.students[i].Id == txtId.Text)
                {
                    StudentData.students[i].Name = txtName.Text;
                    StudentData.students[i].Age = txtAge.Text;
                    StudentData.students[i].Course = txtCourse.Text;
                    StudentData.students[i].Gpa = txtGpa.Text;
                    StudentData.SaveData();
                    MessageBox.Show("Student updated successfully.");
                    txtId.Clear();
                    txtName.Clear();
                    txtAge.Clear();
                    txtCourse.Clear();
                    txtGpa.Clear();
                    return;
                }
            }

            MessageBox.Show("Student not found.");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            txtGpa.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
