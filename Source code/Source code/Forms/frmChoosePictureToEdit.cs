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

namespace Source_code.Forms
{
    public partial class frmChoosePictureToEdit : Form
    {
        #region Form
        private Student Student;
        public frmChoosePictureToEdit(Student student)
        {
            InitializeComponent();
            this.Student = student;
        }
        #endregion
    }
}
