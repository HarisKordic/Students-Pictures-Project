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
    public partial class frmAddSubjectToStudent : Form
    {
        #region Form

        private ConnectionToDb _db = Db.DataBase;
        public frmAddSubjectToStudent()
        {
            InitializeComponent();
            cmbGrade.DataSource = new List<int> {6, 7, 8, 9, 10};
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
    }
}
