namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TB_Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Username.Text))
            {
                e.Cancel = true;
                TB_Username.Focus();
                EP_Username.SetError(TB_Username, "Username invalid");
            }
            else
            {
                EP_Username.SetError(TB_Username, null);
            }
        }

        private void TB_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Password.Text) || TB_Password.Text.Length < 7)
            {
                e.Cancel = true;
                TB_Password.Focus();
                EP_Password.SetError(TB_Password, "Password invalid");
            }
            else
            {
                EP_Password.SetError(TB_Password, null);
            }
        }
    }
}
