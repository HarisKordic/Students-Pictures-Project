using Source_code.DataBase;
using Source_code.Entitites;
using Source_code.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmStudentPicture : Form
    {
        #region Form

        private readonly ConnectionToDb _db = Db.DataBase;
        private readonly Student Student;
        private int Counter;//For enumerating through  multiple pictures;
        public frmStudentPicture(Student student)
        {
            InitializeComponent();
            this.Student = student;
            Counter = 0;
            student.Pictures = _db.StudentsPictures.Where(p =>
                p.Student.Id == this.Student.Id).ToList();//For loading correct pics to each student;
        }
        #endregion

        #region Saving a new picture
        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var addNewPic = new StudentPicture()
                    {
                        Student = this.Student,
                        Date = DateTime.Now,
                        Picture = Helpers.ImageConverter.ImageToByte(AddPicture.Image),
                        Description = txtBoxDescription.Text
                    };
                    _db.StudentsPictures.Add(addNewPic);
                    _db.SaveChanges();
                    MessageBox.Show($"You successfully saved a new picture for {this.Student}!",
                        "Successfull operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddPicture.Image = null;
                    txtBoxDescription.Text = string.Empty;
                    LoadPicturesToStudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        //Loading newly saved pictures to the student:
        private void LoadPicturesToStudent()
        {
            this.Student.Pictures = _db.StudentsPictures.Where(p =>
                p.Student.Id == this.Student.Id).ToList();
            lblCurrentPicture.Text = $"Showing picture {Counter + 1} out of {Student.Pictures.Count}";
            DisplayPicture.Image = Helpers.ImageConverter.ByteToImage(Student.Pictures[0].Picture);
            lblDateOfPicture.Text = $"Date:{Student.Pictures[0].Date}";
            lblDescription.Text = Student.Pictures[0].Description;
        }
        private void AddPicture_Click(object sender, EventArgs e)
        {
            if (opfFindPicture.ShowDialog() == DialogResult.OK)
                AddPicture.Image = Image.FromFile(opfFindPicture.FileName);//Display the found picture;
        }
        private bool ValidateInput() => Validator.ValidateControl(txtBoxDescription, error,
                                            "This field is required!") &&
                                        Validator.ValidateControl(AddPicture, error,
                                            "This field is required!");

        #endregion

        #region Loading start info to the form
        private void frmStudentPicture_Load(object sender, EventArgs e)
        {
            if (Student.Pictures.Count > 0)
            {
                lblCurrentPicture.Text = $"Showing picture {Counter + 1} out of {Student.Pictures.Count}";
                DisplayPicture.Image = Helpers.ImageConverter.ByteToImage(Student.Pictures[0].Picture);
                lblDateOfPicture.Text = $"Date:{Student.Pictures[0].Date.ToString("dd MM yyyy")}";
                lblDescription.Text = Student.Pictures[0].Description;
            }
            else
            {
                lblCurrentPicture.Text = $"Student {Student} doesn't have available pictures to show." +
                                         $"Please add pictures to the student.";
                DisplayPicture.Image = Image.FromFile("C:\\Users\\haris\\Desktop\\Student-Pictures-Project\\Source code\\Source code\\Resources\\no_image.jpg");
                lblDateOfPicture.Text = string.Empty;
                lblDescription.Text = string.Empty;
            }
        }
        #endregion

        #region Navigation of pictures
        private void btnRight_Click(object sender, EventArgs e)
        {
            Counter++;
            if (Counter >= 0 && Counter <= this.Student.Pictures.Count - 1)
            {
                DisplayPicture.Image = Helpers.ImageConverter.ByteToImage(Student.Pictures
                    [Counter].Picture);
                lblCurrentPicture.Text = $"Showing picture {Counter + 1} out of {Student.Pictures.Count}";
                lblDescription.Text = Student.Pictures[Counter].Description;
                lblDateOfPicture.Text = $"Date: {Student.Pictures[Counter].Date.ToString("dd MM yyyy")}";
            }
            else
            {
                MessageBox.Show("Dear user, you got to the end (last picture)," +
                                "please move backwards.", "Invalid move", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Counter--;
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            Counter--;
            if (Counter >= 0 && Counter <= this.Student.Pictures.Count - 1)
            {
                DisplayPicture.Image = Helpers.ImageConverter.ByteToImage(Student.Pictures
                    [Counter].Picture);
                lblCurrentPicture.Text = $"Showing picture {Counter + 1} out of {Student.Pictures.Count}";
                lblDescription.Text = Student.Pictures[Counter].Description;
                lblDateOfPicture.Text = $"Date: {Student.Pictures[Counter].Date.ToString("dd MM yyyy")}";
            }
            else
            {
                MessageBox.Show("Dear user, you got to the end (first picture)," +
                                "please move forwards.", "Invalid move", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Counter = 0;
            }
        }
        #endregion

        #region Editing added picures
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEditOrDeletePicture(this.Student).ShowDialog();
            //Loading newly addes content:
            this.Student.Pictures=_db.StudentsPictures.Where(sp=>
                sp.Student.Id==this.Student.Id).ToList();
            if (this.Student.Pictures.Count > 0)
            {
                lblCurrentPicture.Text = $"Showing picture {Counter + 1} out of {Student.Pictures.Count}";
                Counter = 0;//Reset counter;
                DisplayPicture.Image = Helpers.ImageConverter.ByteToImage(Student.Pictures[0].Picture);
                lblDateOfPicture.Text = $"Date: {Student.Pictures[0].Date.ToString("dd MM yyyy")}";
                lblDescription.Text = Student.Pictures[0].Description;
            }
            else//If student doesnt have any pictures:
            {
                lblCurrentPicture.Text = $"Student {Student} doesn't have available pictures to show." +
                                         $"Please add pictures to the student.";
                DisplayPicture.Image = Image.FromFile("C:\\Users\\haris\\Desktop\\Student-Pictures-Project\\Source code\\Source code\\Resources\\no_image.jpg");
                lblDateOfPicture.Text = string.Empty;
                lblDescription.Text = string.Empty;
            }
            this.Show();
        }
        #endregion
    }
}
