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
            LoadAllStudents();
            LoadStudentsSubjects();
        }
        #endregion

        #region Loading data from DB to dgv's
        private void LoadStudentsSubjects()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
                //Show the inner ex only if it's not null;
            }
        }

        private void LoadAllStudents()
        {
            try
            {
                dgvStudents.DataSource=null;
                dgvStudents.DataSource = _db.Students.ToList();//Convert to list and set as data source;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
                //Show the inner ex only if it's not null;
            }
        }
        #endregion

    }
}
