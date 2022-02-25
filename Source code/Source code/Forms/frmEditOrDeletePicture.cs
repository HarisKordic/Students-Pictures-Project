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
    public partial class frmEditOrDeletePicture : Form
    {
        #region Form
        private ConnectionToDb _db = Db.DataBase;
        private Student Student;
        private  int Counter;
        public frmEditOrDeletePicture(Student student)
        {
            InitializeComponent();
            this.Student = student;
            Counter = 0;
            this.Student.Pictures = _db.StudentsPictures.Where(p => 
                p.Student.Id == this.Student.Id).ToList();
        }
        #endregion

        #region Loading data to form 
        private void frmEditOrDeletePicture_Load(object sender, EventArgs e)
        {
            if (Student.Pictures.Count > 0)
            {
                pbPicture.Image = Helpers.ImageConverter.ByteToImage(Student.
                    Pictures[Counter].Picture);
                txtBoxDescritpion.Text = Student.Pictures[Counter].Description;
                dtpDate.Value = Student.Pictures[Counter].Date;
            }
            else
            {
                pbPicture.Image=Image.FromFile("C:\\Users\\haris\\Desktop\\Student-Pictures-Project\\Source code" +
                                               "\\Source code\\Resources\\no_image.jpg");
                txtBoxDescritpion.Text = String.Empty;
                MessageBox.Show($"Student {Student} ,currently does not have any" +
                                " pictures added to edit/modify. Please, add pictures to this student," +
                                " and then try to edit/modify them.", "Action not avaliable",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigating to next and previous picture
        private void btnNext_Click(object sender, EventArgs e)
        {
            Counter++;
            if (Counter >= 0 && Counter <= Student.Pictures.Count - 1)
            {
                pbPicture.Image = Helpers.ImageConverter.ByteToImage(Student.
                    Pictures[Counter].Picture);
                txtBoxDescritpion.Text = Student.Pictures[Counter].Description;
                dtpDate.Value = Student.Pictures[Counter].Date;
            }
            else//If out of range 'Count';
            {
                MessageBox.Show("Dear user, you got to the end (last picture)," +
                                "please move backwards.", "Invalid move",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Counter--;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Counter--;
            if (Counter >= 0 && Counter <= Student.Pictures.Count - 1)
            {
                pbPicture.Image = Helpers.ImageConverter.ByteToImage(Student.
                    Pictures[Counter].Picture);
                txtBoxDescritpion.Text = Student.Pictures[Counter].Description;
                dtpDate.Value = Student.Pictures[Counter].Date;
            }
            else//If negative;
            {
                MessageBox.Show("Dear user, you got to the end (first picture)," +
                                "please move forwards.", "Invalid move",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Counter=0;
            }
        }
        #endregion
    }
}
