namespace Exchange.LogData
{
    using System;
    using System.Windows.Forms;
    public partial class Authorization : Form
    {
        private string password;
        private string login;
        private string path = @"..\Logs\";

        public Authorization()
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

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (this.LoginField.Text.Length != 0 && this.PasswordField.Text.Length != 0)
            {
                Exchange exchange = new Exchange();
                exchange.Show();
                this.Hide();
            }
            else if (this.LoginField.Text.Length == 0 && this.PasswordField.Text.Length == 0)
            {
                MessageBox.Show("Please, input login and password!");
            }
            else if (this.LoginField.Text.Length == 0)
            {
                MessageBox.Show("You don't input you're login!");
            }
            else
            {
                MessageBox.Show("Please, input password!");
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
