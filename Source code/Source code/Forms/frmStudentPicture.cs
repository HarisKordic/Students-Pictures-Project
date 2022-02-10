using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source_code.Entitites;
using Source_code.Helpers;

namespace Source_code.Forms
{
    public partial class frmStudentPicture : Form
    {
        #region Form
        private Student Student;
        private int Counter = 0;//For enumerating through  multiple pictures;
        public frmStudentPicture(Student student)
        {
            InitializeComponent();
            this.Student = student;
        }
        #endregion

        #region Saving a new picture
        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //Save pic;
            }
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
                lblCurrentPicture.Text = $"Showing picture {Counter+1} out of {Student.Pictures.Count}";
                DisplayPicture.Image=Helpers.ImageConverter.ByteToImage(Student.Pictures[0].Picture);
                lblDateOfPicture.Text = $"Date:{Student.Pictures[0].Date}";
                lblDescription.Text = Student.Pictures[0].Description;
            }
            else
            {
                lblCurrentPicture.Text = $"Student {Student} doesn't have available pictures to show." +
                                         $"Please add pictures to the student.";
                DisplayPicture.Image = Image.FromFile("C:\\Users\\haris\\Desktop\\Student-Pictures-Project\\Source code\\Source code\\Resources\\no_image.jpg");
                lblDateOfPicture.Text = string.Empty;
                lblDescription.Text=string.Empty;
            }
        }
        #endregion
    }
}
