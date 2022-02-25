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

namespace Source_code.Forms
{
    public partial class frmAddNewStudent : Form
    {
        #region Form
        private ConnectionToDb _db= Db.DataBase;
        public frmAddNewStudent()
        {
            InitializeComponent();
            LoadAvaliableGenders();
        }

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

        #endregion

        #region Adding new student
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
