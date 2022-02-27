using System.Windows.Forms;

namespace Source_code.Helpers
{
    internal static class Validator
    {
        public static bool ValidateControl(Control control, ErrorProvider error, string message)
        {
            bool valid = true;
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                valid = false;
            else if (control is ComboBox box && box.SelectedIndex < 0)
                valid = false;
            else if (control is PictureBox pictureBox && pictureBox.Image == null)
                valid = false;

            if (valid == false)
            {
                error.SetError(control, message);
                return false;
            }
            error.Clear();
            return true;
        }
    }
}
