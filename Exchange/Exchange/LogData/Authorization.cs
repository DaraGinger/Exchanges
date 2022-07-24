namespace Exchange.LogData
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    public partial class Authorization : Form
    {    
        private string login;
        private string password;
        private string path = Path.GetFullPath(
            @"C:\Users\Admin\source\repos\Exchanges\Exchange\Exchange\LogData\Logs\MyLogs.txt");

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
            string[] readData = File.ReadAllLines(this.path);
            string[] loginData = new string[readData.Length];
            string[] passwordData = new string[readData.Length];
            int countLoginArray = 0;
            int countPasswordArray = 0;
            int correctCount = 0;

           
            for (int i = 0; i < readData.Length; i++)
            {
                if (i % 2 == 0)
                {
                    loginData[countLoginArray] = readData[i];
                    countLoginArray++;
                }
                else
                {
                    passwordData[countPasswordArray] = readData[i];
                    countPasswordArray++;
                }
            }

            if (this.LoginField.Text.Length > 0 && this.PasswordField.Text.Length > 0)
            {
                for (int i = 0; i < readData.Length / 2; i++)
                {
                    if (this.LoginField.Text == loginData[i] && this.PasswordField.Text == passwordData[i])
                    {
                        correctCount++;
                        break;
                    }
                }

                if (correctCount == 1)
                {
                    Exchange exchange = new Exchange();
                    exchange.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong logs!");
                }
            }
            else if (this.LoginField.Text.Length <= 0 && this.PasswordField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login and password fields!");
            }
            else if (this.LoginField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login field!");
            }
            else
            {
                MessageBox.Show("Empty password field!");
            }
        }

        private void ResetPasswordLabelLink_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery();
            passwordRecovery.Show();
            this.Hide();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
