using Source_code.DataBase;
using Source_code.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmAddNewStudent : Form
    {
        #region Form
        private readonly ConnectionToDb _db = Db.DataBase;
        public frmAddNewStudent()
        {
            InitializeComponent();
            LoadAvaliableGenders();
            LoadAvaliableSemesters();
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

        #region Loading Semesters
        private void LoadAvaliableSemesters() => cmbSemester.DataSource =
            new List<int> { 1, 2, 3, 4, 5, 6 };
        #endregion

        #region Adding new student
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                var student = new Student()
                {
                    Name = txtBoxName.Text,
                    Surname = txtBoxSurname.Text,
                    PhoneNumber = txtBoxPhoneNumber.Text,
                    BirthDay = dtpBirthday.Value,
                    Gender = cmbGender.SelectedItem as Gender,
                    AcademicYear = txtBoxAcademicYear.Text,
                    Semester = int.Parse(cmbSemester.SelectedItem.ToString())
                };
                _db.Students.Add(student);//Add new student;
                _db.SaveChanges();
                MessageBox.Show($"Student {student} was successfully added!",
                    "Successful operation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidateControls() => Helpers.Validator.ValidateControl(txtBoxName, error,
            "Required field!") && Helpers.Validator.ValidateControl(txtBoxSurname, error,
            "Required field!") && Helpers.Validator.ValidateControl(txtBoxAcademicYear, error,
            "Required field!") && Helpers.Validator.ValidateControl(txtBoxPhoneNumber, error,
            "Required field!") && Helpers.Validator.ValidateControl(cmbSemester, error,
            "Required field!") && Helpers.Validator.ValidateControl(cmbGender, error,
            "Required field!");
        #endregion
    }
}
