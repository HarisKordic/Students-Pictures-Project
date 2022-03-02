using Source_code.DataBase;
using Source_code.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmAddSubjectToStudent : Form
    {
        #region Form

        private  ConnectionToDb _db = Db.DataBase;
        public frmAddSubjectToStudent()
        {
            InitializeComponent();
            cmbGrade.DataSource = new List<int> { 6, 7, 8, 9, 10 };
            LoadAvaliableStudents(_db.Students.ToList());
            LoadAvaliableSubjects(_db.Subjects.ToList());
        }
        #endregion

        #region Loading subjects
        private void LoadAvaliableSubjects(List<Subject> subjects)
        {
            try
            {
                cmbSubjects.DataSource = subjects ?? new List<Subject>();//Null checking;
                cmbSubjects.DisplayMember = "Name";
                cmbSubjects.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Loading students
        private void LoadAvaliableStudents(List<Student> students)
        {
            try
            {
                cmbStudents.DataSource = students ?? new List<Student>();//Null checking;
                cmbStudents.DisplayMember = "NameSurname";
                cmbStudents.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Adding a subject to a student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var subjectToAdd = cmbSubjects.SelectedItem as Subject;
            var studentToAdd = cmbStudents.SelectedItem as Student;

            //Only if the student did not already pass the subject, add it;
            if (!_db.StudentsPassedSubjects.ToList().Exists(
                    sS => sS.Student == studentToAdd && sS.Subject == subjectToAdd))
            {
                var newStudentSubject = new StudentPassedSubject()
                {
                    Student = studentToAdd,
                    Subject = subjectToAdd,
                    Date = dtpDate.Value,
                    Grade = int.Parse(cmbGrade.SelectedItem.ToString())
                };
                _db.StudentsPassedSubjects.Add(newStudentSubject);
                _db.SaveChanges();
                MessageBox.Show($"You successfully added subject: {subjectToAdd}" +
                                $" to student {studentToAdd}", "Successful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"{studentToAdd} has already passed {subjectToAdd}! You cannot add" +
                                $" subjects that the student has already passed.",
                    "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
