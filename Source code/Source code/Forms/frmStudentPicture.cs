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
    }
}
