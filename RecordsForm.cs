using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.Rows.Clear();
            for (int i = 0; i < StudentData.students.Count; i++)
            {
                dgvStudents.Rows.Add(
                    StudentData.students[i].Id,
                    StudentData.students[i].Name,
                    StudentData.students[i].Age,
                    StudentData.students[i].Course,
                    StudentData.students[i].Gpa
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a Student ID.");
                txtSearch.Focus();
                return;
            }
            dgvStudents.ClearSelection();
            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                if (dgvStudents.Rows[i].Cells[0].Value != null &&
                    dgvStudents.Rows[i].Cells[0].Value.ToString() == txtSearch.Text)
                {
                    dgvStudents.Rows[i].Selected = true;
                    dgvStudents.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
            MessageBox.Show("Student not found.");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string id = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
                for (int i = 0; i < StudentData.students.Count; i++)
                {
                    if (StudentData.students[i].Id == id)
                    {
                        StudentData.students.RemoveAt(i);
                        StudentData.SaveData();
                        dgvStudents.Rows.RemoveAt(dgvStudents.SelectedRows[0].Index);
                        MessageBox.Show("Student deleted successfully.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a student first.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
