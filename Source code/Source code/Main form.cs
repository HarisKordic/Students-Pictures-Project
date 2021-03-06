using System;
using System.Windows.Forms;

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
            this.Hide();
            new Forms.frmMainView().ShowDialog();
            this.Show();
        }
        #endregion
    }
}
