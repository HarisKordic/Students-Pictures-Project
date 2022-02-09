using System.Windows.Forms;

namespace Source_code.Helpers
{
    internal static class Validator
    {
        public static bool ValidateControl(Control control, ErrorProvider err, string message)
        {
            bool valid = true;
            if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                valid = false;
            else if (control is ComboBox && (control as ComboBox).SelectedIndex < 0)
                valid = false;
            else if (control is PictureBox && (control as PictureBox).Image == null)
                valid = false;

            if (valid == false)
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
