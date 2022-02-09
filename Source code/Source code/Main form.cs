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

namespace Source_code
{
    public partial class Main_form : Form
    {
        #region Form
        public Main_form()
        {
            InitializeComponent();
        }
        #endregion

        #region Open links
        private void llblMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:kordicharis18@gmail.com");
        }
        private void llblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/HarisKordic");
        }
        #endregion

        #region Open main program
        private void btnStartProgram_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
