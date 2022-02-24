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
        public frmEditOrDeletePicture(Student student)
        {
           
        }
        #endregion

        #region Loading data to form 
      
        #endregion
    }
}
