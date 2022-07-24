namespace Exchange.LogData
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    public partial class Registration : Form
    {   
        private string login;
        private string password;
        private string repeatPassword;
        private string path = Path.GetFullPath(
            @"C:\Users\Admin\source\repos\Exchanges\Exchange\Exchange\LogData\Logs\MyLogs.txt");

        public Registration()
        {
            InitializeComponent();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            this.LoginField.MaxLength = 16;
            this.login = this.LoginField.Text;
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.MaxLength = 16;
            this.password = this.PasswordField.Text;
        }

        private void RepeatPasswordField_Click(object sender, EventArgs e)
        {
            this.RepeatPasswordField.PasswordChar = '*';
            this.RepeatPasswordField.MaxLength = 16;
            this.repeatPassword = this.RepeatPasswordField.Text;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (this.LoginField.Text.Length > 0 && this.PasswordField.Text.Length > 0 &&
                password == repeatPassword)
            {
                using (StreamWriter sw = File.AppendText(this.path))
                {
                    sw.WriteLine(this.login);
                    sw.WriteLine(this.password);
                }

                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR! Pls try again!");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
