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
    public partial class frmChoosePictureToEdit : Form
    {
        #region Form
        private ConnectionToDb _db = Db.DataBase;
        private Student Student;
        public frmChoosePictureToEdit(Student student)
        {
            InitializeComponent();
            dgvStudentsPictures.AutoGenerateColumns=false;
            this.Student = student;
        }
        #endregion

        #region Loading data to form 
        private void frmChoosePictureToEdit_Load(object sender, EventArgs e)
        {
            try
            {
                dgvStudentsPictures.DataSource=null;
                dgvStudentsPictures.DataSource =
                    _db.StudentsPictures.Where(sp => sp.Student.Id == this.Student.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Selecting picture to edit and/or deleting a picture
        private void dgvStudentsPictures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dgv = sender as DataGridView;
                if (dgv?.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    var studentPicture = dgv.Rows[e.RowIndex].DataBoundItem as StudentPicture;
                    if (MessageBox.Show($"Are you sure you want to delete the selected picture" +
                                        $" for student {this.Student}?", "Warning, dangerous operation"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _db.StudentsPictures.Remove(studentPicture);
                        _db.SaveChanges();
                        dgvStudentsPictures.DataSource = null;
                        dgvStudentsPictures.DataSource =
                            _db.StudentsPictures.Where(sp => sp.Student.Id == this.Student.Id).ToList();
                        MessageBox.Show("The selected picture was successfully deleted."
                            , "Picture deleted"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Operation cancelled. Picture won't be deleted"
                            , "Deletion cancelled"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var studentPicture = dgv?.Rows[e.RowIndex].DataBoundItem as StudentPicture;
                    this.Hide();
                    //new frmEditSelectedPicture(studentPicture).ShowDialog();//Edit picture;
                    this.Show();
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
