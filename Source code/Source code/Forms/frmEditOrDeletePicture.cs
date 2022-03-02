using Source_code.DataBase;
using Source_code.Entitites;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Source_code.Forms
{
    public partial class frmEditOrDeletePicture : Form
    {
        #region Form
        private readonly ConnectionToDb _db = Db.DataBase;
        private readonly Student Student;
        private int Counter;
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
                pbPicture.Image = Image.FromFile("no_image.jpg");
                txtBoxDescritpion.Text = String.Empty;
                this.Show();
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
                Counter = 0;
            }
        }
        #endregion

        #region Editing selected picture
        private void dtpDate_ValueChanged(object sender, EventArgs e) =>
            Student.Pictures[Counter].Date = dtpDate.Value;
        private void txtBoxDescritpion_TextChanged(object sender, EventArgs e) =>
            Student.Pictures[Counter].Description = txtBoxDescritpion.Text;
        private void pbPicture_Click(object sender, EventArgs e)
        {
            if (ofdFindPicture.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdFindPicture.FileName);//Insert desired picture;
            //Save newly added picture:
            Student.Pictures[Counter].Picture = Helpers.ImageConverter.ImageToByte(pbPicture.Image);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _db.Entry(Student.Pictures[Counter]).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show($"The displayed picture was successfully " +
                            $"edited for {Student}.", "Successful operation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Student.Pictures = _db.StudentsPictures.
                Where(p => p.Student.Id == this.Student.Id).ToList();//Loading pics from db;
            //Refreshing main view to newly edited info:
            pbPicture.Image = Helpers.ImageConverter.ByteToImage(Student.
                Pictures[Counter].Picture);
            txtBoxDescritpion.Text = Student.Pictures[Counter].Description;
            dtpDate.Value = Student.Pictures[Counter].Date;
        }

        #endregion

        #region Deleting a displayed picture
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to permanently delete" +
                                    $" the displayed picture for {Student}?",
                        "Dangerous operation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var picToDelete = this.Student.Pictures[Counter];
                    _db.StudentsPictures.Remove(picToDelete);
                    _db.SaveChanges();
                    MessageBox.Show($"Picture was successfully deleted for student {Student}",
                        "Successfull operation", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                    MessageBox.Show("Dear user, the displayed picture won't be deleted.",
                        "Successful operation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion
    }
}
