namespace Exchange.LogData
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    public partial class Authorization : Form
    {
        private string path = Application.StartupPath + @"\Logs\MyLogs.txt";

        public Authorization()
        {
            InitializeComponent();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            this.LoginField.MaxLength = 16;
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.MaxLength = 16;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {             
            if (this.LoginField.Text.Length > 0 && this.PasswordField.Text.Length > 0)
            {
                AuthorizationDataVerification();
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
            this.Hide();
            passwordRecovery.StartPosition = FormStartPosition.Manual;
            passwordRecovery.Location = this.Location;
            passwordRecovery.Size = this.Size;
            passwordRecovery.Show();
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            MainSelectionMenu mainSelectionMenu = new MainSelectionMenu();
            this.Hide();
            mainSelectionMenu.StartPosition = FormStartPosition.Manual;
            mainSelectionMenu.Location = this.Location;
            mainSelectionMenu.Size = this.Size;
            mainSelectionMenu.Show();
            
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void AuthorizationDataVerification()
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
                this.Hide();
                exchange.StartPosition = FormStartPosition.Manual;
                exchange.Location = this.Location;
                exchange.Size = this.Size;
                exchange.Show();
            }
            else
            {
                MessageBox.Show("Wrong logs!");
            }
        }
    }
}
