using Source_code.DataBase;
using Source_code.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmEditSubjectForStudent : Form
    {
        #region Form

        private  ConnectionToDb _db = Db.DataBase;
        private  StudentPassedSubject SPS;
        public frmEditSubjectForStudent(StudentPassedSubject sps)
        {
            InitializeComponent();
            this.SPS = sps;
            LoadAvaliableStudents(_db.Students.ToList());
            LoadAvaliableSubjects(_db.Subjects.ToList());
            cmbGrade.DataSource = new List<int>() { 6, 7, 8, 9, 10 };
            LoadInformation();
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

        #region Load data onto the form
        private void LoadInformation()
        {
            cmbStudents.SelectedItem = this.SPS.Student;
            cmbStudents.Enabled = false;//So no one can edit the student, only its assigned subject;
            cmbSubjects.SelectedItem = this.SPS.Subject;
            cmbGrade.SelectedItem = this.SPS.Grade;
            dtpDate.Value = this.SPS.Date;
        }
        #endregion

        #region Editing information for passed student
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.SPS.Subject = cmbSubjects.SelectedItem as Subject;
            this.SPS.Grade = int.Parse(cmbGrade.SelectedItem.ToString());
            this.SPS.Date = dtpDate.Value;
            _db.Entry(this.SPS).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show($"Contents of subject {SPS.Subject}  were edited for {SPS.Student}.",
                "Successful modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
    }
}
