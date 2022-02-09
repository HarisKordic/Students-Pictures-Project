﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source_code.DataBase;
using Source_code.Entitites;

namespace Source_code.Forms
{
    public partial class frmMainView : Form
    {
        #region Form
        private ConnectionToDb _db= Db.DataBase;
        public frmMainView()
        {
            InitializeComponent();
            dgvStudents.AutoGenerateColumns=false;
            dgvStudentsSubjects.AutoGenerateColumns=false;
        }
        private void frmMainView_Load(object sender, EventArgs e)
        {
            LoadAllStudents(_db.Students.ToList());
            LoadStudentsSubjects(_db.StudentsPassedSubjects.ToList());
        }
        #endregion

        #region Loading data from DB to dgv's
        private void LoadStudentsSubjects(List<StudentPassedSubject> list)
        {
            try
            {
                dgvStudentsSubjects.DataSource=null;
                dgvStudentsSubjects.DataSource = list?? new List<StudentPassedSubject>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
                //Show the inner ex only if it's not null;
            }
        }
        private void LoadAllStudents(List <Student> list)
        {
            try
            {
                dgvStudents.DataSource=null;
                dgvStudents.DataSource = list ?? new List<Student>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
                //Show the inner ex only if it's not null;
            }
        }
        #endregion

        #region Search for subject  or student
        private void txtBoxStudentSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = txtBoxStudentSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(filter))
                LoadAllStudents(_db.Students.ToList());
            else
                LoadAllStudents(_db.Students.Where(s =>
                    s.Name.ToLower().Contains(filter) ||
                    s.Surname.ToLower().Contains(filter)).ToList());
        }

        private void txtBoxSubjectSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = txtBoxSubjectSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(filter))
                LoadStudentsSubjects(_db.StudentsPassedSubjects.ToList());
            else
                LoadStudentsSubjects(_db.StudentsPassedSubjects.Where(s =>
                    s.Subject.Name.ToLower().Contains(filter)).ToList());
        }

        #endregion

        #region Saving to file
        private void btnSaveStudentToFile_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("Students.csv",FileMode.OpenOrCreate))
            using(var  sw=new StreamWriter(fs))
            {
                for (int i = 0; i < _db.Students.ToList().Count; i++)
                    sw.WriteLine(_db.Students.ToList()[i].StudentInfo);
                MessageBox.Show("You successfully saved all of the students showed in the table!" +
                                " You can find the file under the name: 'Students.csv'",
                    "Successfull operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveStudentsSubjectsToFile_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("StudentsPassedSubjects.csv", FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
            {
                for (int i = 0; i < _db.StudentsPassedSubjects.ToList().Count; i++)
                    sw.WriteLine(_db.StudentsPassedSubjects.ToList()[i]);//ToString method of the given object is called;
                MessageBox.Show("You successfully saved all of the students and their passed subjects showed in the table!" +
                                " You can find the file under the name: 'StudentsPassedSubjects.csv'",
                    "Successfull operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Deleteing a subject or looking up student's pictures:
        private void dgvStudentsSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dgv = sender as DataGridView;
                if (dgv?.Columns[e.ColumnIndex] is DataGridViewButtonColumn)//?. because of possible Null ref. exception;
                {
                    var button = dgv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
                    if (button?.Text == "Delete subject")//Button for deleteing;
                    {
                        var studentSubject = dgv.Rows[e.RowIndex].DataBoundItem as StudentPassedSubject;
                        if (MessageBox.Show($"Are you sure you want to permanently delete {studentSubject.Subject}" +
                                            $"  subject from {studentSubject.Student} student?", "Warning you're " +
                                "about to delete a record from the Data Base", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            _db.StudentsPassedSubjects.Remove(studentSubject);
                            _db.SaveChanges();
                            LoadStudentsSubjects(_db.StudentsPassedSubjects.ToList());
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                            MessageBox.Show("Deletion successfully terminated!" +
                                            " Your record won't be deleted.", "Operation stopped",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else//Button for pictures;
                    {
                        LoadPicturesToStudents();
                        var studentSubject = dgv.Rows[e.RowIndex].DataBoundItem as StudentPassedSubject;
                        new frmStudentPicture(studentSubject.Student).ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Loading pictures for each student
        private void LoadPicturesToStudents()
        {
            try
            {
                foreach (var student in _db.Students)
                {
                    foreach (var picture in _db.StudentsPictures)
                    {
                        if (student.Id == picture.Student.Id)//Coresponding student;
                        {
                            var addPic = new StudentPicture()
                            {
                                Id = picture.Id,
                                Student = picture.Student,
                                Picture = picture.Picture,
                                Description = picture.Description,
                                Date = picture.Date
                            };
                            student.Pictures.Add(addPic);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion
    }
}