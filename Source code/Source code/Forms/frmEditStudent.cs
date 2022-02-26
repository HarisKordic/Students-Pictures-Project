using Source_code.DataBase;
using Source_code.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmEditStudent : Form
    {
        #region Form
        private ConnectionToDb _db = Db.DataBase;
        private Student Student;//Passed student;
        public frmEditStudent(Student student)
        {
            InitializeComponent();
            this.Student = student;
            LoadInfo();
            cmbSemester.DataSource = new List<int>() { 1, 2, 3, 4, 5, 6 };
            LoadAvaliableGenders();
        }
        #endregion

        #region Loading Genders
        private void LoadAvaliableGenders()
        {
            try
            {
                cmbGender.DataSource = _db.Genders.ToList();
                cmbGender.ValueMember = "Id";
                cmbGender.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Loading info from passed student
        private void LoadInfo()
        {
            txtBoxName.Text = this.Student.Name;
            txtBoxSurname.Text = this.Student.Surname;
            txtBoxAcademicYear.Text = this.Student.AcademicYear;
            txtBoxPhoneNumber.Text = this.Student.PhoneNumber;
            cmbGender.SelectedItem = this.Student.Gender;
            cmbSemester.SelectedItem = this.Student.Semester;
            dtpBirthday.Value = this.Student.BirthDay;
        }
        #endregion

        #region Editing student information
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
