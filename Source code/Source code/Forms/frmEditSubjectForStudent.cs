using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source_code.DataBase;
using Source_code.Entitites;

namespace Source_code.Forms
{
    public partial class frmEditSubjectForStudent : Form
    {
        #region Form

        private ConnectionToDb _db = Db.DataBase;
        private StudentPassedSubject Sp;
        public frmEditSubjectForStudent(StudentPassedSubject sp)
        {
            InitializeComponent();
            this.Sp=sp;
            LoadAvaliableStudents(_db.Students.ToList());
            LoadAvaliableSubjects(_db.Subjects.ToList());
            cmbGrade.DataSource = new List<int>() {6, 7, 8, 9, 10};
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
            cmbStudents.SelectedItem = this.Sp.Student;
            cmbStudents.Enabled=false;//So no one can edit the student, only its assigned subject;
            cmbSubjects.SelectedItem = this.Sp.Subject;
            cmbGrade.SelectedItem=this.Sp.Grade;
            dtpDate.Value=this.Sp.Date;
        }
        #endregion

        #region Editing information for passed student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Sp.Subject=cmbSubjects.SelectedItem as Subject;
            this.Sp.Grade = int.Parse(cmbGrade.SelectedItem.ToString());
            this.Sp.Date=dtpDate.Value;
            _db.Entry(this.Sp).State=System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show($"Subject {Sp.Subject} was assigned to {Sp.Student}" +
                            $" with a grade {Sp.Grade}.", "Successful modification",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
    }
}
